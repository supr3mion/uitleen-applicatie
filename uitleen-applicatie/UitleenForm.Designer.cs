
namespace uitleen_applicatie
{
    partial class UitleenForm
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
            this.tbLeerlingnummer = new System.Windows.Forms.TextBox();
            this.Textlbl = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.tbCommentaar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLeerlingnummer
            // 
            this.tbLeerlingnummer.AccessibleName = "tbLeerlingnummer";
            this.tbLeerlingnummer.Location = new System.Drawing.Point(319, 81);
            this.tbLeerlingnummer.Name = "tbLeerlingnummer";
            this.tbLeerlingnummer.Size = new System.Drawing.Size(100, 20);
            this.tbLeerlingnummer.TabIndex = 2;
            this.tbLeerlingnummer.Text = "   Leerlingnummer:";
            // 
            // Textlbl
            // 
            this.Textlbl.AutoSize = true;
            this.Textlbl.Location = new System.Drawing.Point(686, 125);
            this.Textlbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Textlbl.Name = "Textlbl";
            this.Textlbl.Size = new System.Drawing.Size(96, 25);
            this.Textlbl.TabIndex = 3;
            this.Textlbl.Text = "Uillenen:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(319, 107);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 4;
            this.tbNaam.Text = "    Naam Leerling:";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(319, 133);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.Size = new System.Drawing.Size(100, 20);
            this.tbDatum.TabIndex = 5;
            this.tbDatum.Text = " Datum van Retour:";
            // 
            // tbCommentaar
            // 
            this.tbCommentaar.Location = new System.Drawing.Point(502, 306);
            this.tbCommentaar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbCommentaar.Multiline = true;
            this.tbCommentaar.Name = "tbCommentaar";
            this.tbCommentaar.Size = new System.Drawing.Size(488, 298);
            this.tbCommentaar.TabIndex = 6;
            this.tbCommentaar.Text = "                             Commetaar:";
            this.tbCommentaar.TextChanged += new System.EventHandler(this.tbCommentaar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(810, 717);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 717);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UitleenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCommentaar);
            this.Controls.Add(this.tbDatum);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.Textlbl);
            this.Controls.Add(this.tbLeerlingnummer);
            this.Name = "UitleenForm";
            this.Text = "UitleenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLeerlingnummer;
        private System.Windows.Forms.Label Textlbl;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.TextBox tbCommentaar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}