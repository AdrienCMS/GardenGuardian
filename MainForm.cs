using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Web;
using WinSCP;
using System.Windows.Forms;
using PAC_APP_V2.Controls;
using PAC_APP_V2.Utilities;
using static PAC_APP_V2.Utilities.Constants;
using static PAC_APP_V2.Utilities.Error;

namespace PAC_APP_V2
{
    /// <summary>
    /// Classe principale du programme
    ///     Gestion du menu
    ///     Communication série
    ///     Communication IPC
    ///     Post traitement
    /// </summary>
    public partial class MainForm : Form
    {

        #region Initialisation

        /*Définitions des différents panneaux de contrôles*/
        /// <summary>
        /// Contrôle utilisateur d'accueil (vide)
        /// </summary>
        public UserControls.HomeUserControl Home = new UserControls.HomeUserControl();
        /// <summary>
        /// Contrôle utilisateur de gestion des plantes (communication BDD)
        /// </summary>
        public UserControls.PlantUserControl Plants = new UserControls.PlantUserControl();
        /// <summary>
        /// Contrôle utilisateur d'affichage de la planification d'arrosage
        /// </summary>
        public UserControls.CalendarUserControl Calendar = new UserControls.CalendarUserControl();
        /// <summary>
        /// Contrôle utilisateur d'affichage des prévisions météo
        /// </summary>
        public UserControls.ForecastUserControl Forecast = new UserControls.ForecastUserControl();
        /// <summary>
        /// Contrôle utilisateur de gestion des machines connectées
        /// </summary>
        public UserControls.SettingsUserControl Settings = new UserControls.SettingsUserControl();


        UserControl currentControl;
        Controls.MenuButton currentButton;
        Process missionPlanner = new Process();


        /*Booléens*/

        private bool ApplicationClosing = false;
        private bool shutdown = false;

        /*Apparence*/
        Color BackgroundColor = Color.FromArgb(48, 48, 45);
        static public Font generalFont = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        /*Gestion de fichiers*/
        IniFile pacappIni = new IniFile(PROJECT_DATA_REPERTORY + @"\PACAPP.ini");

        /// <summary>
        /// Fenêtre principale du projet
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Association des délégués au gestionnaires d'évènements
            //Managment.UpdatedTable += updateField;


            //Initialisation des différents contrôles
            currentControl = Home;
            currentControl.Dock = DockStyle.Fill;
            currentButton = menuBUT_Home;
            currentButton.BackColor = currentButton.lineColor;
            mainPanel.Controls.Add(currentControl);


        }

        /// <summary>
        /// Délégué appelé une fois la fenêtre principale visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {


        }
        #endregion

        #region Délégués liés au menu principal
        /// <summary>
        /// Délégué appelé lors d'un clic sur le bouton menuBUT_Home
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBUT_home_Click(object sender, EventArgs e)
        {
            if (currentControl.Name != "HomeUserControl")
            {
                mainPanel.Controls.Remove(currentControl);

                currentButton.BackColor = BackgroundColor;
                currentButton = menuBUT_Home;
                currentButton.BackColor = currentButton.lineColor;

                currentControl = Home;
                currentControl.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(currentControl);
            }
        }

        private void menuBUT_Plants_Click(object sender, EventArgs e)
        {
            if (currentControl.Name != "PlantUserControl")
            {
                mainPanel.Controls.Remove(currentControl);

                currentButton.BackColor = BackgroundColor;
                currentButton = menuBUT_Plants;
                currentButton.BackColor = currentButton.lineColor;

                currentControl = Plants;
                currentControl.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(currentControl);
            }
        }

        private void menuBUT_Calendar_Click(object sender, EventArgs e)
        {
            if (currentControl.Name != "CalendarUserControl")
            {
                mainPanel.Controls.Remove(currentControl);

                currentButton.BackColor = BackgroundColor;
                currentButton = menuBUT_Calendar;
                currentButton.BackColor = currentButton.lineColor;

                currentControl = Calendar;
                currentControl.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(currentControl);
            }
        }

        private void menuBUT_Forecast_Click(object sender, EventArgs e)
        {
            if (currentControl.Name != "ForecastUserControl")
            {
                mainPanel.Controls.Remove(currentControl);

                currentButton.BackColor = BackgroundColor;
                currentButton = menuBUT_Forecast;
                currentButton.BackColor = currentButton.lineColor;

                currentControl = Forecast;
                currentControl.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(currentControl);
            }
        }

        private void menuBUT_Settings_Click(object sender, EventArgs e)
        {
            if (currentControl.Name != "SettingsUserControl")
            {
                mainPanel.Controls.Remove(currentControl);

                currentButton.BackColor = BackgroundColor;
                currentButton = menuBUT_Settings;
                currentButton.BackColor = currentButton.lineColor;

                currentControl = Settings;
                currentControl.Dock = DockStyle.Fill;

                mainPanel.Controls.Add(currentControl);
            }
        }


        /// <summary>
        /// Bouton de sortie du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuBUT_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Appui sur le bouton licence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripBUT_Licence_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #region Events de sortie du programme
        /// <summary>
        /// Délégué appelé à la fin du programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplicationClosing = true;

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


        #endregion

        private void PICBOX_Logo_Click(object sender, EventArgs e)
        {

        }


    }
    
}
