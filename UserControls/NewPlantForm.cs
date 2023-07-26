using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAC_APP_V2.UserControls
{
    public partial class NewPlantForm : Form
    {
        private string selectedImagePath { get; set; }
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
            if(TBOX_PlantName.Text == "" || CBOX_WeekMonth.SelectedText == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {
                plantsTableAdapter.InsertQuery(TBOX_PlantName.Text,(global::System.Nullable<int>) NUMDD_Schedule.Value, CBOX_WeekMonth.SelectedText,(global::System.Nullable<DateTime>)DTP_LastWatering.Value, selectedImagePath);
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
        }
    }
}
