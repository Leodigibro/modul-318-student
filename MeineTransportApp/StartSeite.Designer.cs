
namespace MeineTransportApp
{
    partial class StartSeite
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerbSuE = new System.Windows.Forms.Button();
            this.btnVerbES = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerbSuE
            // 
            this.btnVerbSuE.Location = new System.Drawing.Point(12, 253);
            this.btnVerbSuE.Name = "btnVerbSuE";
            this.btnVerbSuE.Size = new System.Drawing.Size(193, 104);
            this.btnVerbSuE.TabIndex = 1;
            this.btnVerbSuE.Text = "Verbindungen zwischen Start- und Endstation";
            this.btnVerbSuE.UseVisualStyleBackColor = true;
            this.btnVerbSuE.Click += new System.EventHandler(this.btnVerbSuE_Click_1);
            // 
            // btnVerbES
            // 
            this.btnVerbES.Location = new System.Drawing.Point(900, 253);
            this.btnVerbES.Name = "btnVerbES";
            this.btnVerbES.Size = new System.Drawing.Size(193, 104);
            this.btnVerbES.TabIndex = 3;
            this.btnVerbES.Text = "Verbindungen von einer Station aus";
            this.btnVerbES.UseVisualStyleBackColor = true;
            // 
            // btnKarte
            // 
            this.btnKarte.Location = new System.Drawing.Point(464, 253);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(193, 104);
            this.btnKarte.TabIndex = 4;
            this.btnKarte.Text = "Stationen auf der Karte sehen";
            this.btnKarte.UseVisualStyleBackColor = true;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::MeineTransportApp.Properties.Resources.ice;
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1106, 640);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // StartSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 635);
            this.Controls.Add(this.btnKarte);
            this.Controls.Add(this.btnVerbES);
            this.Controls.Add(this.btnVerbSuE);
            this.Controls.Add(this.pictureBox1);
            this.Name = "StartSeite";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerbSuE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerbES;
        private System.Windows.Forms.Button btnKarte;
    }
}

