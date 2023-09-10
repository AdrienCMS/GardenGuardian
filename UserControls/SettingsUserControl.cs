using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenGuardian.UserControls
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        private void SettingsUserControl_Load(object sender, EventArgs e)
        {
            loadData();
        }

        /// <summary>
        /// Récupère les informations contenues dans la base de données et les affiche
        /// </summary>
        private void loadData()
        {
            DataTable machines = MainForm.machineTableAdapter.GetData();
            this.machineTableAdapter.Fill(this.gardenguardian_databaseDataSet.machine);

            foreach(DataRow machine in machines.Rows)
            {
                CHART_WaterSupplies.Series[0].Points.AddXY((int)machine["machine_id"], (double)machine["machine_water_supply"]);
            }
            CHART_WaterSupplies.Invalidate();

        }

        private void DGV_Machines_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.machineTableAdapter.Update(this.gardenguardian_databaseDataSet.machine);
        }

        private void DGV_Machines_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            this.machineTableAdapter.Update(this.gardenguardian_databaseDataSet.machine);
            
        }
        private void CHART_WaterSupplies_DoubleClick(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
