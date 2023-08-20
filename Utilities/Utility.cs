using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using static System.Math;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GardenGuardian.Utilities
{
    #region classes
    public class Forecast
    {
        /// <summary>
        /// Booléen indicant si l'objet fait référence à la date d'aujourd'hui
        /// </summary>
        public bool IsToday { get; }
        /// <summary>
        /// Indique la date et l'heure à laquelle les données on étés récupérées
        /// </summary>
        public DateTime LastUpdate { get; set; }
        /// <summary>
        /// Indique la température actuelle (en °C)
        /// </summary>
        public double CurrentTemp { get; set; }
        /// <summary>
        /// Indique les condition actuelles (pluie, neige, ciel dégagé ect ...)
        /// </summary>
        public string CurrentCondition { get; set; }
        /// <summary>
        /// Code correspondant à l'image représentant les conditions actuelles
        /// </summary>
        public string IconCode { get; set; }
        /// <summary>
        /// Force du vent (km/h)
        /// </summary>
        public double CurrentWindForce { get; set; }
        /// <summary>
        /// Direction du vent (par rapport au nord magnétique)
        /// </summary>
        public double CurrentWindDirection { get; set; }
        /// <summary>
        /// Taux d'humidité
        /// </summary>
        public double CurrentHumidity { get; set; }
        /// <summary>
        /// Prévisions moyennes pour la journée
        /// </summary>
        public DataTable DayForecast { get; set; }
        /// <summary>
        /// Prévisions précises (toute les deux heures)
        /// </summary>
        public DataTable HoursForecast { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="today"></param>
        /// <param name="iconCode"></param>
        public Forecast(bool today)
        {
            DayForecast = new DataTable();
            HoursForecast = new DataTable();
            /*Remplissage des DataTables */
            DayForecast.Columns.Add("date",typeof(DateTime));
            DayForecast.Columns.Add("maxtemp_c", typeof(double));
            DayForecast.Columns.Add("mintemp_c", typeof(double));
            DayForecast.Columns.Add("avgtemp_c", typeof(double));
            DayForecast.Columns.Add("maxwind_kph", typeof(double));
            DayForecast.Columns.Add("avghumidity", typeof(double));
            DayForecast.Columns.Add("daily_will_it_rain", typeof(double));
            DayForecast.Columns.Add("daily_chance_of_rain", typeof(double));
            DayForecast.Columns.Add("daily_will_it_snow", typeof(double));
            DayForecast.Columns.Add("daily_chance_of_snow", typeof(double));
            DayForecast.Columns.Add("condition_text", typeof(string));
            DayForecast.Columns.Add("condition_icon", typeof(string));

            HoursForecast.Columns.Add("time", typeof(DateTime));
            HoursForecast.Columns.Add("temp_c", typeof(double));
            HoursForecast.Columns.Add("wind_kph", typeof(double));
            HoursForecast.Columns.Add("wind_degree", typeof(double));
            HoursForecast.Columns.Add("humidity", typeof(double));
            HoursForecast.Columns.Add("will_it_rain", typeof(double));
            HoursForecast.Columns.Add("chance_of_rain", typeof(double));
            HoursForecast.Columns.Add("will_it_snow", typeof(double));
            HoursForecast.Columns.Add("chance_of_snow", typeof(double));
            HoursForecast.Columns.Add("condition_text", typeof(string));
            HoursForecast.Columns.Add("condition_icon", typeof(string));

        }
    }
    #endregion

   
}
