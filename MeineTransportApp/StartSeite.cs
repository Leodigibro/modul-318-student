using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeineTransportApp
{
    public partial class StartSeite : Form
    {
        public StartSeite()
        {
            InitializeComponent();
        }
        private void btnVerbSuE_Click_1(object sender, EventArgs e)
        {
            Verbindungen verbindungsfenster = new Verbindungen();
            verbindungsfenster.Show();

            this.Hide();
        }

        private void btnKarte_Click(object sender, EventArgs e)
        {
            Karte kartenfenster = new Karte();
            kartenfenster.Show();

            this.Hide();
        }
    }
}
