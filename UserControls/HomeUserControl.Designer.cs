
namespace GardenGuardian.UserControls
{
    partial class HomeUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            this.IMG_Panel = new System.Windows.Forms.Panel();
            this.FLOWPAN_Schedule = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // IMG_Panel
            // 
            this.IMG_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IMG_Panel.BackColor = System.Drawing.Color.Transparent;
            this.IMG_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IMG_Panel.BackgroundImage")));
            this.IMG_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IMG_Panel.Location = new System.Drawing.Point(542, 361);
            this.IMG_Panel.Name = "IMG_Panel";
            this.IMG_Panel.Size = new System.Drawing.Size(464, 204);
            this.IMG_Panel.TabIndex = 3;
            // 
            // FLOWPAN_Schedule
            // 
            this.FLOWPAN_Schedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FLOWPAN_Schedule.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FLOWPAN_Schedule.Location = new System.Drawing.Point(0, 0);
            this.FLOWPAN_Schedule.Name = "FLOWPAN_Schedule";
            this.FLOWPAN_Schedule.Size = new System.Drawing.Size(536, 565);
            this.FLOWPAN_Schedule.TabIndex = 4;
            this.FLOWPAN_Schedule.Paint += new System.Windows.Forms.PaintEventHandler(this.FLOWPAN_Schedule_Paint);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.FLOWPAN_Schedule);
            this.Controls.Add(this.IMG_Panel);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1009, 565);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel IMG_Panel;
        private System.Windows.Forms.FlowLayoutPanel FLOWPAN_Schedule;
    }
}
