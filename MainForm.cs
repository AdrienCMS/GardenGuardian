using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO;
using System.IO.Pipes;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using WinSCP;
using System.Windows.Forms;
using GardenGuardian.Controls;
using GardenGuardian.Utilities;
using static GardenGuardian.Utilities.Error;

namespace GardenGuardian
{
    /// <summary>
    /// Classe principale du programme
    ///     Gestion du menu
    ///     Communication client/serveur
    ///     Thread principal du programme
    /// </summary>
    public partial class MainForm : Form
    {

        #region Initialisation
        /*Définitions des différents panneaux de contrôles*/
        /// <summary>
        /// Contrôle utilisateur d'accueil , affiche les planifications d'arrosage
        /// </summary>
        public UserControls.HomeUserControl Home = new UserControls.HomeUserControl();
        /// <summary>
        /// Contrôle utilisateur de gestion des plantes (communication BDD)
        /// </summary>
        public UserControls.PlantUserControl Plants = new UserControls.PlantUserControl();
        /// <summary>
        /// Contrôle utilisateur d'affichage des prévisions météo
        /// </summary>
        public UserControls.ForecastUserControl Forecast = new UserControls.ForecastUserControl();
        /// <summary>
        /// Contrôle utilisateur de gestion des machines
        /// </summary>
        public UserControls.SettingsUserControl Settings = new UserControls.SettingsUserControl();

        // Initialisation des tableAdapters
        public static gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter plantsTableAdapter = new gardenguardian_databaseDataSetTableAdapters.plantsTableAdapter();
        public static gardenguardian_databaseDataSetTableAdapters.machineTableAdapter machineTableAdapter = new gardenguardian_databaseDataSetTableAdapters.machineTableAdapter();
        public static gardenguardian_databaseDataSetTableAdapters.schedulingTableAdapter schedulingTableAdapter = new gardenguardian_databaseDataSetTableAdapters.schedulingTableAdapter();

        UserControl currentControl;
        Controls.MenuButton currentButton;
        Process missionPlanner = new Process();

        /*Booléens*/
        public static bool ApplicationClosing = false;//Permet d'indiquer au threads que l'application se ferme
        public static bool ReceivedMessage = false;
        /*Apparence*/
        Color BackgroundColor = Color.FromArgb(48, 48, 45);
        /*Thread*/
        Thread WateringThread;

        /*Récupération des informations*/
        WeatherClient weatherClient = new WeatherClient();//Client WeatherAPI
        SocketServer server;

        /// <summary>
        /// Fenêtre principale du projet
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //Initialisation des différents contrôles
            currentControl = Home;
            currentControl.Dock = DockStyle.Fill;
            currentButton = menuBUT_Home;
            currentButton.BackColor = currentButton.lineColor;
            mainPanel.Controls.Add(currentControl);

            

            //Initialisation du thread
            WateringThread = new Thread(wateringMethod);
        }

        /// <summary>
        /// Délégué appelé une fois la fenêtre principale visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            //Initialisation
            server = new SocketServer();
            //Association des délégués de la classe au gestinonnaire évènement du serveur socket
            server.InfosReceived += serverReceivedInfo;
            server.AlertReceived += serverReceivedAlert;
            //Lancement du serveur
            server.Start();
            //Lancement du thread principal
            WateringThread.Start();
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

