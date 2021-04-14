
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnZurueckVerbindungen1Station = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // btnZurueckVerbindungen1Station
            // 
            this.btnZurueckVerbindungen1Station.Location = new System.Drawing.Point(713, 12);
            this.btnZurueckVerbindungen1Station.Name = "btnZurueckVerbindungen1Station";
            this.btnZurueckVerbindungen1Station.Size = new System.Drawing.Size(75, 23);
            this.btnZurueckVerbindungen1Station.TabIndex = 1;
            this.btnZurueckVerbindungen1Station.Text = "Zurück";
            this.btnZurueckVerbindungen1Station.UseVisualStyleBackColor = true;
            this.btnZurueckVerbindungen1Station.Click += new System.EventHandler(this.btnZurueckVerbindungen1Station_Click);
            // 
            // Verbindungen1Station
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZurueckVerbindungen1Station);
            this.Controls.Add(this.comboBox1);
            this.Name = "Verbindungen1Station";
            this.Text = "Verbindungen1Station";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnZurueckVerbindungen1Station;
    }
}