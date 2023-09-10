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
    public partial class NewPlantForm : Form
    {
        public EventHandler BUT_Save_Click;
        private string selectedImagePath { get; set; }
        public string PlantName { get; }
        public NewPlantForm()
        {
            InitializeComponent();
            selectedImagePath = @"Resources\Wplant.png";
            PICBOX_Plant.ImageLocation = selectedImagePath;

        }

        /// <summary>
        /// Délégué appelé lors d'un clic sur le bouton "Enregistrer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BUT_Insert_Click(object sender, EventArgs e)
        {
            if(TBOX_PlantName.Text == "" || (string)CBOX_WeekMonth.SelectedItem == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {
                var weekMonth = "MONTH";
                if ((string)CBOX_WeekMonth.SelectedItem == "semaine")
                {
                    weekMonth = "WEEK";
                }

                plantsTableAdapter.InsertQuery(TBOX_PlantName.Text,(global::System.Nullable<int>) NUMDD_Schedule.Value, weekMonth, (global::System.Nullable<DateTime>)DTP_LastWatering.Value, selectedImagePath,(int)CBOX_Machine.SelectedValue);
                this.BUT_Save_Click(this, new EventArgs());
                this.Close();
            }
        }

        /// <summary>
        /// Délégué appelé lors d'un clic sur le bouton "Parcourir"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BUT_Browse_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == openImageDialog.ShowDialog())
            selectedImagePath = openImageDialog.FileName;
            PICBOX_Plant.Image = Image.FromFile(selectedImagePath);
            PICBOX_Plant.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void NewPlantForm_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gardenguardian_databaseDataSet.machine'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.machineTableAdapter.Fill(this.gardenguardian_databaseDataSet.machine);

        }

        private void CBOX_Machine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
