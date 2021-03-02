
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Textlbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbCommentaar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(319, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "   Leerlingnummer:";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "    Naam Leerling:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(319, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = " Datum van Retour:";
            // 
            // tbCommentaar
            // 
            this.tbCommentaar.Location = new System.Drawing.Point(251, 159);
            this.tbCommentaar.Multiline = true;
            this.tbCommentaar.Name = "tbCommentaar";
            this.tbCommentaar.Size = new System.Drawing.Size(246, 157);
            this.tbCommentaar.TabIndex = 6;
            this.tbCommentaar.Text = "                             Commetaar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UitleenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCommentaar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Textlbl);
            this.Controls.Add(this.textBox1);
            this.Name = "UitleenForm";
            this.Text = "UitleenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Textlbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbCommentaar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}