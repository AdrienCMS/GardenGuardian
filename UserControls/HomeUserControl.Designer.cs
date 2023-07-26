
namespace PAC_APP_V2.UserControls
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
            this.SuspendLayout();
            // 
            // IMG_Panel
            // 
            this.IMG_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IMG_Panel.BackColor = System.Drawing.Color.Transparent;
            this.IMG_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IMG_Panel.BackgroundImage")));
            this.IMG_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IMG_Panel.Location = new System.Drawing.Point(542, 358);
            this.IMG_Panel.Name = "IMG_Panel";
            this.IMG_Panel.Size = new System.Drawing.Size(464, 204);
            this.IMG_Panel.TabIndex = 3;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.IMG_Panel);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1009, 565);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel IMG_Panel;
    }
}