        #region Thread principal du programme
        /// <summary>
        /// Thread principal du programme se rééxécute toute les heures à moins que l'application ne ferme
        /// Vérifie l'état des prévisions météo et des capteurs et programme des arrosages
        /// </summary>
        private void wateringMethod()
        {
            DateTime lastWatering,wateringDate;
            double daysBetween = 0;
            string[] messageElements;
            
            DataTable plants; 
            DataTable schedule;
            DataTable machines;
            while (!ApplicationClosing)
            {
                plants = plantsTableAdapter.GetData();
                schedule = schedulingTableAdapter.GetData();
                machines = machineTableAdapter.GetData();

                //---Interogation des clients---
                foreach(Socket client in server.clients)
                {
                    //Si le client est connecté
                    if (client.Connected)
                    {
                        //On envoie le message de requête d'informations
                        server.SendMessage(client, "REQUEST");
                        //On attend la réception du message
                        while (!ReceivedMessage)
                        {
                            //On quitte la boucle si le client est déconnecté 
                            if (!client.Connected)
                                break;
                        };
                        ReceivedMessage = false;
                        messageElements = server.InputMessage.Split();
                        //On vérifie si le message est au format attendu
                        if (messageElements[0] == "INFOS")
                        {
                            foreach (DataRow machine in machines.Rows)
                            {
                                //On vérifie le type du point de terminaison (si oui ou non il contient l'adresse du client)
                                if (client.RemoteEndPoint is IPEndPoint ipEndPoint)
                                {
                                    //Une fois le clients  trouvé à l'aide de son adresse, on met à jour les valeurs obtenues
                                    if (ipEndPoint.Address.ToString() == (string)machine["machine_ip"])
                                    {
                                        machine["machine_water_supply"] = messageElements[1];
                                        machine["machine_ground_humidity"] = messageElements[2];
                                        //On met à jour la base de données avec les nouvelles valeurs
                                        machineTableAdapter.Update(machine);
                                    }
                                }

                            }
                        }
                    }

                }
                

                //---Planification d'arrosage (Si aucun prévu)---
                foreach (DataRow plant in plants.Rows)
                {
                    //Si il n'y a pas déjà un arrosage de prévu on en programme un
                    if (!isScheduled((int)plant["id"]))
                    {
                        //Calcul du temps jusqu'au prochain arrosage
                        if ((string)plant["plant_weekMonth"] == "WEEK")
                        {
                            daysBetween = 7 / (int)plant["plant_schedule"];
                        }
                        else if ((string)plant["plant_weekMonth"] == "MONTH")
                        {
                            daysBetween = 30 / (int)plant["plant_schedule"];
                        }

                        lastWatering = Convert.ToDateTime(plant["plant_LastWatering"]);
                        wateringDate = lastWatering.AddDays(daysBetween);

                        //Une fois le temps jusqu'au prochain arrosage calculé, on insère l'arrosage dans la base de données
                        schedulingTableAdapter.InsertQuery(wateringDate, (int)plant["id"]);
                    }
                }

                //---Modification des planification si la météo annonce de la pluie---
                //Pour chaque évènement programmé
                foreach (DataRow row in schedule.Rows)
                {
                    //Si il s'agit du jour de l'arrosage
                    if (Convert.ToDateTime(row["watering_date"]).Day == DateTime.Today.Day)
                    {
                        try
                        {
                            //On interroge l'API météo
                            foreach (Forecast forecast in weatherClient.GetForecast())
                            {
                                //Si il s'agit de la prévision d'aujourd'hui et que de la pluie est annoncée, on annule l'arrosage
                                if(forecast.IsToday && ((int)forecast.DayForecast.Rows[0]["daily_will_it_rain"] == 1))
                                {
                                    schedulingTableAdapter.DeleteQueryFromId((int)row["scheduling_id"]);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Un exception s'est produite" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //---Envoi des instructions d'arrosage & suppression des anciennes prévisions---
                //Pour chaque évènement programmé
                foreach (DataRow row_1 in schedule.Rows)
                {
                    //Si il s'agit du jour de l'arrosage
                    if (Convert.ToDateTime(row_1["watering_date"]).Day == DateTime.Today.Day)
                    {
                        try
                        {
                            //On recherche la machine concernée parmis la liste des clients
                            for (int i = 0; i < server.clients.Count; i++)
                            {
                                if (server.clients[i].RemoteEndPoint is IPEndPoint ipEndPoint)
                                {
                                    //Une fois le clients  trouvé à l'aide de son adresse, on envoie le message
                                    //et on supprime la prévision de la base de données
                                    if (ipEndPoint.Address.ToString() == machineIP((int)row_1["ref_plant_id"]))
                                    {
                                        server.SendMessage(server.clients[i], "INSTR");
                                        schedulingTableAdapter.DeleteQueryFromId((int)row_1["scheduling_id"]);
                                    }
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Un exception s'est produite" + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //Enfin on affiche les messages de prévisions restant dans la fenêtre principale
                Home.DisplaySchedule(schedule);

                //Le thread s'interompt et se remet en marche une fois par heure
                Thread.Sleep(3600000);
            }

        }

        /// <summary>
        /// Renvoie TRUE si un arrosage est prévu pour la plante dont l'id est entré en paramètre
        /// FALSE sinon
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool isScheduled(int id)
        {
            bool output = false;
            foreach(DataRow schedule in schedulingTableAdapter.GetData().Rows)
            {
                if((int)schedule["ref_plant_id"] == id)
                {
                    output |= true;
                }
            }

            return output;
            
        }

        /// <summary>
        /// Méthode qui renvoie l'adresse ip de la machine associée à la plante dont l'id est fournis en paramètre
        /// </summary>
        /// <param name="plant_id"></param>
        /// <returns></returns>
        public string machineIP(int plant_id)
        {
            string ip = "0.0.0.0";

            string plantName = plantsTableAdapter.GetName(plant_id);
            DataTable plants = plantsTableAdapter.GetDataByName(plantName);

            DataTable machines = machineTableAdapter.GetData();

            foreach(DataRow plant in plants.Rows)
            {
                foreach(DataRow machine in machines.Rows)
                {
                    if((int)plant["ref_machine_id"] == (int)machine["machine_id"])
                    {
                        ip = (string)machine["machine_ip"];
                    }
                }
            }

            return ip;

        }
        #endregion
        #region Délégués liés au serveur socket
        /// <summary>
        /// Délégués appelé lorsqu'un message d'information est reçu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverReceivedInfo(object sender, EventArgs e)
        {
            ReceivedMessage = true;
        }
        /// <summary>
        /// Délégué appelé lorsqu'une erreur est reçue, affiche l'erreur dans HomeUserControl en tant que message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serverReceivedAlert(object sender, EventArgs e)
        {
            string machineIP = "";
            if (server.AlertedClient.RemoteEndPoint is IPEndPoint ipEndPoint)
            {
                machineIP = ipEndPoint.ToString() ;
            }
            
            Home.AddAlert(machineIP);
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
            Environment.Exit(0);
            ApplicationClosing = true;
            server.Stop();
            WateringThread.Abort();

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
