using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace SensitivityTool
{
    [SupportedOSPlatform("windows")]
    public partial class SensitivityToolMain : Form
    {
        private static GameSettings Games;
        private static Game Origin;
        private static Game Target;

        public SensitivityToolMain()
        {
            InitializeComponent();
            Games = GameSettings.Read();
            if (Games == null)
                return;

            OriginGames.PopulateTrees(Games);
            TargetGames.PopulateTrees(Games);
        }

        private void OriginFOV_ValueChanged(object sender, EventArgs e) => UpdateValues();
        private void OriginSensitivity_ValueChanged(object sender, EventArgs e) => UpdateValues();
        private void TargetFOV_ValueChanged(object sender, EventArgs e) => UpdateValues();

        private void TargetGames_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selection = TargetGames.SelectedNode?.Text;

            if (selection != null)
            {
                var engine = Games.Engines.Values.FirstOrDefault(engine => engine.ContainsKey(selection));
                if (engine != null && engine.TryGetValue(selection, out var game))
                    Target = game;
            }

            UpdateValues();
        }

        private void OriginGames_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selection = OriginGames.SelectedNode?.Text;

            if (selection != null)
            {
                var engine = Games.Engines.Values.FirstOrDefault(engine => engine.ContainsKey(selection));
                if (engine != null && engine.TryGetValue(selection, out var game))
                    Origin = game;
            }

            UpdateValues();
        }

        private void UpdateValues()
        {
            if (Origin != null && Target != null)
            {
                OriginFOV.Enabled = Origin.AffectedByFOV;
                TargetFOV.Enabled = Target.AffectedByFOV;

                TargetSensitivity.Text = Calculate(OriginSensitivity.Value, Origin.Yaw, Target.Yaw, OriginFOV.Enabled ? OriginFOV.Value : 65, TargetFOV.Enabled ? TargetFOV.Value : 65).ToString();
            }
        }

        private static double Calculate(decimal sensitivity, double originYaw, double targetYaw, decimal originFOV, decimal targetFOV)
        {
            var originRadians = Math.PI * (int)originFOV / 180.0;
            var originTan = Math.Tan(originRadians / 2.0);

            var targetRadians = Math.PI * (int)targetFOV / 180.0;
            var targetTan = Math.Tan(targetRadians / 2.0);

            var kek = (double)sensitivity * (originYaw / targetYaw) * (originTan / targetTan);
            return kek;
        }
    }

    public class GameSettings
    {
        public Dictionary<string, Dictionary<string, Game>> Engines { get; set; }

        public static GameSettings Read()
        {
            var file = "Games.json";
            if (!File.Exists(file))
            {
                Console.WriteLine("Games.json not found.");
                return null;
            }

            return JsonSerializer.Deserialize<GameSettings>(File.ReadAllText(file));
        }
    }

    public class Game
    {
        [JsonPropertyName("yaw")]
        public double Yaw { get; set; }

        [JsonPropertyName("fovAffected")]
        public bool AffectedByFOV { get; set; }
    }


    [SupportedOSPlatform("windows")]
    public static class Extensions
    {
        public static void PopulateTrees(this TreeView treeView, GameSettings settings)
        {
            foreach (var engine in settings.Engines.OrderBy(x => x.Key))
            {
                var node = new TreeNode(engine.Key);

                foreach (var game in engine.Value.OrderBy(x => x.Key))
                    node.Nodes.Add(new TreeNode(game.Key));

                treeView.Nodes.Add(node);
            }
        }
    }
}
