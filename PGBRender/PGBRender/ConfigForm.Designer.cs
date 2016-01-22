namespace PGBRender
{
    partial class ConfigForm
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
            this.txtBlender = new System.Windows.Forms.TextBox();
            this.lblProjectFile = new System.Windows.Forms.Label();
            this.txtFFMPEG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBlender
            // 
            this.txtBlender.Location = new System.Drawing.Point(110, 12);
            this.txtBlender.Name = "txtBlender";
            this.txtBlender.Size = new System.Drawing.Size(162, 20);
            this.txtBlender.TabIndex = 12;
            this.txtBlender.TextChanged += new System.EventHandler(this.txtBlender_TextChanged);
            // 
            // lblProjectFile
            // 
            this.lblProjectFile.AutoSize = true;
            this.lblProjectFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectFile.Location = new System.Drawing.Point(15, 15);
            this.lblProjectFile.Name = "lblProjectFile";
            this.lblProjectFile.Size = new System.Drawing.Size(93, 13);
            this.lblProjectFile.TabIndex = 11;
            this.lblProjectFile.Text = "Path To Blender:";
            // 
            // txtFFMPEG
            // 
            this.txtFFMPEG.Location = new System.Drawing.Point(110, 38);
            this.txtFFMPEG.Name = "txtFFMPEG";
            this.txtFFMPEG.Size = new System.Drawing.Size(162, 20);
            this.txtFFMPEG.TabIndex = 14;
            this.txtFFMPEG.TextChanged += new System.EventHandler(this.txtFFMPEG_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Path To FFMPEG:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(110, 64);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(162, 20);
            this.txtOutput.TabIndex = 16;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Output Path:";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(110, 90);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(162, 20);
            this.txtTemp.TabIndex = 18;
            this.txtTemp.TextChanged += new System.EventHandler(this.txtTemp_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Temp Path:";
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(197, 119);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 27);
            this.btnRender.TabIndex = 19;
            this.btnRender.Text = "Save";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.ControlBox = false;
            this.Controls.Add(this.btnRender);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFFMPEG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlender);
            this.Controls.Add(this.lblProjectFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfigForm";
            this.Text = "Configure PhilosoGamer Renderer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBlender;
        private System.Windows.Forms.Label lblProjectFile;
        private System.Windows.Forms.TextBox txtFFMPEG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRender;
    }
}