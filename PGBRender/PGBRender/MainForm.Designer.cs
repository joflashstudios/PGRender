namespace PGBRender
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudFrameEnd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRender = new System.Windows.Forms.Button();
            this.nudCoreCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBlendFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFrameStart = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoreCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameStart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudFrameStart);
            this.panel1.Controls.Add(this.nudFrameEnd);
            this.panel1.Controls.Add(this.nudCoreCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 151);
            this.panel1.TabIndex = 8;
            // 
            // nudFrameEnd
            // 
            this.nudFrameEnd.Location = new System.Drawing.Point(168, 38);
            this.nudFrameEnd.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudFrameEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameEnd.Name = "nudFrameEnd";
            this.nudFrameEnd.Size = new System.Drawing.Size(74, 22);
            this.nudFrameEnd.TabIndex = 15;
            this.nudFrameEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(-25, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "__________________________________________________";
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(168, 113);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 27);
            this.btnRender.TabIndex = 15;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // nudCoreCount
            // 
            this.nudCoreCount.Location = new System.Drawing.Point(89, 66);
            this.nudCoreCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoreCount.Name = "nudCoreCount";
            this.nudCoreCount.Size = new System.Drawing.Size(153, 22);
            this.nudCoreCount.TabIndex = 14;
            this.nudCoreCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Core Count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Frame Set:";
            // 
            // txtBlendFile
            // 
            this.txtBlendFile.Location = new System.Drawing.Point(89, 11);
            this.txtBlendFile.Name = "txtBlendFile";
            this.txtBlendFile.Size = new System.Drawing.Size(153, 22);
            this.txtBlendFile.TabIndex = 10;
            this.txtBlendFile.DoubleClick += new System.EventHandler(this.txtBlendFile_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project File:";
            // 
            // nudFrameStart
            // 
            this.nudFrameStart.Location = new System.Drawing.Point(89, 38);
            this.nudFrameStart.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudFrameStart.Name = "nudFrameStart";
            this.nudFrameStart.Size = new System.Drawing.Size(73, 22);
            this.nudFrameStart.TabIndex = 16;
            this.nudFrameStart.ValueChanged += new System.EventHandler(this.nudFrameStart_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBlendFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PhilosoGamer Renderer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoreCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.NumericUpDown nudCoreCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBlendFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFrameEnd;
        private System.Windows.Forms.NumericUpDown nudFrameStart;
    }
}

