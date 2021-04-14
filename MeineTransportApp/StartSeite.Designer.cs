
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
            this.btnKarte = new System.Windows.Forms.Button();
            this.btnVerbES = new System.Windows.Forms.Button();
            this.btnVerbSuE = new System.Windows.Forms.Button();
            this.pBice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKarte
            // 
            this.btnKarte.BackgroundImage = global::MeineTransportApp.Properties.Resources.Karte;
            this.btnKarte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKarte.ForeColor = System.Drawing.Color.Blue;
            this.btnKarte.Location = new System.Drawing.Point(576, 297);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(257, 142);
            this.btnKarte.TabIndex = 4;
            this.btnKarte.Text = "Karte";
            this.btnKarte.UseVisualStyleBackColor = true;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // btnVerbES
            // 
            this.btnVerbES.BackgroundImage = global::MeineTransportApp.Properties.Resources.EineStation5;
            this.btnVerbES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVerbES.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerbES.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerbES.ForeColor = System.Drawing.Color.Blue;
            this.btnVerbES.Location = new System.Drawing.Point(1057, 297);
            this.btnVerbES.Name = "btnVerbES";
            this.btnVerbES.Size = new System.Drawing.Size(257, 142);
            this.btnVerbES.TabIndex = 3;
            this.btnVerbES.Text = "Verbindungen von einer Station aus";
            this.btnVerbES.UseVisualStyleBackColor = true;
            this.btnVerbES.Click += new System.EventHandler(this.btnVerbES_Click);
            // 
            // btnVerbSuE
            // 
            this.btnVerbSuE.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnVerbSuE.BackgroundImage = global::MeineTransportApp.Properties.Resources.StartEnde1;
            this.btnVerbSuE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerbSuE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerbSuE.ForeColor = System.Drawing.Color.Blue;
            this.btnVerbSuE.Location = new System.Drawing.Point(62, 297);
            this.btnVerbSuE.Name = "btnVerbSuE";
            this.btnVerbSuE.Size = new System.Drawing.Size(257, 142);
            this.btnVerbSuE.TabIndex = 1;
            this.btnVerbSuE.Text = "Verbindungen zwischen Start- und Endstation";
            this.btnVerbSuE.UseVisualStyleBackColor = false;
            this.btnVerbSuE.Click += new System.EventHandler(this.btnVerbSuE_Click_1);
            // 
            // pBice
            // 
            this.pBice.BackColor = System.Drawing.SystemColors.Control;
            this.pBice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBice.Image = global::MeineTransportApp.Properties.Resources.ice;
            this.pBice.Location = new System.Drawing.Point(1, -4);
            this.pBice.Name = "pBice";
            this.pBice.Size = new System.Drawing.Size(1393, 768);
            this.pBice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBice.TabIndex = 2;
            this.pBice.TabStop = false;
            // 
            // StartSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 738);
            this.Controls.Add(this.btnKarte);
            this.Controls.Add(this.btnVerbES);
            this.Controls.Add(this.btnVerbSuE);
            this.Controls.Add(this.pBice);
            this.Name = "StartSeite";
            this.Text = "StartSeite";
            ((System.ComponentModel.ISupportInitialize)(this.pBice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerbSuE;
        private System.Windows.Forms.Button btnVerbES;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.PictureBox pBice;
    }
}

