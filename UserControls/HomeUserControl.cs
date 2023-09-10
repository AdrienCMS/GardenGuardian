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
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affiche les arrosages prévus
        /// </summary>
        /// <param name="schedule"></param>
        public void DisplaySchedule(DataTable schedule)
        {
            foreach(DataRow row in schedule.Rows)
            {
                var plantName = MainForm.plantsTableAdapter.GetName((int)row["ref_plant_id"]);

                var scheduleControl = new message(Convert.ToDateTime(row["watering_date"]),plantName);
                scheduleControl.BUT_Delete_Clicked += deleteMessage;
                if (InvokeRequired)
                {
                    FLOWPAN_Schedule.Invoke(new MethodInvoker(
                        delegate
                        {
                            FLOWPAN_Schedule.Controls.Add(scheduleControl);
                           
                        }));
                }
                else
                {
                    FLOWPAN_Schedule.Controls.Add(scheduleControl);
                }

            }
        }
        /// <summary>
        /// Ajoute un message d'alerte sur la fenêtre principale
        /// </summary>
        public void AddAlert(string plantName)
        {
            var alert = new message(DateTime.Now, plantName, true);
            alert.BUT_Delete_Clicked += deleteMessage;
            if (InvokeRequired)
            {
                FLOWPAN_Schedule.Invoke(new MethodInvoker(
                    delegate
                    {
                        FLOWPAN_Schedule.Controls.Add(alert);

                    }));
            }
            else
            {
                FLOWPAN_Schedule.Controls.Add(alert);
            }
        }

        //Délégué appelé pour supprimer l'objet
        private void deleteMessage(object sender,EventArgs e)
        {
            FLOWPAN_Schedule.Controls.Remove((UserControl)(sender));
        }
        private void FLOWPAN_Schedule_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
