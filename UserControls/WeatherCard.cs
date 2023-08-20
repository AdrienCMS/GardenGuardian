using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GardenGuardian.Utilities;

namespace GardenGuardian.UserControls
{
    public partial class WeatherCard : UserControl
    {

        private static readonly Color[] colors = new Color[]
        {
                Color.FromArgb(0, 0, 255),   // -15°C (Blue)
                Color.FromArgb(51, 102, 255), // -10°C (Light Blue)
                Color.FromArgb(102, 153, 255),// -5°C (Lighter Blue)
                Color.FromArgb(153, 204, 255),// 0°C (Very Light Blue)
                Color.FromArgb(204, 204, 204),// 5°C (Gray)
                Color.FromArgb(255, 204, 102),// 10°C (Light Orange)
                Color.FromArgb(255, 153, 51), // 15°C (Orange)
                Color.FromArgb(255, 102, 0),  // 20°C (Dark Orange)
                Color.FromArgb(255, 0, 0),    // 25°C (Red)
                Color.FromArgb(204, 0, 0),    // 30°C (Dark Red)
                Color.FromArgb(153, 0, 0)     // 35°C (Very Dark Red)
        };
        private static readonly double[] temperatures = new double[]
        {
            -15.0,   // 0%
            -10.0,   // 10%
            -5.0,    // 20%
            0.0,     // 30%
            5.0,     // 40%
            15.0,    // 51%
            20.0,    // 60%
            25.0,    // 70%
            30.0,    // 80%
            35.0,    // 90%
            40.0     // 100%
        };
        public Forecast AssociatedForecast { get; set; }


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="forecastDay">Prévision associée</param>
        public WeatherCard(Forecast forecastDay)
        {
            InitializeComponent();
            string iconPath;
            AssociatedForecast = forecastDay;
            if(forecastDay.IsToday)
            {

            }
            //Affichage des valeurs
            LAB_Condition.Text = (string)AssociatedForecast.DayForecast.Rows[0]["condition_text"];
            LAB_Time.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["date"]);
            LAB_MaxTemp.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["maxtemp_c"]) + "C °";
            LAB_MaxTemp.ForeColor = GetValueColor((double)AssociatedForecast.DayForecast.Rows[0]["maxtemp_c"]);
            LAB_MinTemp.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["mintemp_c"]) + "C °";
            LAB_MinTemp.ForeColor = GetValueColor((double)AssociatedForecast.DayForecast.Rows[0]["mintemp_c"]);
            LAB_AverageTemp.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["avgtemp_c"]) + "C °";
            LAB_AverageTemp.ForeColor = GetValueColor((double)AssociatedForecast.DayForecast.Rows[0]["avgtemp_c"]);

            LAB_Humidity.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["avghumidity"]) + " %";
            LAB_WindForce.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["maxwind_kph"]) + " km/h";
            LAB_WindDir.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["daily_will_it_rain"] )+ " °";
            LAB_RainChance.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["daily_chance_of_rain"]) + " %";
            LAB_SnowChance.Text = Convert.ToString(AssociatedForecast.DayForecast.Rows[0]["daily_chance_of_snow"])+ " %";


            //Recherche de l'icone
            iconPath = (string)AssociatedForecast.DayForecast.Rows[0]["condition_icon"];
            int lastIndex = iconPath.LastIndexOf('/');
            if (lastIndex != -1)
            {
                string imageName = iconPath.Substring(lastIndex + 1);
                string WeatherImagesPath = @"..\..\Resources\weatherImages\";
                PICBOX_Current.BackgroundImage = Image.FromFile(WeatherImagesPath+imageName);
                PICBOX_Current.BackgroundImageLayout = ImageLayout.Zoom;
            }

        }

        /// <summary>
        /// Retourne la couleur correspondant à la valeur entrée en paramètre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color GetValueColor(double value)
        {
            Color color;
            int index = 0;

            //On cherche à identifier la couleur correspondant à la valeur lue
            for (int k = 0; k < temperatures.Length; k++)
            {
                if (value > temperatures[k])
                {
                    index = k;
                }
            }

            color = colors[index];
            return color;
        }
    }
             
}
