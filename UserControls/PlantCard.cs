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

namespace PAC_APP_V2.UserControls
{
    public partial class PlantCard : UserControl
    {
        public EventHandler isDestroyed;
        private static readonly gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter plantsTableAdapter = new gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter();

        int PlantId { get; set; }
        string PlantName { get; set; }
        int WateringSchedule { get; set; }
        string WeekOrMonth { get; set; }
        DateTime LastWatering { get; set; }
        string ImagePath { get; set; }

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

                LAB_PlantName.Text = PlantName;
                LAB_Schedule.Text = WateringSchedule.ToString();
                if (WeekOrMonth == "Week") LAB_Schedule.Text += " fois par semaine";
                else LAB_Schedule.Text += " fois par mois";
                LAB_LastWatering.Text = LastWatering.ToString();

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
                plantsTableAdapter.DeleteQueryFromId(PlantId);
                this.isDestroyed(this, new EventArgs());

            }
        }
    }
}
