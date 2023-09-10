namespace GardenGuardian.UserControls
{
    partial class SettingsUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.machineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gardenguardian_databaseDataSet = new GardenGuardian.gardenguardian_databaseDataSet();
            this.machineTableAdapter = new GardenGuardian.gardenguardian_databaseDataSetTableAdapters.machineTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DGV_Machines = new System.Windows.Forms.DataGridView();
            this.machineipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinelocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinewatersupplyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinegroundhumidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHART_WaterSupplies = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gardenguardian_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Machines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_WaterSupplies)).BeginInit();
            this.SuspendLayout();
            // 
            // machineBindingSource
            // 
            this.machineBindingSource.DataMember = "machine";
            this.machineBindingSource.DataSource = this.gardenguardian_databaseDataSet;
            // 
            // gardenguardian_databaseDataSet
            // 
            this.gardenguardian_databaseDataSet.DataSetName = "gardenguardian_databaseDataSet";
            this.gardenguardian_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machineTableAdapter
            // 
            this.machineTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DGV_Machines);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CHART_WaterSupplies);
            this.splitContainer1.Size = new System.Drawing.Size(900, 500);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // DGV_Machines
            // 
            this.DGV_Machines.AutoGenerateColumns = false;
            this.DGV_Machines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGV_Machines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Machines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.DGV_Machines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Machines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Machines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Machines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineipDataGridViewTextBoxColumn,
            this.machinelocationDataGridViewTextBoxColumn,
            this.machinewatersupplyDataGridViewTextBoxColumn,
            this.machinegroundhumidityDataGridViewTextBoxColumn});
            this.DGV_Machines.DataSource = this.machineBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Machines.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Machines.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGV_Machines.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DGV_Machines.Location = new System.Drawing.Point(0, 0);
            this.DGV_Machines.Margin = new System.Windows.Forms.Padding(0);
            this.DGV_Machines.Name = "DGV_Machines";
            this.DGV_Machines.Size = new System.Drawing.Size(444, 500);
            this.DGV_Machines.TabIndex = 1;
            this.DGV_Machines.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Machines_CellEndEdit);
            this.DGV_Machines.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Machines_RowValidated);
            // 
            // machineipDataGridViewTextBoxColumn
            // 
            this.machineipDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.machineipDataGridViewTextBoxColumn.DataPropertyName = "machine_ip";
            this.machineipDataGridViewTextBoxColumn.Frozen = true;
            this.machineipDataGridViewTextBoxColumn.HeaderText = "IP";
            this.machineipDataGridViewTextBoxColumn.Name = "machineipDataGridViewTextBoxColumn";
            this.machineipDataGridViewTextBoxColumn.Width = 55;
            // 
            // machinelocationDataGridViewTextBoxColumn
            // 
            this.machinelocationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machinelocationDataGridViewTextBoxColumn.DataPropertyName = "machine_location";
            this.machinelocationDataGridViewTextBoxColumn.HeaderText = "Emplacement";
            this.machinelocationDataGridViewTextBoxColumn.Name = "machinelocationDataGridViewTextBoxColumn";
            // 
            // machinewatersupplyDataGridViewTextBoxColumn
            // 
            this.machinewatersupplyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machinewatersupplyDataGridViewTextBoxColumn.DataPropertyName = "machine_water_supply";
            this.machinewatersupplyDataGridViewTextBoxColumn.HeaderText = "Réserves d\'eau";
            this.machinewatersupplyDataGridViewTextBoxColumn.Name = "machinewatersupplyDataGridViewTextBoxColumn";
            // 
            // machinegroundhumidityDataGridViewTextBoxColumn
            // 
            this.machinegroundhumidityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.machinegroundhumidityDataGridViewTextBoxColumn.DataPropertyName = "machine_ground_humidity";
            this.machinegroundhumidityDataGridViewTextBoxColumn.HeaderText = "Humidité du sol";
            this.machinegroundhumidityDataGridViewTextBoxColumn.Name = "machinegroundhumidityDataGridViewTextBoxColumn";
            // 
            // CHART_WaterSupplies
            // 
            this.CHART_WaterSupplies.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(83)))));
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.TitleForeColor = System.Drawing.SystemColors.ButtonFace;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(83)))));
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Title = "Réserves d\'eau (L)";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.TitleForeColor = System.Drawing.SystemColors.ButtonFace;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            chartArea1.Name = "ChartArea1";
            this.CHART_WaterSupplies.ChartAreas.Add(chartArea1);
            this.CHART_WaterSupplies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CHART_WaterSupplies.Location = new System.Drawing.Point(0, 0);
            this.CHART_WaterSupplies.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.CHART_WaterSupplies.Name = "CHART_WaterSupplies";
            this.CHART_WaterSupplies.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series1.LabelForeColor = System.Drawing.SystemColors.ButtonFace;
            series1.Name = "Réserve d\'eau";
            this.CHART_WaterSupplies.Series.Add(series1);
            this.CHART_WaterSupplies.Size = new System.Drawing.Size(596, 500);
            this.CHART_WaterSupplies.TabIndex = 2;
            this.CHART_WaterSupplies.Text = "chart1";
            this.CHART_WaterSupplies.DoubleClick += new System.EventHandler(this.CHART_WaterSupplies_DoubleClick);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.SettingsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gardenguardian_databaseDataSet)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Machines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHART_WaterSupplies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource machineBindingSource;
        private gardenguardian_databaseDataSet gardenguardian_databaseDataSet;
        private gardenguardian_databaseDataSetTableAdapters.machineTableAdapter machineTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DGV_Machines;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinelocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinewatersupplyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machinegroundhumidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart CHART_WaterSupplies;
    }
}
