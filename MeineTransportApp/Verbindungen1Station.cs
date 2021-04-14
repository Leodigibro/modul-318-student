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
    public partial class Verbindungen1Station : Form
    {
        public Verbindungen1Station()
        {
            InitializeComponent();
        }

        private void btnZurueckVerbindungen1Station_Click(object sender, EventArgs e)
        {
            StartSeite Startfenster = new StartSeite();
            Startfenster.Show();
            
            this.Hide();
        }
    }
}