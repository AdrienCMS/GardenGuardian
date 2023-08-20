namespace GardenGuardian
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuBUT_Settings = new GardenGuardian.Controls.MenuButton();
            this.menuBUT_Forecast = new GardenGuardian.Controls.MenuButton();
            this.menuBUT_Plants = new GardenGuardian.Controls.MenuButton();
            this.menuBUT_Home = new GardenGuardian.Controls.MenuButton();
            this.menuBUT_exit = new GardenGuardian.Controls.MenuButton();
            this.PAN_Spacing_2 = new System.Windows.Forms.Panel();
            this.PICBOX_Logo = new System.Windows.Forms.PictureBox();
            this.PAN_Spacing_1 = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.TS_Main = new System.Windows.Forms.ToolStrip();
            this.TSBUT_Licence = new System.Windows.Forms.ToolStripButton();
            this.airportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Logo)).BeginInit();
            this.TS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.AutoScroll = true;
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.menuPanel.Controls.Add(this.menuBUT_Settings);
            this.menuPanel.Controls.Add(this.menuBUT_Forecast);
            this.menuPanel.Controls.Add(this.menuBUT_Plants);
            this.menuPanel.Controls.Add(this.menuBUT_Home);
            this.menuPanel.Controls.Add(this.menuBUT_exit);
            this.menuPanel.Controls.Add(this.PAN_Spacing_2);
            this.menuPanel.Controls.Add(this.PICBOX_Logo);
            this.menuPanel.Controls.Add(this.PAN_Spacing_1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(298, 790);
            this.menuPanel.TabIndex = 0;
            // 
            // menuBUT_Settings
            // 
            this.menuBUT_Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBUT_Settings.FlatAppearance.BorderSize = 0;
            this.menuBUT_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBUT_Settings.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.menuBUT_Settings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuBUT_Settings.Label = "Configuration";
            this.menuBUT_Settings.lineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.menuBUT_Settings.Location = new System.Drawing.Point(0, 538);
            this.menuBUT_Settings.Logo = ((System.Drawing.Image)(resources.GetObject("menuBUT_Settings.Logo")));
            this.menuBUT_Settings.Name = "menuBUT_Settings";
            this.menuBUT_Settings.Size = new System.Drawing.Size(298, 81);
            this.menuBUT_Settings.TabIndex = 17;
            this.menuBUT_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuBUT_Settings.UseVisualStyleBackColor = true;
            this.menuBUT_Settings.Click += new System.EventHandler(this.menuBUT_Settings_Click);
            // 
            // menuBUT_Forecast
            // 
            this.menuBUT_Forecast.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBUT_Forecast.FlatAppearance.BorderSize = 0;
            this.menuBUT_Forecast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBUT_Forecast.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.menuBUT_Forecast.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuBUT_Forecast.Label = "Prévisions";
            this.menuBUT_Forecast.lineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.menuBUT_Forecast.Location = new System.Drawing.Point(0, 457);
            this.menuBUT_Forecast.Logo = ((System.Drawing.Image)(resources.GetObject("menuBUT_Forecast.Logo")));
            this.menuBUT_Forecast.Name = "menuBUT_Forecast";
            this.menuBUT_Forecast.Size = new System.Drawing.Size(298, 81);
            this.menuBUT_Forecast.TabIndex = 16;
            this.menuBUT_Forecast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuBUT_Forecast.UseVisualStyleBackColor = true;
            this.menuBUT_Forecast.Click += new System.EventHandler(this.menuBUT_Forecast_Click);
            // 
            // menuBUT_Plants
            // 
            this.menuBUT_Plants.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBUT_Plants.FlatAppearance.BorderSize = 0;
            this.menuBUT_Plants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBUT_Plants.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.menuBUT_Plants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuBUT_Plants.Label = "Plantes";
            this.menuBUT_Plants.lineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(84)))), ((int)(((byte)(46)))));
            this.menuBUT_Plants.Location = new System.Drawing.Point(0, 376);
            this.menuBUT_Plants.Logo = ((System.Drawing.Image)(resources.GetObject("menuBUT_Plants.Logo")));
            this.menuBUT_Plants.Name = "menuBUT_Plants";
            this.menuBUT_Plants.Size = new System.Drawing.Size(298, 81);
            this.menuBUT_Plants.TabIndex = 14;
            this.menuBUT_Plants.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuBUT_Plants.UseVisualStyleBackColor = true;
            this.menuBUT_Plants.Click += new System.EventHandler(this.menuBUT_Plants_Click);
            // 
            // menuBUT_Home
            // 
            this.menuBUT_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBUT_Home.FlatAppearance.BorderSize = 0;
            this.menuBUT_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBUT_Home.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.menuBUT_Home.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuBUT_Home.Label = "Accueil";
            this.menuBUT_Home.lineColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(84)))), ((int)(((byte)(46)))));
            this.menuBUT_Home.Location = new System.Drawing.Point(0, 295);
            this.menuBUT_Home.Logo = ((System.Drawing.Image)(resources.GetObject("menuBUT_Home.Logo")));
            this.menuBUT_Home.Name = "menuBUT_Home";
            this.menuBUT_Home.Size = new System.Drawing.Size(298, 81);
            this.menuBUT_Home.TabIndex = 13;
            this.menuBUT_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuBUT_Home.UseVisualStyleBackColor = true;
            this.menuBUT_Home.Click += new System.EventHandler(this.menuBUT_home_Click);
            // 
            // menuBUT_exit
            // 
            this.menuBUT_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuBUT_exit.FlatAppearance.BorderSize = 0;
            this.menuBUT_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBUT_exit.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.menuBUT_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.menuBUT_exit.Label = "Sortie";
            this.menuBUT_exit.lineColor = System.Drawing.Color.Maroon;
            this.menuBUT_exit.Location = new System.Drawing.Point(0, 711);
            this.menuBUT_exit.Logo = ((System.Drawing.Image)(resources.GetObject("menuBUT_exit.Logo")));
            this.menuBUT_exit.Name = "menuBUT_exit";
            this.menuBUT_exit.Size = new System.Drawing.Size(298, 79);
            this.menuBUT_exit.TabIndex = 8;
            this.menuBUT_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menuBUT_exit.UseVisualStyleBackColor = true;
            this.menuBUT_exit.Click += new System.EventHandler(this.menuBUT_exit_Click);
            // 
            // PAN_Spacing_2
            // 
            this.PAN_Spacing_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Spacing_2.Location = new System.Drawing.Point(0, 259);
            this.PAN_Spacing_2.Name = "PAN_Spacing_2";
            this.PAN_Spacing_2.Size = new System.Drawing.Size(298, 36);
            this.PAN_Spacing_2.TabIndex = 12;
            // 
            // PICBOX_Logo
            // 
            this.PICBOX_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PICBOX_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PICBOX_Logo.Image = ((System.Drawing.Image)(resources.GetObject("PICBOX_Logo.Image")));
            this.PICBOX_Logo.Location = new System.Drawing.Point(0, 36);
            this.PICBOX_Logo.Name = "PICBOX_Logo";
            this.PICBOX_Logo.Size = new System.Drawing.Size(298, 223);
            this.PICBOX_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBOX_Logo.TabIndex = 10;
            this.PICBOX_Logo.TabStop = false;
            this.PICBOX_Logo.Click += new System.EventHandler(this.PICBOX_Logo_Click);
            // 
            // PAN_Spacing_1
            // 
            this.PAN_Spacing_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PAN_Spacing_1.Location = new System.Drawing.Point(0, 0);
            this.PAN_Spacing_1.Name = "PAN_Spacing_1";
            this.PAN_Spacing_1.Size = new System.Drawing.Size(298, 36);
            this.PAN_Spacing_1.TabIndex = 11;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImage = global::GardenGuardian.Properties.Resources.plantsBackground;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Location = new System.Drawing.Point(298, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1024, 762);
            this.mainPanel.TabIndex = 1;
            // 
            // TS_Main
            // 
            this.TS_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBUT_Licence});
            this.TS_Main.Location = new System.Drawing.Point(298, 765);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.Size = new System.Drawing.Size(1024, 25);
            this.TS_Main.TabIndex = 0;
            // 
            // TSBUT_Licence
            // 
            this.TSBUT_Licence.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBUT_Licence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBUT_Licence.Image = ((System.Drawing.Image)(resources.GetObject("TSBUT_Licence.Image")));
            this.TSBUT_Licence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUT_Licence.Name = "TSBUT_Licence";
            this.TSBUT_Licence.Size = new System.Drawing.Size(23, 22);
            this.TSBUT_Licence.Text = "toolStripButton1";
            this.TSBUT_Licence.Click += new System.EventHandler(this.toolStripBUT_Licence_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 790);
            this.Controls.Add(this.TS_Main);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1338, 679);
            this.Name = "MainForm";
            this.Text = "Garden Guardian";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Logo)).EndInit();
            this.TS_Main.ResumeLayout(false);
            this.TS_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.airportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private Controls.MenuButton menuBUT_exit;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStrip TS_Main;
        private System.Windows.Forms.ToolStripButton TSBUT_Licence;
        private System.Windows.Forms.Panel PAN_Spacing_1;
        private System.Windows.Forms.Panel PAN_Spacing_2;
        private System.Windows.Forms.BindingSource airportBindingSource;
        private System.Windows.Forms.PictureBox PICBOX_Logo;
        private Controls.MenuButton menuBUT_Home;
        private Controls.MenuButton menuBUT_Plants;
        private Controls.MenuButton menuBUT_Settings;
        private Controls.MenuButton menuBUT_Forecast;
    }
}

