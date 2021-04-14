
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
            this.SuspendLayout();
            // 
            // CBNach
            // 
            this.CBNach.FormattingEnabled = true;
            this.CBNach.Location = new System.Drawing.Point(272, 118);
            this.CBNach.Name = "CBNach";
            this.CBNach.Size = new System.Drawing.Size(182, 24);
            this.CBNach.TabIndex = 0;
            // 
            // CBVon
            // 
            this.CBVon.FormattingEnabled = true;
            this.CBVon.Location = new System.Drawing.Point(61, 118);
            this.CBVon.Name = "CBVon";
            this.CBVon.Size = new System.Drawing.Size(182, 24);
            this.CBVon.TabIndex = 1;
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(61, 165);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(393, 23);
            this.btnSuchen.TabIndex = 2;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            // 
            // btnZurueckVerbindungenVonNach
            // 
            this.btnZurueckVerbindungenVonNach.Location = new System.Drawing.Point(713, 12);
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
            this.lVon.Location = new System.Drawing.Point(58, 79);
            this.lVon.Name = "lVon";
            this.lVon.Size = new System.Drawing.Size(46, 21);
            this.lVon.TabIndex = 4;
            this.lVon.Text = "Von:";
            // 
            // lNach
            // 
            this.lNach.AutoSize = true;
            this.lNach.Location = new System.Drawing.Point(269, 79);
            this.lNach.Name = "lNach";
            this.lNach.Size = new System.Drawing.Size(56, 21);
            this.lNach.TabIndex = 5;
            this.lNach.Text = "Nach:";
            // 
            // VerbindungenVonNach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lNach);
            this.Controls.Add(this.lVon);
            this.Controls.Add(this.btnZurueckVerbindungenVonNach);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.CBVon);
            this.Controls.Add(this.CBNach);
            this.Name = "VerbindungenVonNach";
            this.Text = "VerbindungenVonNach";
            this.Load += new System.EventHandler(this.VerbindungenVonNach_Load);
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
    }
}