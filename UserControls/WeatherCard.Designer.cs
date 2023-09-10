
namespace GardenGuardian.UserControls
{
    partial class WeatherCard
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
            this.LAYPAN_Infos = new System.Windows.Forms.TableLayoutPanel();
            this.LAB_Condition = new System.Windows.Forms.Label();
            this.PICBOX_Current = new System.Windows.Forms.PictureBox();
            this.LAB_RainChance = new System.Windows.Forms.Label();
            this.LAB_SnowChance = new System.Windows.Forms.Label();
            this.LAB_WindForce = new System.Windows.Forms.Label();
            this.LAB_WindDir = new System.Windows.Forms.Label();
            this.LAB_AverageTemp = new System.Windows.Forms.Label();
            this.LAB_Humidity = new System.Windows.Forms.Label();
            this.LAB_MaxTemp = new System.Windows.Forms.Label();
            this.LAB_MinTemp = new System.Windows.Forms.Label();
            this.LAB_Time = new System.Windows.Forms.Label();
            this.LAYPAN_Infos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Current)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYPAN_Infos
            // 
            this.LAYPAN_Infos.BackColor = System.Drawing.Color.Transparent;
            this.LAYPAN_Infos.ColumnCount = 4;
            this.LAYPAN_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.LAYPAN_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYPAN_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYPAN_Infos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.LAYPAN_Infos.Controls.Add(this.LAB_Condition, 1, 3);
            this.LAYPAN_Infos.Controls.Add(this.PICBOX_Current, 1, 1);
            this.LAYPAN_Infos.Controls.Add(this.LAB_RainChance, 1, 8);
            this.LAYPAN_Infos.Controls.Add(this.LAB_SnowChance, 2, 8);
            this.LAYPAN_Infos.Controls.Add(this.LAB_WindForce, 1, 7);
            this.LAYPAN_Infos.Controls.Add(this.LAB_WindDir, 2, 7);
            this.LAYPAN_Infos.Controls.Add(this.LAB_AverageTemp, 1, 6);
            this.LAYPAN_Infos.Controls.Add(this.LAB_Humidity, 2, 6);
            this.LAYPAN_Infos.Controls.Add(this.LAB_MaxTemp, 1, 5);
            this.LAYPAN_Infos.Controls.Add(this.LAB_MinTemp, 2, 5);
            this.LAYPAN_Infos.Controls.Add(this.LAB_Time, 1, 4);
            this.LAYPAN_Infos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYPAN_Infos.Location = new System.Drawing.Point(0, 0);
            this.LAYPAN_Infos.Name = "LAYPAN_Infos";
            this.LAYPAN_Infos.RowCount = 10;
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0004F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0001F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999102F));
            this.LAYPAN_Infos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.LAYPAN_Infos.Size = new System.Drawing.Size(378, 670);
            this.LAYPAN_Infos.TabIndex = 0;
            // 
            // LAB_Condition
            // 
            this.LAB_Condition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_Condition.AutoSize = true;
            this.LAYPAN_Infos.SetColumnSpan(this.LAB_Condition, 2);
            this.LAB_Condition.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Condition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_Condition.Location = new System.Drawing.Point(7, 271);
            this.LAB_Condition.Name = "LAB_Condition";
            this.LAB_Condition.Size = new System.Drawing.Size(362, 65);
            this.LAB_Condition.TabIndex = 11;
            this.LAB_Condition.Text = "CONDITION";
            this.LAB_Condition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PICBOX_Current
            // 
            this.PICBOX_Current.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LAYPAN_Infos.SetColumnSpan(this.PICBOX_Current, 2);
            this.PICBOX_Current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PICBOX_Current.Location = new System.Drawing.Point(7, 7);
            this.PICBOX_Current.Name = "PICBOX_Current";
            this.PICBOX_Current.Size = new System.Drawing.Size(362, 257);
            this.PICBOX_Current.TabIndex = 0;
            this.PICBOX_Current.TabStop = false;
            // 
            // LAB_RainChance
            // 
            this.LAB_RainChance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_RainChance.AutoSize = true;
            this.LAB_RainChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_RainChance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_RainChance.Location = new System.Drawing.Point(7, 596);
            this.LAB_RainChance.Name = "LAB_RainChance";
            this.LAB_RainChance.Size = new System.Drawing.Size(178, 65);
            this.LAB_RainChance.TabIndex = 10;
            this.LAB_RainChance.Text = "RAIN ?";
            this.LAB_RainChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_SnowChance
            // 
            this.LAB_SnowChance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_SnowChance.AutoSize = true;
            this.LAB_SnowChance.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_SnowChance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_SnowChance.Location = new System.Drawing.Point(191, 596);
            this.LAB_SnowChance.Name = "LAB_SnowChance";
            this.LAB_SnowChance.Size = new System.Drawing.Size(178, 65);
            this.LAB_SnowChance.TabIndex = 9;
            this.LAB_SnowChance.Text = "SNOW ?";
            this.LAB_SnowChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_WindForce
            // 
            this.LAB_WindForce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_WindForce.AutoSize = true;
            this.LAB_WindForce.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_WindForce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_WindForce.Location = new System.Drawing.Point(7, 531);
            this.LAB_WindForce.Name = "LAB_WindForce";
            this.LAB_WindForce.Size = new System.Drawing.Size(178, 65);
            this.LAB_WindForce.TabIndex = 5;
            this.LAB_WindForce.Text = "WIND FORCE";
            this.LAB_WindForce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_WindDir
            // 
            this.LAB_WindDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_WindDir.AutoSize = true;
            this.LAB_WindDir.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_WindDir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_WindDir.Location = new System.Drawing.Point(191, 531);
            this.LAB_WindDir.Name = "LAB_WindDir";
            this.LAB_WindDir.Size = new System.Drawing.Size(178, 65);
            this.LAB_WindDir.TabIndex = 6;
            this.LAB_WindDir.Text = "WIND DIR";
            this.LAB_WindDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_AverageTemp
            // 
            this.LAB_AverageTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_AverageTemp.AutoSize = true;
            this.LAB_AverageTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_AverageTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_AverageTemp.Location = new System.Drawing.Point(7, 466);
            this.LAB_AverageTemp.Name = "LAB_AverageTemp";
            this.LAB_AverageTemp.Size = new System.Drawing.Size(178, 65);
            this.LAB_AverageTemp.TabIndex = 7;
            this.LAB_AverageTemp.Text = "AVG TEMP";
            this.LAB_AverageTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_Humidity
            // 
            this.LAB_Humidity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_Humidity.AutoSize = true;
            this.LAB_Humidity.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Humidity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_Humidity.Location = new System.Drawing.Point(191, 466);
            this.LAB_Humidity.Name = "LAB_Humidity";
            this.LAB_Humidity.Size = new System.Drawing.Size(178, 65);
            this.LAB_Humidity.TabIndex = 8;
            this.LAB_Humidity.Text = "HUMIDITY";
            this.LAB_Humidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_MaxTemp
            // 
            this.LAB_MaxTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_MaxTemp.AutoSize = true;
            this.LAB_MaxTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_MaxTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_MaxTemp.Location = new System.Drawing.Point(7, 401);
            this.LAB_MaxTemp.Name = "LAB_MaxTemp";
            this.LAB_MaxTemp.Size = new System.Drawing.Size(178, 65);
            this.LAB_MaxTemp.TabIndex = 3;
            this.LAB_MaxTemp.Text = "MAX TEMP";
            this.LAB_MaxTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_MinTemp
            // 
            this.LAB_MinTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_MinTemp.AutoSize = true;
            this.LAB_MinTemp.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_MinTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_MinTemp.Location = new System.Drawing.Point(191, 401);
            this.LAB_MinTemp.Name = "LAB_MinTemp";
            this.LAB_MinTemp.Size = new System.Drawing.Size(178, 65);
            this.LAB_MinTemp.TabIndex = 4;
            this.LAB_MinTemp.Text = "MIN TEMP";
            this.LAB_MinTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAB_Time
            // 
            this.LAB_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LAB_Time.AutoSize = true;
            this.LAYPAN_Infos.SetColumnSpan(this.LAB_Time, 2);
            this.LAB_Time.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LAB_Time.Location = new System.Drawing.Point(7, 336);
            this.LAB_Time.Name = "LAB_Time";
            this.LAB_Time.Size = new System.Drawing.Size(362, 65);
            this.LAB_Time.TabIndex = 2;
            this.LAB_Time.Text = "TIME";
            this.LAB_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::GardenGuardian.Properties.Resources.blueSkyGradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LAYPAN_Infos);
            this.DoubleBuffered = true;
            this.Name = "WeatherCard";
            this.Size = new System.Drawing.Size(378, 670);
            this.LAYPAN_Infos.ResumeLayout(false);
            this.LAYPAN_Infos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Current)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LAYPAN_Infos;
        private System.Windows.Forms.PictureBox PICBOX_Current;
        private System.Windows.Forms.Label LAB_MaxTemp;
        private System.Windows.Forms.Label LAB_MinTemp;
        private System.Windows.Forms.Label LAB_WindForce;
        private System.Windows.Forms.Label LAB_WindDir;
        private System.Windows.Forms.Label LAB_AverageTemp;
        private System.Windows.Forms.Label LAB_Humidity;
        private System.Windows.Forms.Label LAB_Time;
        private System.Windows.Forms.Label LAB_RainChance;
        private System.Windows.Forms.Label LAB_SnowChance;
        private System.Windows.Forms.Label LAB_Condition;
    }
}
