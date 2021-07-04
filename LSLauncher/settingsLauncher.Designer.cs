namespace LSLauncher
{
    partial class settingsLauncher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsLauncher));
            this.btnClearLogs = new System.Windows.Forms.Button();
            this.btnClearCacheComplete = new System.Windows.Forms.Button();
            this.btnClearCacheLights = new System.Windows.Forms.Button();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnChangePath = new System.Windows.Forms.Button();
            this.btnOpenLogs = new System.Windows.Forms.Button();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearLogs
            // 
            this.btnClearLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnClearLogs.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_log_30px;
            this.btnClearLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLogs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearLogs.FlatAppearance.BorderSize = 0;
            this.btnClearLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLogs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLogs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearLogs.Location = new System.Drawing.Point(35, 184);
            this.btnClearLogs.Name = "btnClearLogs";
            this.btnClearLogs.Size = new System.Drawing.Size(206, 31);
            this.btnClearLogs.TabIndex = 0;
            this.btnClearLogs.Text = "VIDER LOGS";
            this.btnClearLogs.UseVisualStyleBackColor = false;
            this.btnClearLogs.Click += new System.EventHandler(this.btnClearLogs_Click);
            this.btnClearLogs.MouseEnter += new System.EventHandler(this.btnClearLogs_MouseEnter);
            this.btnClearLogs.MouseLeave += new System.EventHandler(this.btnClearLogs_MouseLeave);
            // 
            // btnClearCacheComplete
            // 
            this.btnClearCacheComplete.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCacheComplete.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_broom_30px;
            this.btnClearCacheComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearCacheComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCacheComplete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearCacheComplete.FlatAppearance.BorderSize = 0;
            this.btnClearCacheComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearCacheComplete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearCacheComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCacheComplete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCacheComplete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearCacheComplete.Location = new System.Drawing.Point(35, 131);
            this.btnClearCacheComplete.Name = "btnClearCacheComplete";
            this.btnClearCacheComplete.Size = new System.Drawing.Size(206, 30);
            this.btnClearCacheComplete.TabIndex = 1;
            this.btnClearCacheComplete.Text = "VIDER CACHE COMPLET";
            this.btnClearCacheComplete.UseVisualStyleBackColor = false;
            this.btnClearCacheComplete.Click += new System.EventHandler(this.btnClearCache_Click);
            this.btnClearCacheComplete.MouseEnter += new System.EventHandler(this.btnClearCacheComplete_MouseEnter);
            this.btnClearCacheComplete.MouseLeave += new System.EventHandler(this.btnClearCacheComplete_MouseLeave);
            // 
            // btnClearCacheLights
            // 
            this.btnClearCacheLights.BackColor = System.Drawing.Color.Transparent;
            this.btnClearCacheLights.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_broom_30px;
            this.btnClearCacheLights.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearCacheLights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearCacheLights.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearCacheLights.FlatAppearance.BorderSize = 0;
            this.btnClearCacheLights.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClearCacheLights.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClearCacheLights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCacheLights.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCacheLights.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearCacheLights.Location = new System.Drawing.Point(35, 74);
            this.btnClearCacheLights.Name = "btnClearCacheLights";
            this.btnClearCacheLights.Size = new System.Drawing.Size(206, 31);
            this.btnClearCacheLights.TabIndex = 0;
            this.btnClearCacheLights.Text = "VIDER CACHE LIGHTS";
            this.btnClearCacheLights.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClearCacheLights.UseVisualStyleBackColor = false;
            this.btnClearCacheLights.Click += new System.EventHandler(this.btnClearCacheLights_Click);
            this.btnClearCacheLights.MouseEnter += new System.EventHandler(this.btnClearCacheLights_MouseEnter);
            this.btnClearCacheLights.MouseLeave += new System.EventHandler(this.btnClearCacheLights_MouseLeave);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.Transparent;
            this.panelSettings.Controls.Add(this.btnChangePath);
            this.panelSettings.Controls.Add(this.btnOpenLogs);
            this.panelSettings.Controls.Add(this.btnClearCacheLights);
            this.panelSettings.Controls.Add(this.btnClearCacheComplete);
            this.panelSettings.Controls.Add(this.btnClearLogs);
            this.panelSettings.Location = new System.Drawing.Point(45, 36);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(266, 292);
            this.panelSettings.TabIndex = 2;
            // 
            // btnChangePath
            // 
            this.btnChangePath.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePath.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_folder_30px_1;
            this.btnChangePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChangePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePath.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangePath.FlatAppearance.BorderSize = 0;
            this.btnChangePath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChangePath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePath.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePath.ForeColor = System.Drawing.SystemColors.Control;
            this.btnChangePath.Location = new System.Drawing.Point(35, 23);
            this.btnChangePath.Name = "btnChangePath";
            this.btnChangePath.Size = new System.Drawing.Size(206, 31);
            this.btnChangePath.TabIndex = 3;
            this.btnChangePath.Text = "GÉRER RÉGLAGES";
            this.btnChangePath.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnChangePath.UseVisualStyleBackColor = false;
            this.btnChangePath.Click += new System.EventHandler(this.btnChangePath_Click);
            this.btnChangePath.MouseEnter += new System.EventHandler(this.btnChangePath_MouseEnter);
            this.btnChangePath.MouseLeave += new System.EventHandler(this.btnChangePath_MouseLeave);
            // 
            // btnOpenLogs
            // 
            this.btnOpenLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenLogs.BackgroundImage = global::LSLauncher.Properties.Resources.icons8_file_download_30px;
            this.btnOpenLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOpenLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenLogs.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenLogs.FlatAppearance.BorderSize = 0;
            this.btnOpenLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOpenLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOpenLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLogs.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenLogs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenLogs.Location = new System.Drawing.Point(35, 235);
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.Size = new System.Drawing.Size(206, 31);
            this.btnOpenLogs.TabIndex = 2;
            this.btnOpenLogs.Text = "OUVRIR LOGS";
            this.btnOpenLogs.UseVisualStyleBackColor = false;
            this.btnOpenLogs.Click += new System.EventHandler(this.btnOpenLogs_Click);
            this.btnOpenLogs.MouseEnter += new System.EventHandler(this.btnOpenLogs_MouseEnter);
            this.btnOpenLogs.MouseLeave += new System.EventHandler(this.btnOpenLogs_MouseLeave);
            // 
            // settingsLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 364);
            this.Controls.Add(this.panelSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingsLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Réglages";
            this.Load += new System.EventHandler(this.settingsLauncher_Load);
            this.panelSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearLogs;
        private System.Windows.Forms.Button btnClearCacheComplete;
        private System.Windows.Forms.Button btnClearCacheLights;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Button btnOpenLogs;
        private System.Windows.Forms.Button btnChangePath;
    }
}