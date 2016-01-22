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
            this.panelSetup = new System.Windows.Forms.Panel();
            this.lnkConfig = new System.Windows.Forms.LinkLabel();
            this.txtBlendFile = new System.Windows.Forms.TextBox();
            this.lblProjectFile = new System.Windows.Forms.Label();
            this.lblCoreCount = new System.Windows.Forms.Label();
            this.nudFPS = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudFrameStart = new System.Windows.Forms.NumericUpDown();
            this.btnRender = new System.Windows.Forms.Button();
            this.nudFrameEnd = new System.Windows.Forms.NumericUpDown();
            this.nudCoreCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRunning = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblRunETA = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblRunRealtime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRunFPS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRunCores = new System.Windows.Forms.Label();
            this.lblRunFrames = new System.Windows.Forms.Label();
            this.lblRunProject = new System.Windows.Forms.Label();
            this.panelSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoreCount)).BeginInit();
            this.panelRunning.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSetup
            // 
            this.panelSetup.Controls.Add(this.lnkConfig);
            this.panelSetup.Controls.Add(this.txtBlendFile);
            this.panelSetup.Controls.Add(this.lblProjectFile);
            this.panelSetup.Controls.Add(this.lblCoreCount);
            this.panelSetup.Controls.Add(this.nudFPS);
            this.panelSetup.Controls.Add(this.label5);
            this.panelSetup.Controls.Add(this.label4);
            this.panelSetup.Controls.Add(this.nudFrameStart);
            this.panelSetup.Controls.Add(this.btnRender);
            this.panelSetup.Controls.Add(this.nudFrameEnd);
            this.panelSetup.Controls.Add(this.nudCoreCount);
            this.panelSetup.Controls.Add(this.label2);
            this.panelSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetup.Location = new System.Drawing.Point(0, 0);
            this.panelSetup.Name = "panelSetup";
            this.panelSetup.Size = new System.Drawing.Size(257, 175);
            this.panelSetup.TabIndex = 8;
            // 
            // lnkConfig
            // 
            this.lnkConfig.AutoSize = true;
            this.lnkConfig.Location = new System.Drawing.Point(4, 137);
            this.lnkConfig.Name = "lnkConfig";
            this.lnkConfig.Size = new System.Drawing.Size(42, 13);
            this.lnkConfig.TabIndex = 17;
            this.lnkConfig.TabStop = true;
            this.lnkConfig.Text = "Config";
            this.lnkConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfig_LinkClicked);
            // 
            // txtBlendFile
            // 
            this.txtBlendFile.Location = new System.Drawing.Point(89, 10);
            this.txtBlendFile.Name = "txtBlendFile";
            this.txtBlendFile.Size = new System.Drawing.Size(153, 22);
            this.txtBlendFile.TabIndex = 10;
            this.txtBlendFile.TextChanged += new System.EventHandler(this.txtBlendFile_TextChanged);
            this.txtBlendFile.DoubleClick += new System.EventHandler(this.txtBlendFile_DoubleClick);
            // 
            // lblProjectFile
            // 
            this.lblProjectFile.AutoSize = true;
            this.lblProjectFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectFile.Location = new System.Drawing.Point(16, 13);
            this.lblProjectFile.Name = "lblProjectFile";
            this.lblProjectFile.Size = new System.Drawing.Size(67, 13);
            this.lblProjectFile.TabIndex = 9;
            this.lblProjectFile.Text = "Project File:";
            // 
            // lblCoreCount
            // 
            this.lblCoreCount.AutoSize = true;
            this.lblCoreCount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoreCount.Location = new System.Drawing.Point(14, 68);
            this.lblCoreCount.Name = "lblCoreCount";
            this.lblCoreCount.Size = new System.Drawing.Size(69, 13);
            this.lblCoreCount.TabIndex = 13;
            this.lblCoreCount.Text = "Core Count:";
            // 
            // nudFPS
            // 
            this.nudFPS.Location = new System.Drawing.Point(89, 93);
            this.nudFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFPS.Name = "nudFPS";
            this.nudFPS.Size = new System.Drawing.Size(153, 22);
            this.nudFPS.TabIndex = 16;
            this.nudFPS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "FPS:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(-32, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "__________________________________________________";
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
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(167, 136);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(75, 27);
            this.btnRender.TabIndex = 15;
            this.btnRender.Text = "Render";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
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
            // panelRunning
            // 
            this.panelRunning.Controls.Add(this.btnPause);
            this.panelRunning.Controls.Add(this.btnCancel);
            this.panelRunning.Controls.Add(this.label15);
            this.panelRunning.Controls.Add(this.progressBar);
            this.panelRunning.Controls.Add(this.lblRunETA);
            this.panelRunning.Controls.Add(this.label13);
            this.panelRunning.Controls.Add(this.lblRunRealtime);
            this.panelRunning.Controls.Add(this.label11);
            this.panelRunning.Controls.Add(this.lblRunFPS);
            this.panelRunning.Controls.Add(this.label9);
            this.panelRunning.Controls.Add(this.lblRunCores);
            this.panelRunning.Controls.Add(this.lblRunFrames);
            this.panelRunning.Controls.Add(this.lblRunProject);
            this.panelRunning.Location = new System.Drawing.Point(12, 8);
            this.panelRunning.Name = "panelRunning";
            this.panelRunning.Size = new System.Drawing.Size(203, 163);
            this.panelRunning.TabIndex = 17;
            this.panelRunning.Visible = false;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(89, 146);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 26);
            this.btnPause.TabIndex = 22;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(170, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label15.Location = new System.Drawing.Point(-15, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(307, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "__________________________________________________";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(10, 105);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(235, 23);
            this.progressBar.TabIndex = 19;
            // 
            // lblRunETA
            // 
            this.lblRunETA.AutoSize = true;
            this.lblRunETA.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunETA.Location = new System.Drawing.Point(35, 82);
            this.lblRunETA.Name = "lblRunETA";
            this.lblRunETA.Size = new System.Drawing.Size(140, 13);
            this.lblRunETA.TabIndex = 18;
            this.lblRunETA.Text = "NN:NN:NN - 12:00 PM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 17;
            this.label13.Text = "ETA:";
            // 
            // lblRunRealtime
            // 
            this.lblRunRealtime.AutoSize = true;
            this.lblRunRealtime.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunRealtime.Location = new System.Drawing.Point(150, 61);
            this.lblRunRealtime.Name = "lblRunRealtime";
            this.lblRunRealtime.Size = new System.Drawing.Size(28, 13);
            this.lblRunRealtime.TabIndex = 16;
            this.lblRunRealtime.Text = "NN%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(80, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "% Realtime:";
            // 
            // lblRunFPS
            // 
            this.lblRunFPS.AutoSize = true;
            this.lblRunFPS.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunFPS.Location = new System.Drawing.Point(35, 61);
            this.lblRunFPS.Name = "lblRunFPS";
            this.lblRunFPS.Size = new System.Drawing.Size(35, 13);
            this.lblRunFPS.TabIndex = 14;
            this.lblRunFPS.Text = "NN.N";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "FPS:";
            // 
            // lblRunCores
            // 
            this.lblRunCores.AutoSize = true;
            this.lblRunCores.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunCores.Location = new System.Drawing.Point(10, 37);
            this.lblRunCores.Name = "lblRunCores";
            this.lblRunCores.Size = new System.Drawing.Size(56, 13);
            this.lblRunCores.TabIndex = 12;
            this.lblRunCores.Text = "N Cores";
            // 
            // lblRunFrames
            // 
            this.lblRunFrames.AutoSize = true;
            this.lblRunFrames.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunFrames.Location = new System.Drawing.Point(10, 23);
            this.lblRunFrames.Name = "lblRunFrames";
            this.lblRunFrames.Size = new System.Drawing.Size(77, 13);
            this.lblRunFrames.TabIndex = 11;
            this.lblRunFrames.Text = "Frames x-y";
            // 
            // lblRunProject
            // 
            this.lblRunProject.AutoSize = true;
            this.lblRunProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunProject.Location = new System.Drawing.Point(7, 7);
            this.lblRunProject.Name = "lblRunProject";
            this.lblRunProject.Size = new System.Drawing.Size(166, 15);
            this.lblRunProject.TabIndex = 10;
            this.lblRunProject.Text = "Rendering Project File Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 175);
            this.Controls.Add(this.panelSetup);
            this.Controls.Add(this.panelRunning);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PhilosoGamer Renderer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panelSetup.ResumeLayout(false);
            this.panelSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoreCount)).EndInit();
            this.panelRunning.ResumeLayout(false);
            this.panelRunning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSetup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.NumericUpDown nudCoreCount;
        private System.Windows.Forms.Label lblCoreCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBlendFile;
        private System.Windows.Forms.Label lblProjectFile;
        private System.Windows.Forms.NumericUpDown nudFrameEnd;
        private System.Windows.Forms.NumericUpDown nudFrameStart;
        private System.Windows.Forms.NumericUpDown nudFPS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRunning;
        private System.Windows.Forms.Label lblRunProject;
        private System.Windows.Forms.Label lblRunCores;
        private System.Windows.Forms.Label lblRunFrames;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblRunETA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRunRealtime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRunFPS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel lnkConfig;
    }
}

