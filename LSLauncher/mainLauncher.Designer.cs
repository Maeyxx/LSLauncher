namespace LSLauncher
{
    partial class mainLauncher
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainLauncher));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLaw = new System.Windows.Forms.Button();
            this.notifyIconLSLauncher = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxVersion = new System.Windows.Forms.ToolStripTextBox();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.lblInformationProgressBar = new System.Windows.Forms.Label();
            this.panelProgressBar = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnScreens = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnDiscord = new System.Windows.Forms.Button();
            this.toolTipBtnPlay = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.toolTipNotifyIcon = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.panelProgressBar.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(289, 96);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(220, 215);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.TabStop = false;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseEnter += new System.EventHandler(this.btnPlay_MouseEnter);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_settings_25px;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.Location = new System.Drawing.Point(30, 15);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(155, 29);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "RÉGLAGES";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseEnter += new System.EventHandler(this.btnSettings_MouseEnter);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            // 
            // btnLaw
            // 
            this.btnLaw.BackColor = System.Drawing.Color.Transparent;
            this.btnLaw.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_law_25px;
            this.btnLaw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLaw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaw.FlatAppearance.BorderSize = 0;
            this.btnLaw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLaw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLaw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaw.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaw.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLaw.Location = new System.Drawing.Point(23, 15);
            this.btnLaw.Name = "btnLaw";
            this.btnLaw.Size = new System.Drawing.Size(155, 29);
            this.btnLaw.TabIndex = 6;
            this.btnLaw.Text = "RÉGLEMENT";
            this.btnLaw.UseVisualStyleBackColor = false;
            this.btnLaw.Click += new System.EventHandler(this.btnWebSite_Click);
            this.btnLaw.MouseEnter += new System.EventHandler(this.btnLaw_MouseEnter);
            this.btnLaw.MouseLeave += new System.EventHandler(this.btnLaw_MouseLeave);
            // 
            // notifyIconLSLauncher
            // 
            this.notifyIconLSLauncher.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIconLSLauncher.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconLSLauncher.Icon")));
            this.notifyIconLSLauncher.Text = "LS - Launcher";
            this.notifyIconLSLauncher.DoubleClick += new System.EventHandler(this.notifyIconLSLauncher_DoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripTextBoxVersion});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(181, 129);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Ouvrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Quitter";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripTextBoxVersion
            // 
            this.toolStripTextBoxVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxVersion.Name = "toolStripTextBoxVersion";
            this.toolStripTextBoxVersion.Size = new System.Drawing.Size(100, 23);
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(17, 21);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(698, 10);
            this.progressBarMain.TabIndex = 8;
            // 
            // lblInformationProgressBar
            // 
            this.lblInformationProgressBar.AutoSize = true;
            this.lblInformationProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.lblInformationProgressBar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformationProgressBar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInformationProgressBar.Location = new System.Drawing.Point(275, 3);
            this.lblInformationProgressBar.Name = "lblInformationProgressBar";
            this.lblInformationProgressBar.Size = new System.Drawing.Size(174, 15);
            this.lblInformationProgressBar.TabIndex = 9;
            this.lblInformationProgressBar.Text = "chargement des applications...";
            // 
            // panelProgressBar
            // 
            this.panelProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.panelProgressBar.Controls.Add(this.lblInformationProgressBar);
            this.panelProgressBar.Controls.Add(this.progressBarMain);
            this.panelProgressBar.Location = new System.Drawing.Point(32, 317);
            this.panelProgressBar.Name = "panelProgressBar";
            this.panelProgressBar.Size = new System.Drawing.Size(730, 56);
            this.panelProgressBar.TabIndex = 10;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.Controls.Add(this.btnScreens);
            this.panelLeft.Controls.Add(this.btnSettings);
            this.panelLeft.Location = new System.Drawing.Point(32, 107);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(203, 127);
            this.panelLeft.TabIndex = 11;
            // 
            // btnScreens
            // 
            this.btnScreens.BackColor = System.Drawing.Color.Transparent;
            this.btnScreens.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_screenshot_25px_1;
            this.btnScreens.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScreens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScreens.FlatAppearance.BorderSize = 0;
            this.btnScreens.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScreens.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnScreens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreens.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreens.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScreens.Location = new System.Drawing.Point(30, 82);
            this.btnScreens.Name = "btnScreens";
            this.btnScreens.Size = new System.Drawing.Size(155, 29);
            this.btnScreens.TabIndex = 6;
            this.btnScreens.Text = "SCREENSHOTS";
            this.btnScreens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScreens.UseVisualStyleBackColor = false;
            this.btnScreens.Click += new System.EventHandler(this.btnScreens_Click);
            this.btnScreens.MouseEnter += new System.EventHandler(this.btnScreens_MouseEnter);
            this.btnScreens.MouseLeave += new System.EventHandler(this.btnScreens_MouseLeave);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.btnDiscord);
            this.panelRight.Controls.Add(this.btnLaw);
            this.panelRight.Location = new System.Drawing.Point(558, 107);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(204, 127);
            this.panelRight.TabIndex = 12;
            // 
            // btnDiscord
            // 
            this.btnDiscord.BackColor = System.Drawing.Color.Transparent;
            this.btnDiscord.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_discord_25px;
            this.btnDiscord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscord.FlatAppearance.BorderSize = 0;
            this.btnDiscord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDiscord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscord.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscord.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDiscord.Location = new System.Drawing.Point(23, 82);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.Size = new System.Drawing.Size(155, 29);
            this.btnDiscord.TabIndex = 7;
            this.btnDiscord.Text = "DISCORD";
            this.btnDiscord.UseVisualStyleBackColor = false;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            this.btnDiscord.MouseEnter += new System.EventHandler(this.btnDiscord_MouseEnter);
            this.btnDiscord.MouseLeave += new System.EventHandler(this.btnDiscord_MouseLeave);
            // 
            // toolTipBtnPlay
            // 
            this.toolTipBtnPlay.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipBtnPlay_Popup);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.lblMain);
            this.panelMain.Location = new System.Drawing.Point(32, 28);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(730, 62);
            this.panelMain.TabIndex = 13;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMain.Location = new System.Drawing.Point(183, 13);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(263, 33);
            this.lblMain.TabIndex = 9;
            this.lblMain.Text = "LS - Launcher Version : ";
            // 
            // mainLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LSLauncher.Properties.Resources._4k_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 406);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelProgressBar);
            this.Controls.Add(this.btnPlay);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainLauncher";
            this.Text = "LS - Launcher";
            this.Load += new System.EventHandler(this.mainLauncher_Load);
            this.Resize += new System.EventHandler(this.mainLauncher_Resize);
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.contextMenuStripNotifyIcon.PerformLayout();
            this.panelProgressBar.ResumeLayout(false);
            this.panelProgressBar.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLaw;
        private System.Windows.Forms.NotifyIcon notifyIconLSLauncher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxVersion;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Label lblInformationProgressBar;
        private System.Windows.Forms.Panel panelProgressBar;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ToolTip toolTipBtnPlay;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnScreens;
        private System.Windows.Forms.Button btnDiscord;
        private System.Windows.Forms.ToolTip toolTipNotifyIcon;
    }
}

