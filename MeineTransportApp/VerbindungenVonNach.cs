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
    public partial class VerbindungenVonNach : Form
    {
        public VerbindungenVonNach()
        {
            InitializeComponent();
        }

        private void VerbindungenVonNach_Load(object sender, EventArgs e)
        {

        }

        private void btnZurueckVerbindungenVonNach_Click(object sender, EventArgs e)
        {
            StartSeite Startfenster = new StartSeite();
            Startfenster.Show();

            this.Hide();
        }
    }
}
