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
    /// <summary>
    /// Contrôle utilisateur affichant les informations météos
    /// </summary>
    public partial class ForecastUserControl : UserControl
    {
        private List<Forecast> forecasts;
        private WeatherClient client = new WeatherClient();
        
        public ForecastUserControl()
        {
            InitializeComponent();
            client.DataReceived += ClientReceivedData;
        }

        private void BUT_Add_Click(object sender, EventArgs e)
        {
            client.SendRequest("Paris/France");

        }

        private void ClientReceivedData(object sender, EventArgs e)
        {
            forecasts = client.GetForecast();

            var weather = new WeatherCard(forecasts[0]);

            FLOWPAN_Forecast.Controls.Add(weather);
        }
    }
}
