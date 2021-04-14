
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtUhrzeit = new System.Windows.Forms.TextBox();
            this.lZeit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBNach
            // 
            this.CBNach.FormattingEnabled = true;
            this.CBNach.Location = new System.Drawing.Point(357, 72);
            this.CBNach.Name = "CBNach";
            this.CBNach.Size = new System.Drawing.Size(253, 24);
            this.CBNach.TabIndex = 0;
            // 
            // CBVon
            // 
            this.CBVon.FormattingEnabled = true;
            this.CBVon.Location = new System.Drawing.Point(61, 72);
            this.CBVon.Name = "CBVon";
            this.CBVon.Size = new System.Drawing.Size(253, 24);
            this.CBVon.TabIndex = 1;
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(61, 194);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(549, 32);
            this.btnSuchen.TabIndex = 2;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // btnZurueckVerbindungenVonNach
            // 
            this.btnZurueckVerbindungenVonNach.Location = new System.Drawing.Point(535, 12);
            this.btnZurueckVerbindungenVonNach.Name = "btnZurueckVerbindungenVonNach";
            this.btnZurueckVerbindungenVonNach.Size = new System.Drawing.Size(75, 23);
            this.btnZurueckVerbindungenVonNach.TabIndex = 3;
            this.btnZurueckVerbindungenVonNach.Text = "Zurück";
            this.btnZurueckVerbindungenVonNach.UseVisualStyleBackColor = true;
            this.btnZurueckVerbindungenVonNach.Click += new System.EventHandler(this.btnZurueckVerbindungenVonNach_Click);
            // 
            // lVon
            // 
            this.lVon.AutoSize = true;
            this.lVon.Location = new System.Drawing.Point(58, 43);
            this.lVon.Name = "lVon";
            this.lVon.Size = new System.Drawing.Size(37, 17);
            this.lVon.TabIndex = 4;
            this.lVon.Text = "Von:";
            // 
            // lNach
            // 
            this.lNach.AutoSize = true;
            this.lNach.Location = new System.Drawing.Point(354, 43);
            this.lNach.Name = "lNach";
            this.lNach.Size = new System.Drawing.Size(45, 17);
            this.lNach.TabIndex = 5;
            this.lNach.Text = "Nach:";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(61, 268);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 206);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(253, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtUhrzeit
            // 
            this.txtUhrzeit.Location = new System.Drawing.Point(357, 147);
            this.txtUhrzeit.Name = "txtUhrzeit";
            this.txtUhrzeit.Size = new System.Drawing.Size(253, 22);
            this.txtUhrzeit.TabIndex = 8;
            this.txtUhrzeit.TextChanged += new System.EventHandler(this.txtUhrzeit_TextChanged);
            // 
            // lZeit
            // 
            this.lZeit.AutoSize = true;
            this.lZeit.Location = new System.Drawing.Point(58, 121);
            this.lZeit.Name = "lZeit";
            this.lZeit.Size = new System.Drawing.Size(234, 17);
            this.lZeit.TabIndex = 9;
            this.lZeit.Text = "Geben Sie Ihre gewünschte Zeit an:";
            // 
            // VerbindungenVonNach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 518);
            this.Controls.Add(this.lZeit);
            this.Controls.Add(this.txtUhrzeit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtUhrzeit;
        private System.Windows.Forms.Label lZeit;
    }
}