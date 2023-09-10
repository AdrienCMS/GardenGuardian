
namespace GardenGuardian.UserControls
{
    partial class message
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
            this.LAYPAN_Main = new System.Windows.Forms.TableLayoutPanel();
            this.LAB_Plant = new System.Windows.Forms.Label();
            this.LAB_Date = new System.Windows.Forms.Label();
            this.BUT_Delete = new System.Windows.Forms.Button();
            this.LAYPAN_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // LAYPAN_Main
            // 
            this.LAYPAN_Main.ColumnCount = 3;
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LAYPAN_Main.Controls.Add(this.LAB_Plant, 1, 0);
            this.LAYPAN_Main.Controls.Add(this.LAB_Date, 0, 0);
            this.LAYPAN_Main.Controls.Add(this.BUT_Delete, 2, 0);
            this.LAYPAN_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYPAN_Main.Location = new System.Drawing.Point(0, 0);
            this.LAYPAN_Main.Name = "LAYPAN_Main";
            this.LAYPAN_Main.RowCount = 1;
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.LAYPAN_Main.Size = new System.Drawing.Size(504, 44);
            this.LAYPAN_Main.TabIndex = 0;
            // 
            // LAB_Plant
            // 
            this.LAB_Plant.AutoSize = true;
            this.LAB_Plant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_Plant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LAB_Plant.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Plant.Location = new System.Drawing.Point(229, 0);
            this.LAB_Plant.Name = "LAB_Plant";
            this.LAB_Plant.Size = new System.Drawing.Size(220, 44);
            this.LAB_Plant.TabIndex = 1;
            this.LAB_Plant.Text = "label2";
            this.LAB_Plant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_Date
            // 
            this.LAB_Date.AutoSize = true;
            this.LAB_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(23)))));
            this.LAB_Date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAB_Date.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Date.Location = new System.Drawing.Point(3, 0);
            this.LAB_Date.Name = "LAB_Date";
            this.LAB_Date.Size = new System.Drawing.Size(220, 44);
            this.LAB_Date.TabIndex = 0;
            this.LAB_Date.Text = "label1";
            this.LAB_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUT_Delete
            // 
            this.BUT_Delete.BackgroundImage = global::GardenGuardian.Properties.Resources.Wcross_small;
            this.BUT_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BUT_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Delete.FlatAppearance.BorderSize = 0;
            this.BUT_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(93)))));
            this.BUT_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_Delete.Location = new System.Drawing.Point(452, 0);
            this.BUT_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.BUT_Delete.Name = "BUT_Delete";
            this.BUT_Delete.Size = new System.Drawing.Size(52, 44);
            this.BUT_Delete.TabIndex = 2;
            this.BUT_Delete.UseVisualStyleBackColor = true;
            this.BUT_Delete.Click += new System.EventHandler(this.BUT_Delete_Click);
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.LAYPAN_Main);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "message";
            this.Size = new System.Drawing.Size(504, 44);
            this.LAYPAN_Main.ResumeLayout(false);
            this.LAYPAN_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LAYPAN_Main;
        private System.Windows.Forms.Label LAB_Plant;
        private System.Windows.Forms.Label LAB_Date;
        private System.Windows.Forms.Button BUT_Delete;
    }
}
