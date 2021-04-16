
namespace MeineTransportApp
{
    partial class Verbindungen1Station
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CBStation = new System.Windows.Forms.ComboBox();
            this.btnZurueckVerbindungen1Station = new System.Windows.Forms.Button();
            this.lStation = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.LVAbfahrt = new System.Windows.Forms.ListView();
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abfahrtszeit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBStation
            // 
            this.CBStation.FormattingEnabled = true;
            this.CBStation.Location = new System.Drawing.Point(46, 117);
            this.CBStation.Name = "CBStation";
            this.CBStation.Size = new System.Drawing.Size(505, 24);
            this.CBStation.TabIndex = 0;
            this.CBStation.TextUpdate += new System.EventHandler(this.CBVon_TextUpdate);
            // 
            // btnZurueckVerbindungen1Station
            // 
            this.btnZurueckVerbindungen1Station.Location = new System.Drawing.Point(621, 12);
            this.btnZurueckVerbindungen1Station.Name = "btnZurueckVerbindungen1Station";
            this.btnZurueckVerbindungen1Station.Size = new System.Drawing.Size(75, 23);
            this.btnZurueckVerbindungen1Station.TabIndex = 1;
            this.btnZurueckVerbindungen1Station.Text = "Zurück";
            this.btnZurueckVerbindungen1Station.UseVisualStyleBackColor = true;
            this.btnZurueckVerbindungen1Station.Click += new System.EventHandler(this.btnZurueckVerbindungen1Station_Click);
            // 
            // lStation
            // 
            this.lStation.AutoSize = true;
            this.lStation.Location = new System.Drawing.Point(43, 88);
            this.lStation.Name = "lStation";
            this.lStation.Size = new System.Drawing.Size(56, 17);
            this.lStation.TabIndex = 2;
            this.lStation.Text = "Station:";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(557, 117);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(139, 24);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click_1);
            // 
            // LVAbfahrt
            // 
            this.LVAbfahrt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nach,
            this.Abfahrtszeit});
            this.LVAbfahrt.HideSelection = false;
            this.LVAbfahrt.Location = new System.Drawing.Point(46, 147);
            this.LVAbfahrt.Name = "LVAbfahrt";
            this.LVAbfahrt.Size = new System.Drawing.Size(650, 205);
            this.LVAbfahrt.TabIndex = 4;
            this.LVAbfahrt.UseCompatibleStateImageBehavior = false;
            this.LVAbfahrt.View = System.Windows.Forms.View.Details;
            // 
            // Nach
            // 
            this.Nach.Text = "Nach";
            this.Nach.Width = 150;
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.Text = "Abfahrtszeit";
            this.Abfahrtszeit.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Verbindungen von einer Station aus";
            // 
            // Verbindungen1Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVAbfahrt);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.lStation);
            this.Controls.Add(this.btnZurueckVerbindungen1Station);
            this.Controls.Add(this.CBStation);
            this.Name = "Verbindungen1Station";
            this.Text = "Verbindungen1Station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBStation;
        private System.Windows.Forms.Button btnZurueckVerbindungen1Station;
        private System.Windows.Forms.Label lStation;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.ListView LVAbfahrt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Abfahrtszeit;
        private System.Windows.Forms.ColumnHeader Nach;
    }
}