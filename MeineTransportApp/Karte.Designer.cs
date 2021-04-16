
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
            this.btnSuchen = new System.Windows.Forms.Button();
            this.lKarte = new System.Windows.Forms.Label();
            this.lOrt = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnZurueckKarte
            // 
            this.btnZurueckKarte.Location = new System.Drawing.Point(306, 22);
            this.btnZurueckKarte.Name = "btnZurueckKarte";
            this.btnZurueckKarte.Size = new System.Drawing.Size(75, 23);
            this.btnZurueckKarte.TabIndex = 3;
            this.btnZurueckKarte.Text = "Zurück";
            this.btnZurueckKarte.UseVisualStyleBackColor = true;
            this.btnZurueckKarte.Click += new System.EventHandler(this.btnZurueckKarte_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(54, 132);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(327, 23);
            this.btnSuchen.TabIndex = 2;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // lKarte
            // 
            this.lKarte.AutoSize = true;
            this.lKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKarte.Location = new System.Drawing.Point(48, 12);
            this.lKarte.Name = "lKarte";
            this.lKarte.Size = new System.Drawing.Size(88, 32);
            this.lKarte.TabIndex = 13;
            this.lKarte.Text = "Karte";
            // 
            // lOrt
            // 
            this.lOrt.AutoSize = true;
            this.lOrt.Location = new System.Drawing.Point(51, 80);
            this.lOrt.Name = "lOrt";
            this.lOrt.Size = new System.Drawing.Size(249, 17);
            this.lOrt.TabIndex = 14;
            this.lOrt.Text = "Geben Sie Ihren gewünschten Ort ein:";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(54, 104);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(327, 22);
            this.txtStation.TabIndex = 1;
            // 
            // Karte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 233);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.lOrt);
            this.Controls.Add(this.lKarte);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnZurueckKarte);
            this.Name = "Karte";
            this.Text = "Karte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZurueckKarte;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label lKarte;
        private System.Windows.Forms.Label lOrt;
        private System.Windows.Forms.TextBox txtStation;
    }
}