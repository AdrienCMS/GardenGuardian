namespace PAC_APP_V2.UserControls
{
    partial class PlantCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantCard));
            this.LAYPAN_Main = new System.Windows.Forms.TableLayoutPanel();
            this.TitleLAB_PlantName = new System.Windows.Forms.Label();
            this.TitleLAB_LastWatering = new System.Windows.Forms.Label();
            this.TitleLAB_WateringSchedule = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PICBOX_Plant = new System.Windows.Forms.PictureBox();
            this.BUT_Delete = new System.Windows.Forms.Button();
            this.BUT_edit = new System.Windows.Forms.Button();
            this.LAB_PlantName = new System.Windows.Forms.Label();
            this.LAB_LastWatering = new System.Windows.Forms.Label();
            this.LAB_Schedule = new System.Windows.Forms.Label();
            this.LAYPAN_Main.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Plant)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYPAN_Main
            // 
            this.LAYPAN_Main.ColumnCount = 7;
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.LAYPAN_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LAYPAN_Main.Controls.Add(this.TitleLAB_PlantName, 2, 1);
            this.LAYPAN_Main.Controls.Add(this.TitleLAB_LastWatering, 2, 2);
            this.LAYPAN_Main.Controls.Add(this.TitleLAB_WateringSchedule, 2, 3);
            this.LAYPAN_Main.Controls.Add(this.MainPanel, 0, 0);
            this.LAYPAN_Main.Controls.Add(this.BUT_Delete, 4, 4);
            this.LAYPAN_Main.Controls.Add(this.BUT_edit, 5, 4);
            this.LAYPAN_Main.Controls.Add(this.LAB_PlantName, 3, 1);
            this.LAYPAN_Main.Controls.Add(this.LAB_LastWatering, 3, 2);
            this.LAYPAN_Main.Controls.Add(this.LAB_Schedule, 3, 3);
            this.LAYPAN_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYPAN_Main.Location = new System.Drawing.Point(0, 0);
            this.LAYPAN_Main.Name = "LAYPAN_Main";
            this.LAYPAN_Main.RowCount = 6;
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LAYPAN_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.LAYPAN_Main.Size = new System.Drawing.Size(748, 207);
            this.LAYPAN_Main.TabIndex = 0;
            // 
            // TitleLAB_PlantName
            // 
            this.TitleLAB_PlantName.AutoSize = true;
            this.TitleLAB_PlantName.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleLAB_PlantName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLAB_PlantName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLAB_PlantName.Location = new System.Drawing.Point(331, 10);
            this.TitleLAB_PlantName.Name = "TitleLAB_PlantName";
            this.TitleLAB_PlantName.Size = new System.Drawing.Size(66, 46);
            this.TitleLAB_PlantName.TabIndex = 1;
            this.TitleLAB_PlantName.Text = "Plante : ";
            // 
            // TitleLAB_LastWatering
            // 
            this.TitleLAB_LastWatering.AutoSize = true;
            this.TitleLAB_LastWatering.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleLAB_LastWatering.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLAB_LastWatering.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLAB_LastWatering.Location = new System.Drawing.Point(258, 56);
            this.TitleLAB_LastWatering.Name = "TitleLAB_LastWatering";
            this.TitleLAB_LastWatering.Size = new System.Drawing.Size(139, 46);
            this.TitleLAB_LastWatering.TabIndex = 2;
            this.TitleLAB_LastWatering.Text = "Dernier arrosage :";
            // 
            // TitleLAB_WateringSchedule
            // 
            this.TitleLAB_WateringSchedule.AutoSize = true;
            this.TitleLAB_WateringSchedule.Dock = System.Windows.Forms.DockStyle.Right;
            this.TitleLAB_WateringSchedule.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLAB_WateringSchedule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLAB_WateringSchedule.Location = new System.Drawing.Point(221, 102);
            this.TitleLAB_WateringSchedule.Name = "TitleLAB_WateringSchedule";
            this.TitleLAB_WateringSchedule.Size = new System.Drawing.Size(176, 46);
            this.TitleLAB_WateringSchedule.TabIndex = 3;
            this.TitleLAB_WateringSchedule.Text = "Fréquence d\'arrosage :";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(84)))), ((int)(((byte)(46)))));
            this.LAYPAN_Main.SetColumnSpan(this.MainPanel, 2);
            this.MainPanel.Controls.Add(this.PICBOX_Plant);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(3, 3);
            this.MainPanel.MaximumSize = new System.Drawing.Size(200, 200);
            this.MainPanel.MinimumSize = new System.Drawing.Size(200, 200);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(15);
            this.LAYPAN_Main.SetRowSpan(this.MainPanel, 6);
            this.MainPanel.Size = new System.Drawing.Size(200, 200);
            this.MainPanel.TabIndex = 4;
            // 
            // PICBOX_Plant
            // 
            this.PICBOX_Plant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PICBOX_Plant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PICBOX_Plant.Image = ((System.Drawing.Image)(resources.GetObject("PICBOX_Plant.Image")));
            this.PICBOX_Plant.Location = new System.Drawing.Point(15, 15);
            this.PICBOX_Plant.Name = "PICBOX_Plant";
            this.PICBOX_Plant.Size = new System.Drawing.Size(170, 170);
            this.PICBOX_Plant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICBOX_Plant.TabIndex = 0;
            this.PICBOX_Plant.TabStop = false;
            this.PICBOX_Plant.Click += new System.EventHandler(this.PICBOX_Plant_Click);
            // 
            // BUT_Delete
            // 
            this.BUT_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_Delete.ForeColor = System.Drawing.Color.Maroon;
            this.BUT_Delete.Location = new System.Drawing.Point(601, 151);
            this.BUT_Delete.Name = "BUT_Delete";
            this.BUT_Delete.Size = new System.Drawing.Size(64, 29);
            this.BUT_Delete.TabIndex = 1;
            this.BUT_Delete.Text = "Supprimer";
            this.BUT_Delete.UseVisualStyleBackColor = true;
            this.BUT_Delete.Click += new System.EventHandler(this.BUT_Delete_Click);
            // 
            // BUT_edit
            // 
            this.BUT_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(84)))), ((int)(((byte)(46)))));
            this.BUT_edit.Location = new System.Drawing.Point(671, 151);
            this.BUT_edit.Name = "BUT_edit";
            this.BUT_edit.Size = new System.Drawing.Size(64, 29);
            this.BUT_edit.TabIndex = 0;
            this.BUT_edit.Text = "Modifier";
            this.BUT_edit.UseVisualStyleBackColor = true;
            // 
            // LAB_PlantName
            // 
            this.LAB_PlantName.AutoSize = true;
            this.LAYPAN_Main.SetColumnSpan(this.LAB_PlantName, 3);
            this.LAB_PlantName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_PlantName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LAB_PlantName.Location = new System.Drawing.Point(403, 10);
            this.LAB_PlantName.Name = "LAB_PlantName";
            this.LAB_PlantName.Size = new System.Drawing.Size(55, 21);
            this.LAB_PlantName.TabIndex = 5;
            this.LAB_PlantName.Text = "label1";
            // 
            // LAB_LastWatering
            // 
            this.LAB_LastWatering.AutoSize = true;
            this.LAYPAN_Main.SetColumnSpan(this.LAB_LastWatering, 3);
            this.LAB_LastWatering.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_LastWatering.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LAB_LastWatering.Location = new System.Drawing.Point(403, 56);
            this.LAB_LastWatering.Name = "LAB_LastWatering";
            this.LAB_LastWatering.Size = new System.Drawing.Size(55, 21);
            this.LAB_LastWatering.TabIndex = 6;
            this.LAB_LastWatering.Text = "label2";
            // 
            // LAB_Schedule
            // 
            this.LAB_Schedule.AutoSize = true;
            this.LAYPAN_Main.SetColumnSpan(this.LAB_Schedule, 3);
            this.LAB_Schedule.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Schedule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LAB_Schedule.Location = new System.Drawing.Point(403, 102);
            this.LAB_Schedule.Name = "LAB_Schedule";
            this.LAB_Schedule.Size = new System.Drawing.Size(55, 21);
            this.LAB_Schedule.TabIndex = 7;
            this.LAB_Schedule.Text = "label3";
            // 
            // PlantCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LAYPAN_Main);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(748, 207);
            this.MinimumSize = new System.Drawing.Size(748, 207);
            this.Name = "PlantCard";
            this.Size = new System.Drawing.Size(748, 207);
            this.LAYPAN_Main.ResumeLayout(false);
            this.LAYPAN_Main.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Plant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LAYPAN_Main;
        private System.Windows.Forms.Label TitleLAB_PlantName;
        private System.Windows.Forms.Label TitleLAB_LastWatering;
        private System.Windows.Forms.Label TitleLAB_WateringSchedule;
        private System.Windows.Forms.Button BUT_edit;
        private System.Windows.Forms.Button BUT_Delete;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox PICBOX_Plant;
        private System.Windows.Forms.Label LAB_PlantName;
        private System.Windows.Forms.Label LAB_LastWatering;
        private System.Windows.Forms.Label LAB_Schedule;
    }
}
