
namespace uitleen_applicatie
{
    partial class Form1
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
            this.lvDevices = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerieNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Beschrijving = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.btnUitlenen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDevices
            // 
            this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.SerieNummer,
            this.Beschrijving,
            this.Status,
            this.DatumRetour});
            this.lvDevices.HideSelection = false;
            this.lvDevices.Location = new System.Drawing.Point(12, 12);
            this.lvDevices.Name = "lvDevices";
            this.lvDevices.Size = new System.Drawing.Size(776, 371);
            this.lvDevices.TabIndex = 0;
            this.lvDevices.UseCompatibleStateImageBehavior = false;
            this.lvDevices.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 122;
            // 
            // SerieNummer
            // 
            this.SerieNummer.Text = "Serie nummer";
            this.SerieNummer.Width = 125;
            // 
            // Beschrijving
            // 
            this.Beschrijving.Text = "Beschrijving";
            this.Beschrijving.Width = 299;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 107;
            // 
            // DatumRetour
            // 
            this.DatumRetour.Text = "Datum van retour";
            this.DatumRetour.Width = 119;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(608, 401);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(180, 37);
            this.add.TabIndex = 1;
            this.add.Text = "+ Toevoegen";
            this.add.UseVisualStyleBackColor = true;
            // 
            // reload
            // 
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reload.Location = new System.Drawing.Point(12, 401);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(180, 37);
            this.reload.TabIndex = 2;
            this.reload.Text = "Herladen";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // btnUitlenen
            // 
            this.btnUitlenen.Location = new System.Drawing.Point(486, 401);
            this.btnUitlenen.Name = "btnUitlenen";
            this.btnUitlenen.Size = new System.Drawing.Size(100, 37);
            this.btnUitlenen.TabIndex = 3;
            this.btnUitlenen.Text = "Uitlenen";
            this.btnUitlenen.UseVisualStyleBackColor = true;
            this.btnUitlenen.Click += new System.EventHandler(this.btnUitlenen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUitlenen);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lvDevices);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader SerieNummer;
        private System.Windows.Forms.ColumnHeader Beschrijving;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader DatumRetour;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button reload;
        private System.Windows.Forms.Button btnUitlenen;
    }
}

