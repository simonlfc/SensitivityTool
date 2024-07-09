namespace SensitivityTool
{
    partial class SensitivityToolMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            OriginFOV = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            OriginSensitivity = new System.Windows.Forms.NumericUpDown();
            OriginGames = new System.Windows.Forms.TreeView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            label6 = new System.Windows.Forms.Label();
            TargetFOV = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            TargetSensitivity = new System.Windows.Forms.TextBox();
            TargetGames = new System.Windows.Forms.TreeView();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OriginFOV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OriginSensitivity).BeginInit();
            groupBox2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TargetFOV).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(546, 330);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flowLayoutPanel1);
            groupBox1.Controls.Add(OriginGames);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Location = new System.Drawing.Point(4, 3);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(265, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Origin";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(OriginFOV);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(OriginSensitivity);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(4, 209);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            flowLayoutPanel1.Size = new System.Drawing.Size(257, 112);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 8);
            label3.Name = "label3";
            label3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            label3.Size = new System.Drawing.Size(77, 19);
            label3.TabIndex = 4;
            label3.Text = "Field of View:";
            // 
            // OriginFOV
            // 
            OriginFOV.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            OriginFOV.Location = new System.Drawing.Point(7, 30);
            OriginFOV.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            OriginFOV.Minimum = new decimal(new int[] { 65, 0, 0, 0 });
            OriginFOV.Name = "OriginFOV";
            OriginFOV.Size = new System.Drawing.Size(247, 23);
            OriginFOV.TabIndex = 5;
            OriginFOV.Value = new decimal(new int[] { 65, 0, 0, 0 });
            OriginFOV.ValueChanged += OriginFOV_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 56);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            label1.Size = new System.Drawing.Size(63, 19);
            label1.TabIndex = 0;
            label1.Text = "Sensitivity:";
            // 
            // OriginSensitivity
            // 
            OriginSensitivity.DecimalPlaces = 3;
            OriginSensitivity.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            OriginSensitivity.Location = new System.Drawing.Point(7, 78);
            OriginSensitivity.Name = "OriginSensitivity";
            OriginSensitivity.Size = new System.Drawing.Size(247, 23);
            OriginSensitivity.TabIndex = 1;
            OriginSensitivity.Value = new decimal(new int[] { 20, 0, 0, 65536 });
            OriginSensitivity.ValueChanged += OriginSensitivity_ValueChanged;
            // 
            // OriginGames
            // 
            OriginGames.Dock = System.Windows.Forms.DockStyle.Top;
            OriginGames.HideSelection = false;
            OriginGames.Location = new System.Drawing.Point(4, 19);
            OriginGames.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            OriginGames.Name = "OriginGames";
            OriginGames.Size = new System.Drawing.Size(257, 190);
            OriginGames.TabIndex = 0;
            OriginGames.AfterSelect += OriginGames_AfterSelect;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel2);
            groupBox2.Controls.Add(TargetGames);
            groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox2.Location = new System.Drawing.Point(277, 3);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(265, 324);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Target";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label6);
            flowLayoutPanel2.Controls.Add(TargetFOV);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(TargetSensitivity);
            flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel2.Location = new System.Drawing.Point(4, 209);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            flowLayoutPanel2.Size = new System.Drawing.Size(257, 112);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 8);
            label6.Name = "label6";
            label6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            label6.Size = new System.Drawing.Size(77, 19);
            label6.TabIndex = 4;
            label6.Text = "Field of View:";
            // 
            // TargetFOV
            // 
            TargetFOV.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            TargetFOV.Location = new System.Drawing.Point(7, 30);
            TargetFOV.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            TargetFOV.Minimum = new decimal(new int[] { 65, 0, 0, 0 });
            TargetFOV.Name = "TargetFOV";
            TargetFOV.Size = new System.Drawing.Size(246, 23);
            TargetFOV.TabIndex = 5;
            TargetFOV.Value = new decimal(new int[] { 65, 0, 0, 0 });
            TargetFOV.ValueChanged += TargetFOV_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 56);
            label4.Name = "label4";
            label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            label4.Size = new System.Drawing.Size(63, 19);
            label4.TabIndex = 6;
            label4.Text = "Sensitivity:";
            // 
            // TargetSensitivity
            // 
            TargetSensitivity.Location = new System.Drawing.Point(7, 78);
            TargetSensitivity.Name = "TargetSensitivity";
            TargetSensitivity.ReadOnly = true;
            TargetSensitivity.Size = new System.Drawing.Size(246, 23);
            TargetSensitivity.TabIndex = 7;
            // 
            // TargetGames
            // 
            TargetGames.Dock = System.Windows.Forms.DockStyle.Top;
            TargetGames.HideSelection = false;
            TargetGames.Location = new System.Drawing.Point(4, 19);
            TargetGames.Name = "TargetGames";
            TargetGames.Size = new System.Drawing.Size(257, 190);
            TargetGames.TabIndex = 0;
            TargetGames.AfterSelect += TargetGames_AfterSelect;
            // 
            // SensitivityToolMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(546, 330);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SensitivityToolMain";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            Text = "SensitivityToolMain";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OriginFOV).EndInit();
            ((System.ComponentModel.ISupportInitialize)OriginSensitivity).EndInit();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TargetFOV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TreeView OriginGames;
        private System.Windows.Forms.TreeView TargetGames;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown OriginSensitivity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown OriginFOV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TargetFOV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TargetSensitivity;
    }
}

