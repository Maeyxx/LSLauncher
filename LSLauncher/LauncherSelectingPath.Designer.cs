namespace LSLauncher
{
    partial class LauncherSelectingPath
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherSelectingPath));
            this.txtBoxPathDiscord = new System.Windows.Forms.TextBox();
            this.btnPathDiscord = new System.Windows.Forms.Button();
            this.txtBoxPathTeamspeak = new System.Windows.Forms.TextBox();
            this.btnTeamspeak = new System.Windows.Forms.Button();
            this.txtBoxPathFivem = new System.Windows.Forms.TextBox();
            this.btnPathFivem = new System.Windows.Forms.Button();
            this.txtBoxPathScreenshotSteam = new System.Windows.Forms.TextBox();
            this.btnPathScreenshotSteam = new System.Windows.Forms.Button();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.panelMainChangerPath = new System.Windows.Forms.Panel();
            this.pcBoxPathScreenshotSteam = new System.Windows.Forms.PictureBox();
            this.pcBoxPathFivem = new System.Windows.Forms.PictureBox();
            this.pcBoxPathTeamspeak = new System.Windows.Forms.PictureBox();
            this.pcBoxPathDiscord = new System.Windows.Forms.PictureBox();
            this.lblPathScreenshotSteam = new System.Windows.Forms.Label();
            this.lblPathFivem = new System.Windows.Forms.Label();
            this.lblPathTeamspeak = new System.Windows.Forms.Label();
            this.lblPathDiscord = new System.Windows.Forms.Label();
            this.toolTipPathDefault = new System.Windows.Forms.ToolTip(this.components);
            this.panelMainChangerPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathScreenshotSteam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathFivem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathTeamspeak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathDiscord)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxPathDiscord
            // 
            this.txtBoxPathDiscord.Location = new System.Drawing.Point(19, 29);
            this.txtBoxPathDiscord.Name = "txtBoxPathDiscord";
            this.txtBoxPathDiscord.Size = new System.Drawing.Size(373, 20);
            this.txtBoxPathDiscord.TabIndex = 0;
            // 
            // btnPathDiscord
            // 
            this.btnPathDiscord.Location = new System.Drawing.Point(420, 42);
            this.btnPathDiscord.Name = "btnPathDiscord";
            this.btnPathDiscord.Size = new System.Drawing.Size(26, 20);
            this.btnPathDiscord.TabIndex = 1;
            this.btnPathDiscord.Text = "...";
            this.btnPathDiscord.UseVisualStyleBackColor = true;
            this.btnPathDiscord.Click += new System.EventHandler(this.btnPathDiscord_Click);
            // 
            // txtBoxPathTeamspeak
            // 
            this.txtBoxPathTeamspeak.Location = new System.Drawing.Point(19, 74);
            this.txtBoxPathTeamspeak.Name = "txtBoxPathTeamspeak";
            this.txtBoxPathTeamspeak.Size = new System.Drawing.Size(373, 20);
            this.txtBoxPathTeamspeak.TabIndex = 2;
            // 
            // btnTeamspeak
            // 
            this.btnTeamspeak.Location = new System.Drawing.Point(398, 69);
            this.btnTeamspeak.Name = "btnTeamspeak";
            this.btnTeamspeak.Size = new System.Drawing.Size(26, 20);
            this.btnTeamspeak.TabIndex = 3;
            this.btnTeamspeak.Text = "...";
            this.btnTeamspeak.UseVisualStyleBackColor = true;
            this.btnTeamspeak.Click += new System.EventHandler(this.btnTeamspeak_Click);
            // 
            // txtBoxPathFivem
            // 
            this.txtBoxPathFivem.Location = new System.Drawing.Point(19, 120);
            this.txtBoxPathFivem.Name = "txtBoxPathFivem";
            this.txtBoxPathFivem.Size = new System.Drawing.Size(373, 20);
            this.txtBoxPathFivem.TabIndex = 4;
            // 
            // btnPathFivem
            // 
            this.btnPathFivem.Location = new System.Drawing.Point(398, 109);
            this.btnPathFivem.Name = "btnPathFivem";
            this.btnPathFivem.Size = new System.Drawing.Size(26, 20);
            this.btnPathFivem.TabIndex = 5;
            this.btnPathFivem.Text = "...";
            this.btnPathFivem.UseVisualStyleBackColor = true;
            this.btnPathFivem.Click += new System.EventHandler(this.btnPathFivem_Click);
            // 
            // txtBoxPathScreenshotSteam
            // 
            this.txtBoxPathScreenshotSteam.Location = new System.Drawing.Point(19, 164);
            this.txtBoxPathScreenshotSteam.Name = "txtBoxPathScreenshotSteam";
            this.txtBoxPathScreenshotSteam.Size = new System.Drawing.Size(373, 20);
            this.txtBoxPathScreenshotSteam.TabIndex = 6;
            // 
            // btnPathScreenshotSteam
            // 
            this.btnPathScreenshotSteam.Location = new System.Drawing.Point(398, 155);
            this.btnPathScreenshotSteam.Name = "btnPathScreenshotSteam";
            this.btnPathScreenshotSteam.Size = new System.Drawing.Size(26, 20);
            this.btnPathScreenshotSteam.TabIndex = 7;
            this.btnPathScreenshotSteam.Text = "...";
            this.btnPathScreenshotSteam.UseVisualStyleBackColor = true;
            this.btnPathScreenshotSteam.Click += new System.EventHandler(this.btnPathScreenshotSteam_Click);
            // 
            // btnSavePath
            // 
            this.btnSavePath.BackColor = System.Drawing.Color.Transparent;
            this.btnSavePath.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_save_30px_1;
            this.btnSavePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSavePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePath.FlatAppearance.BorderSize = 0;
            this.btnSavePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSavePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSavePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePath.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePath.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSavePath.Location = new System.Drawing.Point(141, 194);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(193, 31);
            this.btnSavePath.TabIndex = 8;
            this.btnSavePath.Text = "Sauvegarder";
            this.btnSavePath.UseVisualStyleBackColor = false;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            this.btnSavePath.MouseEnter += new System.EventHandler(this.btnSavePath_MouseEnter);
            this.btnSavePath.MouseLeave += new System.EventHandler(this.btnSavePath_MouseLeave);
            // 
            // panelMainChangerPath
            // 
            this.panelMainChangerPath.BackColor = System.Drawing.Color.Transparent;
            this.panelMainChangerPath.Controls.Add(this.pcBoxPathScreenshotSteam);
            this.panelMainChangerPath.Controls.Add(this.pcBoxPathFivem);
            this.panelMainChangerPath.Controls.Add(this.pcBoxPathTeamspeak);
            this.panelMainChangerPath.Controls.Add(this.pcBoxPathDiscord);
            this.panelMainChangerPath.Controls.Add(this.lblPathScreenshotSteam);
            this.panelMainChangerPath.Controls.Add(this.lblPathFivem);
            this.panelMainChangerPath.Controls.Add(this.lblPathTeamspeak);
            this.panelMainChangerPath.Controls.Add(this.lblPathDiscord);
            this.panelMainChangerPath.Controls.Add(this.btnSavePath);
            this.panelMainChangerPath.Controls.Add(this.txtBoxPathScreenshotSteam);
            this.panelMainChangerPath.Controls.Add(this.txtBoxPathTeamspeak);
            this.panelMainChangerPath.Controls.Add(this.txtBoxPathDiscord);
            this.panelMainChangerPath.Controls.Add(this.btnTeamspeak);
            this.panelMainChangerPath.Controls.Add(this.btnPathFivem);
            this.panelMainChangerPath.Controls.Add(this.btnPathScreenshotSteam);
            this.panelMainChangerPath.Controls.Add(this.txtBoxPathFivem);
            this.panelMainChangerPath.Location = new System.Drawing.Point(22, 13);
            this.panelMainChangerPath.Name = "panelMainChangerPath";
            this.panelMainChangerPath.Size = new System.Drawing.Size(461, 246);
            this.panelMainChangerPath.TabIndex = 9;
            this.panelMainChangerPath.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainChangerPath_Paint);
            // 
            // pcBoxPathScreenshotSteam
            // 
            this.pcBoxPathScreenshotSteam.BackColor = System.Drawing.Color.Transparent;
            this.pcBoxPathScreenshotSteam.Image = global::LSLauncher.Properties.Resources.icons8_info_20px;
            this.pcBoxPathScreenshotSteam.Location = new System.Drawing.Point(18, 143);
            this.pcBoxPathScreenshotSteam.Name = "pcBoxPathScreenshotSteam";
            this.pcBoxPathScreenshotSteam.Size = new System.Drawing.Size(18, 20);
            this.pcBoxPathScreenshotSteam.TabIndex = 17;
            this.pcBoxPathScreenshotSteam.TabStop = false;
            this.pcBoxPathScreenshotSteam.MouseHover += new System.EventHandler(this.pcBoxPathScreenshotSteam_MouseHover);
            // 
            // pcBoxPathFivem
            // 
            this.pcBoxPathFivem.BackColor = System.Drawing.Color.Transparent;
            this.pcBoxPathFivem.Image = global::LSLauncher.Properties.Resources.icons8_info_20px;
            this.pcBoxPathFivem.Location = new System.Drawing.Point(18, 97);
            this.pcBoxPathFivem.Name = "pcBoxPathFivem";
            this.pcBoxPathFivem.Size = new System.Drawing.Size(18, 20);
            this.pcBoxPathFivem.TabIndex = 16;
            this.pcBoxPathFivem.TabStop = false;
            this.pcBoxPathFivem.MouseHover += new System.EventHandler(this.pcBoxPathFivem_MouseHover);
            // 
            // pcBoxPathTeamspeak
            // 
            this.pcBoxPathTeamspeak.BackColor = System.Drawing.Color.Transparent;
            this.pcBoxPathTeamspeak.Image = global::LSLauncher.Properties.Resources.icons8_info_20px;
            this.pcBoxPathTeamspeak.Location = new System.Drawing.Point(18, 51);
            this.pcBoxPathTeamspeak.Name = "pcBoxPathTeamspeak";
            this.pcBoxPathTeamspeak.Size = new System.Drawing.Size(18, 20);
            this.pcBoxPathTeamspeak.TabIndex = 15;
            this.pcBoxPathTeamspeak.TabStop = false;
            this.pcBoxPathTeamspeak.MouseHover += new System.EventHandler(this.pcBoxPathTeamspeak_MouseHover);
            // 
            // pcBoxPathDiscord
            // 
            this.pcBoxPathDiscord.BackColor = System.Drawing.Color.Transparent;
            this.pcBoxPathDiscord.Image = global::LSLauncher.Properties.Resources.icons8_info_20px;
            this.pcBoxPathDiscord.Location = new System.Drawing.Point(18, 6);
            this.pcBoxPathDiscord.Name = "pcBoxPathDiscord";
            this.pcBoxPathDiscord.Size = new System.Drawing.Size(18, 20);
            this.pcBoxPathDiscord.TabIndex = 14;
            this.pcBoxPathDiscord.TabStop = false;
            this.pcBoxPathDiscord.MouseHover += new System.EventHandler(this.pcBoxPathDiscord_MouseHover);
            // 
            // lblPathScreenshotSteam
            // 
            this.lblPathScreenshotSteam.AutoSize = true;
            this.lblPathScreenshotSteam.BackColor = System.Drawing.Color.Transparent;
            this.lblPathScreenshotSteam.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathScreenshotSteam.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPathScreenshotSteam.Location = new System.Drawing.Point(38, 147);
            this.lblPathScreenshotSteam.Name = "lblPathScreenshotSteam";
            this.lblPathScreenshotSteam.Size = new System.Drawing.Size(140, 15);
            this.lblPathScreenshotSteam.TabIndex = 12;
            this.lblPathScreenshotSteam.Text = "lblPathScreenshotSteam";
            // 
            // lblPathFivem
            // 
            this.lblPathFivem.AutoSize = true;
            this.lblPathFivem.BackColor = System.Drawing.Color.Transparent;
            this.lblPathFivem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathFivem.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPathFivem.Location = new System.Drawing.Point(38, 101);
            this.lblPathFivem.Name = "lblPathFivem";
            this.lblPathFivem.Size = new System.Drawing.Size(79, 15);
            this.lblPathFivem.TabIndex = 11;
            this.lblPathFivem.Text = "lblPathFivem";
            // 
            // lblPathTeamspeak
            // 
            this.lblPathTeamspeak.AutoSize = true;
            this.lblPathTeamspeak.BackColor = System.Drawing.Color.Transparent;
            this.lblPathTeamspeak.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathTeamspeak.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPathTeamspeak.Location = new System.Drawing.Point(38, 55);
            this.lblPathTeamspeak.Name = "lblPathTeamspeak";
            this.lblPathTeamspeak.Size = new System.Drawing.Size(107, 15);
            this.lblPathTeamspeak.TabIndex = 10;
            this.lblPathTeamspeak.Text = "lblPathTeamspeak";
            // 
            // lblPathDiscord
            // 
            this.lblPathDiscord.AutoSize = true;
            this.lblPathDiscord.BackColor = System.Drawing.Color.Transparent;
            this.lblPathDiscord.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathDiscord.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPathDiscord.Location = new System.Drawing.Point(38, 10);
            this.lblPathDiscord.Name = "lblPathDiscord";
            this.lblPathDiscord.Size = new System.Drawing.Size(90, 15);
            this.lblPathDiscord.TabIndex = 9;
            this.lblPathDiscord.Text = "lblPathDiscord";
            // 
            // LauncherSelectingPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = global::LSLauncher.Properties.Resources._4k_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(501, 271);
            this.Controls.Add(this.btnPathDiscord);
            this.Controls.Add(this.panelMainChangerPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherSelectingPath";
            this.Text = "Choisissez vos chemins d\'accès";
            this.Load += new System.EventHandler(this.LauncherSelectingPath_Load);
            this.panelMainChangerPath.ResumeLayout(false);
            this.panelMainChangerPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathScreenshotSteam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathFivem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathTeamspeak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxPathDiscord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPathDiscord;
        private System.Windows.Forms.Button btnPathDiscord;
        private System.Windows.Forms.TextBox txtBoxPathTeamspeak;
        private System.Windows.Forms.Button btnTeamspeak;
        private System.Windows.Forms.TextBox txtBoxPathFivem;
        private System.Windows.Forms.Button btnPathFivem;
        private System.Windows.Forms.TextBox txtBoxPathScreenshotSteam;
        private System.Windows.Forms.Button btnPathScreenshotSteam;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Panel panelMainChangerPath;
        private System.Windows.Forms.ToolTip toolTipPathDefault;
        private System.Windows.Forms.Label lblPathScreenshotSteam;
        private System.Windows.Forms.Label lblPathFivem;
        private System.Windows.Forms.Label lblPathTeamspeak;
        private System.Windows.Forms.Label lblPathDiscord;
        private System.Windows.Forms.PictureBox pcBoxPathDiscord;
        private System.Windows.Forms.PictureBox pcBoxPathScreenshotSteam;
        private System.Windows.Forms.PictureBox pcBoxPathFivem;
        private System.Windows.Forms.PictureBox pcBoxPathTeamspeak;
    }
}