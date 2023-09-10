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
    /// Messages affichés dans la fenêtre HomeUserControl
    /// </summary>
    public partial class message : UserControl
    {
        public EventHandler BUT_Delete_Clicked;
        public message(DateTime date,string plantName,bool isAlert = false)
        {
            InitializeComponent();

            LAB_Date.Text = date.ToString("dd/MM HH:mm");
            LAB_Plant.Text = plantName;

            //Si il s'agit d'un message d'alerte
            if(isAlert)
            {
                LAB_Date.BackColor = Color.DarkRed;
                LAB_Date.Text = "Alerte : " + date.ToString("dd/MM HH:mm");
            }
             
        }

        private void BUT_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Supprimer le message ?","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.BUT_Delete_Clicked(this, new EventArgs());
            }
        }
    }
}
