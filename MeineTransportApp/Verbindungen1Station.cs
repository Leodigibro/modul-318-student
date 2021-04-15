using SwissTransport.Core;
using SwissTransport.Models;
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
        ITransport transport = new Transport();
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
        private void CBStation_TextUpdate()
        {
            CBStation.Items.Clear();
            CBStation.SelectionStart = CBStation.Text.Length;
            CBStation.SelectionLength = 0;
            CBStation.DroppedDown = true;
            
            foreach(Station station in transport.GetStations(CBStation.Text).StationList)
            {
                if (station.Name != null)
                    CBStation.Items.Add(station.Name);
            }
        }
        private void btnSuchen_Click(object sender, EventArgs e)
        {

        }
    }
}