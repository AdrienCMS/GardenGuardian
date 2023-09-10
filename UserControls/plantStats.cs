using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace GardenGuardian.UserControls
{
    public partial class PlantStats : Form
    {
        /// <summary>
        /// Création du formulaire + récupération et affichage des données depuis le fichier csv
        /// </summary>
        /// <param name="basePlant"></param>
        public PlantStats(PlantCard basePlant)
        {
            InitializeComponent();
            List<DateTime> dates = new List<DateTime>();
            List<double> humidity_value = new List<double>();
            List<double> water_supply = new List<double>();
            //Affichage des données en fonction de la plante et du fichier csv associé
            string csvFilePath = @"C:..\..\CSV_Files\" + basePlant.PlantName + "_data.csv";
            if (File.Exists(csvFilePath))
            {
                using (StreamReader reader = new StreamReader(csvFilePath))
                {
                    //On lit et on ignore la première ligne (qui correspond au noms des colonnes du fichier)
                    string line = reader.ReadLine();
                    string[] parts = line.Split(';');
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        parts = line.Split(';');

                        if (parts[0] != "date")
                        {
                            dates.Add(Convert.ToDateTime(parts[0]));
                            if (double.TryParse(parts[1], out double value))
                            {
                                humidity_value.Add(value);
                            }
                            if (double.TryParse(parts[2], out double val))
                            {
                                water_supply.Add(val);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucune donnée trouvée pour cette plante", "Pas de données", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }


            for (int i = 0; i < dates.Count(); i++)
            {
                CHART_Humidity.Series[0].Points.AddXY(dates[i], humidity_value[i]);
                CHART_WaterSupplies.Series[0].Points.AddXY(dates[i], water_supply[i]);

            }

            CHART_Humidity.Invalidate();
        }

                
    }
}
