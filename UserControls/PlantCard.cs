using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenGuardian.UserControls
{
    public partial class PlantCard : UserControl
    {
        /// <summary>
        /// Évènement déclenché lorsque l'utilisateur appuie sur le bouton "supprimer"
        /// </summary>
        public EventHandler isDestroyed;
        public EventHandler statsRequested;
        private static readonly gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter plantsTableAdapter = new gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter();
        private static readonly gardenguardian_databaseDataSetTableAdapters.machineTableAdapter machineTableAdapter = new gardenguardian_databaseDataSetTableAdapters.machineTableAdapter();

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public int WateringSchedule { get; set; }
        public string WeekOrMonth { get; set; }
        public DateTime LastWatering { get; set; }
        public string ImagePath { get; set; }
        public int MachineID { get; set; }
        public string MachineIP { get; set; }

        /// <summary>
        /// Constructeur de la carte de la plante
        /// </summary>
        public PlantCard(DataRow plant = null)
        {
            InitializeComponent();

            if (plant != null)
            {
                
                PlantId = Convert.ToInt32(plant["id"]);
                PlantName = Convert.ToString(plant["plant_Name"]);
                WateringSchedule = Convert.ToInt32(plant["plant_schedule"]);
                WeekOrMonth = Convert.ToString(plant["plant_WeekMonth"]);
                LastWatering = Convert.ToDateTime(plant["plant_lastWatering"]);
                ImagePath = Convert.ToString(plant["plant_imagePath"]);

                MachineID = Convert.ToInt32(plant["ref_machine_id"]);
                MachineIP = machineTableAdapter.GetIp(MachineID);


                LAB_PlantName.Text = PlantName;
                LAB_Schedule.Text = WateringSchedule.ToString();
                if (WeekOrMonth == "Week") LAB_Schedule.Text += " fois par semaine";
                else LAB_Schedule.Text += " fois par mois";
                LAB_LastWatering.Text = LastWatering.ToString();
                LAB_Machine.Text = MachineIP;

                PICBOX_Plant.ImageLocation = ImagePath;
            }
        }

        private void PICBOX_Plant_Click(object sender, EventArgs e)
        {

        }

        private void BUT_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes vous sur de vouloir supprimer cette plante ?", "Attention", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MainForm.schedulingTableAdapter.DeleteQueryFromId(PlantId);
                plantsTableAdapter.DeleteQueryFromId(PlantId);
                this.isDestroyed(this, new EventArgs());

            }
        }

        private void BUT_edit_Click(object sender, EventArgs e)
        {
            this.statsRequested(this, new EventArgs());
        }
    }
}
