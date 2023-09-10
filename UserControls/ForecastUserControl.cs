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

        private void ClientReceivedData(object sender, EventArgs e)
        {
            forecasts = client.GetForecast();
            foreach(Forecast frcst in forecasts)
            {
                var weather = new WeatherCard(frcst);

                FLOWPAN_Forecast.Controls.Add(weather);
            }
            
        }

        private void ForecastUserControl_DoubleClick(object sender, EventArgs e)
        {
            

        }

        private void FLOWPAN_Forecast_DoubleClick(object sender, EventArgs e)
        {
            client.SendRequest("Paris/France");
        }
    }
}
