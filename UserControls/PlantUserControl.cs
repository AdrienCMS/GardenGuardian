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
    /// <summary>
    /// Panneau de visualisation des plantes enregistrées
    /// </summary>
    public partial class PlantUserControl : UserControl
    {
        /// <summary>
        /// Constructeur du panneau
        /// </summary>
        public PlantUserControl()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Délégué appelé lors d'un clic sur le bouton "TS_BUT_Add
        /// Ouvre le formulaire d'ajout de plante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSBUT_Add_Click(object sender, EventArgs e)
        {
            var newPlant = new PlantCard(); newPlant.isDestroyed += destroyPlantCard;

            this.FLOWPAN_Plants.Controls.Add(newPlant);
        }

        /// <summary>
        /// Délégué appelé lors du chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlantUserControl_Load(object sender, EventArgs e)
        {
            //Remplissage du formulaire avec les plantes de la base de données
            reLoad();
        }

        /// <summary>
        /// Mise à jour du contrôle avec les informations de la base de données
        /// </summary>
        private void reLoad()
        {
            DataTable plants = this.plantsTableAdapter.GetData();

            foreach(DataRow plant in plants.Rows)
            {
                var newPlant = new PlantCard(plant);
                newPlant.isDestroyed += destroyPlantCard;

               this.FLOWPAN_Plants.Controls.Add(newPlant);

            }
        }


        /// <summary>
        /// Détruit la carte plante qui à déclenché l'évenement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void destroyPlantCard(object sender, EventArgs e)
        {

            FLOWPAN_Plants.Controls.Remove((UserControl)(sender));
        }

    }
}
