
namespace uitleen_applicatie
{
    partial class apparatenToevoegen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNaam = new System.Windows.Forms.TextBox();
            this.txbSerieNummer = new System.Windows.Forms.TextBox();
            this.txbBeschrijving = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(464, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "apparatuur :";
            // 
            // txbNaam
            // 
            this.txbNaam.Location = new System.Drawing.Point(472, 205);
            this.txbNaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNaam.Multiline = true;
            this.txbNaam.Name = "txbNaam";
            this.txbNaam.Size = new System.Drawing.Size(214, 33);
            this.txbNaam.TabIndex = 1;
            this.txbNaam.Text = "    naam apparatuur:\r\n\r\n\r\n";
            // 
            // txbSerieNummer
            // 
            this.txbSerieNummer.Location = new System.Drawing.Point(472, 264);
            this.txbSerieNummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSerieNummer.Multiline = true;
            this.txbSerieNummer.Name = "txbSerieNummer";
            this.txbSerieNummer.Size = new System.Drawing.Size(214, 33);
            this.txbSerieNummer.TabIndex = 2;
            this.txbSerieNummer.Text = "      serie nummer:\r\n\r\n\r\n";
            // 
            // txbBeschrijving
            // 
            this.txbBeschrijving.Location = new System.Drawing.Point(472, 330);
            this.txbBeschrijving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbBeschrijving.Multiline = true;
            this.txbBeschrijving.Name = "txbBeschrijving";
            this.txbBeschrijving.Size = new System.Drawing.Size(382, 182);
            this.txbBeschrijving.TabIndex = 3;
            this.txbBeschrijving.Text = "beschrijving:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.Location = new System.Drawing.Point(472, 740);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "annuleren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button2.Location = new System.Drawing.Point(800, 740);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "opslaan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(976, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button3.Location = new System.Drawing.Point(472, 592);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(354, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "kies afbeelding ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // apparatenToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbBeschrijving);
            this.Controls.Add(this.txbSerieNummer);
            this.Controls.Add(this.txbNaam);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "apparatenToevoegen";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNaam;
        private System.Windows.Forms.TextBox txbSerieNummer;
        private System.Windows.Forms.TextBox txbBeschrijving;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}