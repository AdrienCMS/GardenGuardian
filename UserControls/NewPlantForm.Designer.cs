namespace PAC_APP_V2.UserControls
{
    partial class NewPlantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPlantForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PICBOX_Plant = new System.Windows.Forms.PictureBox();
            this.LAB_PlantName = new System.Windows.Forms.Label();
            this.LAB_Schedule = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBOX_PlantName = new System.Windows.Forms.TextBox();
            this.DTP_LastWatering = new System.Windows.Forms.DateTimePicker();
            this.NUMDD_Schedule = new System.Windows.Forms.NumericUpDown();
            this.CBOX_WeekMonth = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BUT_Browse = new System.Windows.Forms.Button();
            this.BUT_Insert = new System.Windows.Forms.Button();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.plantsTableAdapter = new PAC_APP_V2.gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Plant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMDD_Schedule)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Controls.Add(this.PICBOX_Plant, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LAB_PlantName, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.LAB_Schedule, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBOX_PlantName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.DTP_LastWatering, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.NUMDD_Schedule, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.CBOX_WeekMonth, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 406);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PICBOX_Plant
            // 
            this.PICBOX_Plant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PICBOX_Plant.Location = new System.Drawing.Point(13, 13);
            this.PICBOX_Plant.Name = "PICBOX_Plant";
            this.tableLayoutPanel1.SetRowSpan(this.PICBOX_Plant, 5);
            this.PICBOX_Plant.Size = new System.Drawing.Size(346, 390);
            this.PICBOX_Plant.TabIndex = 0;
            this.PICBOX_Plant.TabStop = false;
            // 
            // LAB_PlantName
            // 
            this.LAB_PlantName.AutoSize = true;
            this.LAB_PlantName.Dock = System.Windows.Forms.DockStyle.Right;
            this.LAB_PlantName.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_PlantName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LAB_PlantName.Location = new System.Drawing.Point(461, 10);
            this.LAB_PlantName.Name = "LAB_PlantName";
            this.LAB_PlantName.Size = new System.Drawing.Size(162, 79);
            this.LAB_PlantName.TabIndex = 1;
            this.LAB_PlantName.Text = "Plante (type,nom ...) :";
            // 
            // LAB_Schedule
            // 
            this.LAB_Schedule.AutoSize = true;
            this.LAB_Schedule.Dock = System.Windows.Forms.DockStyle.Right;
            this.LAB_Schedule.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Schedule.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LAB_Schedule.Location = new System.Drawing.Point(447, 89);
            this.LAB_Schedule.Name = "LAB_Schedule";
            this.LAB_Schedule.Size = new System.Drawing.Size(176, 79);
            this.LAB_Schedule.TabIndex = 2;
            this.LAB_Schedule.Text = "Fréquence d\'arrosage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(484, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 79);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dernier arrosage :";
            // 
            // TBOX_PlantName
            // 
            this.TBOX_PlantName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBOX_PlantName.Location = new System.Drawing.Point(629, 13);
            this.TBOX_PlantName.Name = "TBOX_PlantName";
            this.TBOX_PlantName.Size = new System.Drawing.Size(126, 20);
            this.TBOX_PlantName.TabIndex = 5;
            // 
            // DTP_LastWatering
            // 
            this.DTP_LastWatering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP_LastWatering.Location = new System.Drawing.Point(629, 171);
            this.DTP_LastWatering.Name = "DTP_LastWatering";
            this.DTP_LastWatering.Size = new System.Drawing.Size(126, 20);
            this.DTP_LastWatering.TabIndex = 4;
            // 
            // NUMDD_Schedule
            // 
            this.NUMDD_Schedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.NUMDD_Schedule.Location = new System.Drawing.Point(629, 92);
            this.NUMDD_Schedule.Name = "NUMDD_Schedule";
            this.NUMDD_Schedule.Size = new System.Drawing.Size(126, 20);
            this.NUMDD_Schedule.TabIndex = 6;
            // 
            // CBOX_WeekMonth
            // 
            this.CBOX_WeekMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBOX_WeekMonth.FormattingEnabled = true;
            this.CBOX_WeekMonth.Items.AddRange(new object[] {
            "Semaine",
            "Mois"});
            this.CBOX_WeekMonth.Location = new System.Drawing.Point(761, 92);
            this.CBOX_WeekMonth.Name = "CBOX_WeekMonth";
            this.CBOX_WeekMonth.Size = new System.Drawing.Size(126, 21);
            this.CBOX_WeekMonth.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.BUT_Browse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BUT_Insert, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 406);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(904, 44);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(904, 44);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(904, 44);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // BUT_Browse
            // 
            this.BUT_Browse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(84)))), ((int)(((byte)(46)))));
            this.BUT_Browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_Browse.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Browse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_Browse.Location = new System.Drawing.Point(13, 3);
            this.BUT_Browse.Name = "BUT_Browse";
            this.BUT_Browse.Size = new System.Drawing.Size(170, 28);
            this.BUT_Browse.TabIndex = 0;
            this.BUT_Browse.Text = "Parcourir";
            this.BUT_Browse.UseVisualStyleBackColor = false;
            this.BUT_Browse.Click += new System.EventHandler(this.BUT_Browse_Click);
            // 
            // BUT_Insert
            // 
            this.BUT_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(84)))), ((int)(((byte)(46)))));
            this.BUT_Insert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUT_Insert.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Insert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BUT_Insert.Location = new System.Drawing.Point(717, 3);
            this.BUT_Insert.Name = "BUT_Insert";
            this.BUT_Insert.Size = new System.Drawing.Size(170, 28);
            this.BUT_Insert.TabIndex = 1;
            this.BUT_Insert.Text = "Enregistrer";
            this.BUT_Insert.UseVisualStyleBackColor = false;
            this.BUT_Insert.Click += new System.EventHandler(this.BUT_Insert_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // NewPlantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPlantForm";
            this.Text = "Ajouter une plante";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Plant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUMDD_Schedule)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PICBOX_Plant;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BUT_Browse;
        private System.Windows.Forms.Button BUT_Insert;
        private System.Windows.Forms.Label LAB_PlantName;
        private System.Windows.Forms.Label LAB_Schedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBOX_PlantName;
        private System.Windows.Forms.DateTimePicker DTP_LastWatering;
        private System.Windows.Forms.NumericUpDown NUMDD_Schedule;
        private System.Windows.Forms.ComboBox CBOX_WeekMonth;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter plantsTableAdapter;
    }
}