namespace PAC_APP_V2.UserControls
{
    partial class PlantUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantUserControl));
            this.TS_Main = new System.Windows.Forms.ToolStrip();
            this.TSBUT_Add = new System.Windows.Forms.ToolStripButton();
            this.FLOWPAN_Plants = new System.Windows.Forms.FlowLayoutPanel();
            this.plantsTableAdapter = new PAC_APP_V2.gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter();
            this.TS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // TS_Main
            // 
            this.TS_Main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TS_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBUT_Add});
            this.TS_Main.Location = new System.Drawing.Point(0, 0);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.Size = new System.Drawing.Size(55, 500);
            this.TS_Main.TabIndex = 0;
            this.TS_Main.Text = "toolStrip1";
            // 
            // TSBUT_Add
            // 
            this.TSBUT_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TSBUT_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSBUT_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TSBUT_Add.Image = ((System.Drawing.Image)(resources.GetObject("TSBUT_Add.Image")));
            this.TSBUT_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUT_Add.Name = "TSBUT_Add";
            this.TSBUT_Add.Size = new System.Drawing.Size(52, 37);
            this.TSBUT_Add.Text = "Ajouter";
            this.TSBUT_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBUT_Add.Click += new System.EventHandler(this.TSBUT_Add_Click);
            // 
            // FLOWPAN_Plants
            // 
            this.FLOWPAN_Plants.AutoScroll = true;
            this.FLOWPAN_Plants.AutoSize = true;
            this.FLOWPAN_Plants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLOWPAN_Plants.Location = new System.Drawing.Point(55, 0);
            this.FLOWPAN_Plants.Name = "FLOWPAN_Plants";
            this.FLOWPAN_Plants.Size = new System.Drawing.Size(845, 500);
            this.FLOWPAN_Plants.TabIndex = 1;
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // PlantUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.FLOWPAN_Plants);
            this.Controls.Add(this.TS_Main);
            this.Name = "PlantUserControl";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.PlantUserControl_Load);
            this.TS_Main.ResumeLayout(false);
            this.TS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_Main;
        private System.Windows.Forms.ToolStripButton TSBUT_Add;
        private System.Windows.Forms.FlowLayoutPanel FLOWPAN_Plants;
        private gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter plantsTableAdapter;
    }
}
