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
    /// <summary>
    /// Panneau de visualisation des plantes enregistrées
    /// </summary>
    public partial class PlantUserControl : UserControl
    {
        /// <summary>
        /// Formulaire dans lequel on insèrera les nouvelles plantes
        /// </summary>
        NewPlantForm newPlantForm = new NewPlantForm();
        /// <summary>
        /// Constructeur du panneau
        /// </summary>
        public PlantUserControl()
        {
            InitializeComponent();
            newPlantForm.BUT_Save_Click += NewPlantForm_Closed;
        }

        /// <summary>
        /// Délégué appelé lors d'un clic sur le bouton "TS_BUT_Add
        /// Ouvre le formulaire d'ajout de plante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSBUT_Add_Click(object sender, EventArgs e)
        {
            //Si il n'est pas déjà visible
            if (!formOpen(newPlantForm.Name))
            {
                //On affiche le formulaire
                newPlantForm.Show();
                
            }
            else
            {

            } 
        }

        /// <summary>
        /// Délégué appelé lorsque l'utilisateur apppuie sur le bouton "enregistrer"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewPlantForm_Closed(Object sender, EventArgs e)
        {
            reLoad();
         
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
            FLOWPAN_Plants.Controls.Clear();
            foreach(DataRow plant in plants.Rows)
            {
                var newPlant = new PlantCard(plant);
                newPlant.statsRequested += displayPlantStats;
                newPlant.isDestroyed += destroyPlantCard;

               this.FLOWPAN_Plants.Controls.Add(newPlant);

            }
        }

        /// <summary>
        /// Permet de vérifier si un formulaire est ouvert
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool formOpen(string name)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == name)
                {
                    return true; // Vous pouvez quitter la boucle dès que le formulaire est trouvé
                }
            }
            return false;
        }

        /// <summary>
        /// Ouvre un formulaire affichant les statistiques de la plante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayPlantStats(object sender, EventArgs e)
        {
            PlantCard plantCardSender = (PlantCard)sender;
            PlantStats plantstatsForm = new PlantStats(plantCardSender);
            plantstatsForm.Show();
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
