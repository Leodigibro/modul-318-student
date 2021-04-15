using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;

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
            ITransport transport = new Transport();
            LVTabelle.Items.Clear();
            foreach(SwissTransport.Models.Connection temp in transport.GetConnections(CBVon.Text, CBNach.Text).ConnectionList)
            {
                LVTabelle.Items.Add(Zeile(temp));
            }
        }
        private ListViewItem Zeile(SwissTransport.Models.Connection STrans)
        {
            string[] datenarray =
            {
                STrans.From.Station.Name,
                STrans.From.Departure.ToString().Substring(0,16),
                STrans.To.Station.Name,
                STrans.To.Arrival.ToString().Substring(0,16),
                STrans.From.Platform
            };
            return new ListViewItem(datenarray);
        }
    }
}