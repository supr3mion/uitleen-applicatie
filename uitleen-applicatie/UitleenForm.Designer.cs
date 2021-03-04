
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
            this.tbCommentaar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpDatumRetour = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLeerlingnummer
            // 
            this.tbLeerlingnummer.AccessibleName = "tbLeerlingnummer";
            this.tbLeerlingnummer.Location = new System.Drawing.Point(319, 110);
            this.tbLeerlingnummer.Margin = new System.Windows.Forms.Padding(2);
            this.tbLeerlingnummer.Name = "tbLeerlingnummer";
            this.tbLeerlingnummer.Size = new System.Drawing.Size(100, 20);
            this.tbLeerlingnummer.TabIndex = 2;
            // 
            // Textlbl
            // 
            this.Textlbl.AutoSize = true;
            this.Textlbl.Location = new System.Drawing.Point(343, 65);
            this.Textlbl.Name = "Textlbl";
            this.Textlbl.Size = new System.Drawing.Size(48, 13);
            this.Textlbl.TabIndex = 3;
            this.Textlbl.Text = "Uillenen:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(319, 86);
            this.tbNaam.Margin = new System.Windows.Forms.Padding(2);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 4;
            // 
            // tbCommentaar
            // 
            this.tbCommentaar.Location = new System.Drawing.Point(251, 178);
            this.tbCommentaar.Multiline = true;
            this.tbCommentaar.Name = "tbCommentaar";
            this.tbCommentaar.Size = new System.Drawing.Size(246, 157);
            this.tbCommentaar.TabIndex = 6;
            this.tbCommentaar.TextChanged += new System.EventHandler(this.tbCommentaar_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(251, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sluiten";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(409, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Opslaan";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpDatumRetour
            // 
            this.dtpDatumRetour.Location = new System.Drawing.Point(273, 135);
            this.dtpDatumRetour.Name = "dtpDatumRetour";
            this.dtpDatumRetour.Size = new System.Drawing.Size(191, 20);
            this.dtpDatumRetour.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "leerlingnummer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "naam leerling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "commentaar:";
            // 
            // UitleenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumRetour);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCommentaar);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.Textlbl);
            this.Controls.Add(this.tbLeerlingnummer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UitleenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uitlenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLeerlingnummer;
        private System.Windows.Forms.Label Textlbl;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbCommentaar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpDatumRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}