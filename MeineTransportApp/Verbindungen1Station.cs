using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Models;
using SwissTransport.Core;
using System.Net.Mail;
using System.Diagnostics;

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
        public void VorschlagLeer(ComboBox wert)
        {
            wert.Items.Clear();
            wert.SelectionStart = wert.Text.Length;
            wert.SelectionLength = 0;
        }
        public void VorschlagVoll(ComboBox wert)
        {
            ITransport temp = new Transport();
            wert.DroppedDown = true;
            foreach (Station station in temp.GetStations(wert.Text).StationList)
            {
                if (station.Name != null)
                    wert.Items.Add(station.Name);
            }
        }
        private void CBVon_TextUpdate(object sender, EventArgs e)
        {
            VorschlagLeer(CBStation);
            VorschlagVoll(CBStation);
        }
        private void btnSuchen_Click_1(object sender, EventArgs e)
        {
            if (CBStation.Text.Length > 0)
            {
                ITransport temp = new Transport();
                LVAbfahrt.Items.Clear();
                string inter = "0";
                foreach (StationBoard connection in temp.GetStationBoard(CBStation.Text, inter).Entries)
                {
                    int i = Convert.ToInt32(inter);
                    i++;
                    inter = Convert.ToString(i);
                    LVAbfahrt.Items.Add(LV(connection));
                }
            }
            else
            {
                MessageBox.Show("Geben Sie Ihre gewünschte Station an!");
            }
        }
        public ListViewItem LV(StationBoard connection)
        {
            string[] Zeile =
            {
                connection.To,
                connection.Stop.Departure.ToString().Substring(0,16)
            };
            return new ListViewItem(Zeile);
        }
    }
}