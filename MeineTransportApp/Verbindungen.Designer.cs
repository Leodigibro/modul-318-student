
namespace MeineTransportApp
{
    partial class Verbindungen
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
            this.SuspendLayout();
            // 
            // CBNach
            // 
            this.CBNach.FormattingEnabled = true;
            this.CBNach.Location = new System.Drawing.Point(202, 155);
            this.CBNach.Name = "CBNach";
            this.CBNach.Size = new System.Drawing.Size(121, 24);
            this.CBNach.TabIndex = 0;
            // 
            // CBVon
            // 
            this.CBVon.FormattingEnabled = true;
            this.CBVon.Location = new System.Drawing.Point(55, 155);
            this.CBVon.Name = "CBVon";
            this.CBVon.Size = new System.Drawing.Size(121, 24);
            this.CBVon.TabIndex = 1;
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(403, 155);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(75, 23);
            this.btnSuchen.TabIndex = 2;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.CBVon);
            this.Controls.Add(this.CBNach);
            this.Name = "Verbindungen";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBNach;
        private System.Windows.Forms.ComboBox CBVon;
        private System.Windows.Forms.Button btnSuchen;
    }
}