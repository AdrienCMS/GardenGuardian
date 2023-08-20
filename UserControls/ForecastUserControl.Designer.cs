namespace GardenGuardian.UserControls
{
    partial class ForecastUserControl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.FLOWPAN_Forecast = new System.Windows.Forms.FlowLayoutPanel();
            this.BUT_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FLOWPAN_Forecast
            // 
            this.FLOWPAN_Forecast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLOWPAN_Forecast.Location = new System.Drawing.Point(91, 3);
            this.FLOWPAN_Forecast.Name = "FLOWPAN_Forecast";
            this.FLOWPAN_Forecast.Size = new System.Drawing.Size(809, 497);
            this.FLOWPAN_Forecast.TabIndex = 0;
            // 
            // BUT_Add
            // 
            this.BUT_Add.BackgroundImage = global::GardenGuardian.Properties.Resources.bigAdd;
            this.BUT_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUT_Add.FlatAppearance.BorderSize = 0;
            this.BUT_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BUT_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BUT_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_Add.Location = new System.Drawing.Point(3, 3);
            this.BUT_Add.Name = "BUT_Add";
            this.BUT_Add.Size = new System.Drawing.Size(82, 81);
            this.BUT_Add.TabIndex = 0;
            this.BUT_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // ForecastUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.BUT_Add);
            this.Controls.Add(this.FLOWPAN_Forecast);
            this.DoubleBuffered = true;
            this.Name = "ForecastUserControl";
            this.Size = new System.Drawing.Size(900, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FLOWPAN_Forecast;
        private System.Windows.Forms.Button BUT_Add;
    }
}
