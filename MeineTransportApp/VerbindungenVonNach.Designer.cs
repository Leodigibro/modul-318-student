
namespace MeineTransportApp
{
    partial class VerbindungenVonNach
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
            this.CBNach = new System.Windows.Forms.ComboBox();
            this.CBVon = new System.Windows.Forms.ComboBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnZurueckVerbindungenVonNach = new System.Windows.Forms.Button();
            this.lVon = new System.Windows.Forms.Label();
            this.lNach = new System.Windows.Forms.Label();
            this.LVTabelle = new System.Windows.Forms.ListView();
            this.Von = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ankunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gleis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtUhrzeit = new System.Windows.Forms.TextBox();
            this.lDatum = new System.Windows.Forms.Label();
            this.lUhrzeit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBNach
            // 
            this.CBNach.FormattingEnabled = true;
            this.CBNach.Location = new System.Drawing.Point(358, 108);
            this.CBNach.Name = "CBNach";
            this.CBNach.Size = new System.Drawing.Size(253, 24);
            this.CBNach.TabIndex = 2;
            this.CBNach.TextUpdate += new System.EventHandler(this.CBNach_TextUpdate);
            // 
            // CBVon
            // 
            this.CBVon.FormattingEnabled = true;
            this.CBVon.Location = new System.Drawing.Point(61, 108);
            this.CBVon.Name = "CBVon";
            this.CBVon.Size = new System.Drawing.Size(253, 24);
            this.CBVon.TabIndex = 1;
            this.CBVon.TextUpdate += new System.EventHandler(this.CBVon_TextUpdate);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(61, 251);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(550, 32);
            this.btnSuchen.TabIndex = 5;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // btnZurueckVerbindungenVonNach
            // 
            this.btnZurueckVerbindungenVonNach.Location = new System.Drawing.Point(534, 12);
            this.btnZurueckVerbindungenVonNach.Name = "btnZurueckVerbindungenVonNach";
            this.btnZurueckVerbindungenVonNach.Size = new System.Drawing.Size(75, 23);
            this.btnZurueckVerbindungenVonNach.TabIndex = 7;
            this.btnZurueckVerbindungenVonNach.Text = "Zurück";
            this.btnZurueckVerbindungenVonNach.UseVisualStyleBackColor = true;
            this.btnZurueckVerbindungenVonNach.Click += new System.EventHandler(this.btnZurueckVerbindungenVonNach_Click);
            // 
            // lVon
            // 
            this.lVon.AutoSize = true;
            this.lVon.Location = new System.Drawing.Point(58, 88);
            this.lVon.Name = "lVon";
            this.lVon.Size = new System.Drawing.Size(37, 17);
            this.lVon.TabIndex = 4;
            this.lVon.Text = "Von:";
            // 
            // lNach
            // 
            this.lNach.AutoSize = true;
            this.lNach.Location = new System.Drawing.Point(355, 88);
            this.lNach.Name = "lNach";
            this.lNach.Size = new System.Drawing.Size(45, 17);
            this.lNach.TabIndex = 5;
            this.lNach.Text = "Nach:";
            // 
            // LVTabelle
            // 
            this.LVTabelle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Von,
            this.Abfahrt,
            this.Nach,
            this.Ankunft,
            this.Gleis});
            this.LVTabelle.HideSelection = false;
            this.LVTabelle.Location = new System.Drawing.Point(60, 317);
            this.LVTabelle.Name = "LVTabelle";
            this.LVTabelle.Size = new System.Drawing.Size(549, 206);
            this.LVTabelle.TabIndex = 6;
            this.LVTabelle.UseCompatibleStateImageBehavior = false;
            this.LVTabelle.View = System.Windows.Forms.View.Details;
            // 
            // Von
            // 
            this.Von.Text = "Von";
            // 
            // Abfahrt
            // 
            this.Abfahrt.Text = "Abfahrt";
            // 
            // Nach
            // 
            this.Nach.Text = "Nach";
            // 
            // Ankunft
            // 
            this.Ankunft.Text = "Ankunft";
            // 
            // Gleis
            // 
            this.Gleis.Text = "Gleis";
            this.Gleis.Width = 82;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtUhrzeit
            // 
            this.txtUhrzeit.Location = new System.Drawing.Point(356, 191);
            this.txtUhrzeit.Name = "txtUhrzeit";
            this.txtUhrzeit.Size = new System.Drawing.Size(253, 22);
            this.txtUhrzeit.TabIndex = 4;
            // 
            // lDatum
            // 
            this.lDatum.AutoSize = true;
            this.lDatum.Location = new System.Drawing.Point(58, 169);
            this.lDatum.Name = "lDatum";
            this.lDatum.Size = new System.Drawing.Size(250, 17);
            this.lDatum.TabIndex = 9;
            this.lDatum.Text = "Geben Sie Ihr gewünschtes Datum an:";
            // 
            // lUhrzeit
            // 
            this.lUhrzeit.AutoSize = true;
            this.lUhrzeit.Location = new System.Drawing.Point(354, 169);
            this.lUhrzeit.Name = "lUhrzeit";
            this.lUhrzeit.Size = new System.Drawing.Size(255, 17);
            this.lUhrzeit.TabIndex = 10;
            this.lUhrzeit.Text = "Geben Sie Ihre gewünschte Uhrzeit an:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Verbindungen suchen";
            // 
            // VerbindungenVonNach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lUhrzeit);
            this.Controls.Add(this.lDatum);
            this.Controls.Add(this.txtUhrzeit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LVTabelle);
            this.Controls.Add(this.lNach);
            this.Controls.Add(this.lVon);
            this.Controls.Add(this.btnZurueckVerbindungenVonNach);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.CBVon);
            this.Controls.Add(this.CBNach);
            this.Name = "VerbindungenVonNach";
            this.Text = "VerbindungenVonNach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBNach;
        private System.Windows.Forms.ComboBox CBVon;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnZurueckVerbindungenVonNach;
        private System.Windows.Forms.Label lVon;
        private System.Windows.Forms.Label lNach;
        private System.Windows.Forms.ListView LVTabelle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtUhrzeit;
        private System.Windows.Forms.Label lDatum;
        private System.Windows.Forms.ColumnHeader Von;
        private System.Windows.Forms.ColumnHeader Abfahrt;
        private System.Windows.Forms.ColumnHeader Nach;
        private System.Windows.Forms.ColumnHeader Ankunft;
        private System.Windows.Forms.ColumnHeader Gleis;
        private System.Windows.Forms.Label lUhrzeit;
        private System.Windows.Forms.Label label1;
    }
}