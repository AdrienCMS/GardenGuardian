using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GardenGuardian.Utilities
{
    /// <summary>
    /// Classe permettant la récupération des informations météo depuis WeatherApi
    /// </summary>
    class WeatherClient
    {
        public EventHandler DataReceived;
        public string ApiKey { get; set; }
        public string ApiUrl { get; set; }

        public string JsonString { get; set; }
        private string TempFolder = @"../../Json";
        private string filePath = "WeatherAPIForecast" ; 
        
        public WeatherClient()
        {
            ApiKey = "b8fc6d66beb2421eb89125255233007";
            ApiUrl = "https://api.weatherapi.com/v1/";
        }

        public async void SendRequest(string location)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //Paramétrage de la requête
                    ApiUrl += $"forecast.json?key={ApiKey}&q={location}&days=7";
                    HttpResponseMessage response = await client.GetAsync(ApiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Lecture de la réponse en tant que chaine de caractères
                        JsonString = await response.Content.ReadAsStringAsync();
                        //On sauvegarde le fichier Json (pour inspection)
                        if(!Directory.Exists(TempFolder))
                        {
                            Directory.CreateDirectory(TempFolder);
                        }
                        filePath = TempFolder + "/" + filePath+ DateTime.Now.ToString("dd_MM_HH_mm") + ".json";
                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }

                        using (StreamWriter writer = File.CreateText(filePath))
                        {
                            writer.Write(JsonString);
                            writer.Close();
                        }
                        filePath = "WeatherAPIForecast";
                        DataReceived(this, new EventArgs());

                    }
                    else
                    {
                        MessageBox.Show($"Failed to get data. Status code: {response.StatusCode} \n","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Failed to get data. Status code: {ex.Message} \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Renvoie le contenu du fichier JSON sous forme d'objets Forecast (les données utiles uniquement)
        /// </summary>
        /// <returns></returns>
        public List<Forecast> GetForecast()
        {
            List<Forecast> forecasts = new List<Forecast>();

            JObject jObject = JObject.Parse(JsonString);
            JArray daysArray = (JArray)jObject["forecast"]["forecastday"];

            bool today =true;
            int rowIndex = 0;

            foreach(JToken day in daysArray)
            {
                Forecast forcst;
                //Si il s'agit du premier jour on renseigne également les champs contenus dans current
               if (today)
                {
                    forcst = new Forecast(today);
                    //Récupération des informations contenues dans current
                    forcst.LastUpdate = Convert.ToDateTime(jObject["current"]["last_updated"]);
                    forcst.CurrentTemp = (double)jObject["current"]["temp_c"];
                    forcst.CurrentHumidity = (double)jObject["current"]["wind_kph"];
                    forcst.CurrentHumidity = (double)jObject["current"]["wind_degree"];
                    forcst.CurrentHumidity = (double)jObject["current"]["humidity"];
                    forcst.CurrentCondition = (string)jObject["current"]["condition"]["text"];
                    forcst.IconCode = (string)jObject["current"]["condition"]["icon"];
                    today = false;
                }
                else
                {
                    forcst = new Forecast(today);
                }

                //Récupération des informations contenue dans la section "forecastday"
                forcst.DayForecast.Rows.Add();
                forcst.DayForecast.Rows[0]["date"] = (DateTime)day["date"];
                forcst.DayForecast.Rows[0]["maxtemp_c"] = (double)day["day"]["maxtemp_c"];
                forcst.DayForecast.Rows[0]["mintemp_c"] = (double)day["day"]["mintemp_c"];
                forcst.DayForecast.Rows[0]["avgtemp_c"] = (double)day["day"]["avgtemp_c"];
                forcst.DayForecast.Rows[0]["maxwind_kph"] = (double)day["day"]["maxwind_kph"];
                forcst.DayForecast.Rows[0]["avghumidity"] = (double)day["day"]["avghumidity"];
                forcst.DayForecast.Rows[0]["daily_will_it_rain"] = (double)day["day"]["daily_will_it_rain"];
                forcst.DayForecast.Rows[0]["daily_chance_of_rain"] = (double)day["day"]["daily_chance_of_rain"];
                forcst.DayForecast.Rows[0]["daily_will_it_snow"] = (double)day["day"]["daily_will_it_snow"];
                forcst.DayForecast.Rows[0]["daily_chance_of_snow"] = (string)day["day"]["daily_chance_of_snow"];
                forcst.DayForecast.Rows[0]["condition_text"] = (string)day["day"]["condition"]["text"];
                forcst.DayForecast.Rows[0]["condition_icon"] = (string)day["day"]["condition"]["icon"];

                foreach(JToken hour in day["hour"])
                {
                    forcst.HoursForecast.Rows.Add();
                    //Récupération des informations contenues dans la section "hour"
                    forcst.HoursForecast.Rows[rowIndex]["time"] = (DateTime)hour["time"];
                    forcst.HoursForecast.Rows[rowIndex]["temp_c"] = (double)hour["temp_c"];
                    forcst.HoursForecast.Rows[rowIndex]["wind_kph"] = (double)hour["wind_kph"];
                    forcst.HoursForecast.Rows[rowIndex]["wind_degree"] = (double)hour["wind_degree"];
                    forcst.HoursForecast.Rows[rowIndex]["humidity"] = (double)hour["humidity"];
                    forcst.HoursForecast.Rows[rowIndex]["will_it_rain"] = (double)hour["will_it_rain"];
                    forcst.HoursForecast.Rows[rowIndex]["chance_of_rain"] = (double)hour["chance_of_rain"];
                    forcst.HoursForecast.Rows[rowIndex]["will_it_snow"] = (double)hour["will_it_snow"];
                    forcst.HoursForecast.Rows[rowIndex]["chance_of_snow"] = (double)hour["chance_of_snow"];
                    forcst.HoursForecast.Rows[rowIndex]["condition_text"] = (string)hour["condition_text"];
                    forcst.HoursForecast.Rows[rowIndex]["condition_icon"] = (string)hour["condition_icon"];
                    rowIndex++;
                }
                rowIndex = 0;

                forecasts.Add(forcst);
            }


            return forecasts;
        }




    }
}
