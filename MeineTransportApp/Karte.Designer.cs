
namespace MeineTransportApp
{
    partial class Karte
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
            this.btnZurueckKarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZurueckKarte
            // 
            this.btnZurueckKarte.Location = new System.Drawing.Point(713, 12);
            this.btnZurueckKarte.Name = "btnZurueckKarte";
            this.btnZurueckKarte.Size = new System.Drawing.Size(75, 23);
            this.btnZurueckKarte.TabIndex = 0;
            this.btnZurueckKarte.Text = "Zurück";
            this.btnZurueckKarte.UseVisualStyleBackColor = true;
            this.btnZurueckKarte.Click += new System.EventHandler(this.btnZurueckKarte_Click);
            // 
            // Karte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZurueckKarte);
            this.Name = "Karte";
            this.Text = "Karte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZurueckKarte;
    }
}