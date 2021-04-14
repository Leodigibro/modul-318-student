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
            txtUhrzeit.Text = DateTime.Now.ToString("HH.mm");
        }

        private void btnZurueckVerbindungenVonNach_Click(object sender, EventArgs e)
        {
            StartSeite Startfenster = new StartSeite();
            Startfenster.Show();

            this.Hide();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtUhrzeit.Text, "[^0-9]"))
            {
                MessageBox.Show("Nur Zahlen möglich.");
                txtUhrzeit.Text = txtUhrzeit.Text.Remove(txtUhrzeit.Text.Length - 1);
            }
        }

        private void txtUhrzeit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
