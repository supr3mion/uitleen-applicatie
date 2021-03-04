
namespace uitleen_applicatie
{
    partial class hoofdPagina
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUitlenenEnRetour = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
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
            this.lvDevices.FullRowSelect = true;
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
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(608, 401);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+ Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(12, 401);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(180, 37);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Herladen";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnUitlenenEnRetour
            // 
            this.btnUitlenenEnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUitlenenEnRetour.Location = new System.Drawing.Point(342, 401);
            this.btnUitlenenEnRetour.Name = "btnUitlenenEnRetour";
            this.btnUitlenenEnRetour.Size = new System.Drawing.Size(260, 37);
            this.btnUitlenenEnRetour.TabIndex = 3;
            this.btnUitlenenEnRetour.Text = "Uitlenen of Retourneren";
            this.btnUitlenenEnRetour.UseVisualStyleBackColor = true;
            this.btnUitlenenEnRetour.Click += new System.EventHandler(this.btnUitlenenEnRetour_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(198, 401);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(138, 37);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "meer details";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // hoofdPagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnUitlenenEnRetour);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvDevices);
            this.Name = "hoofdPagina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDevices;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader SerieNummer;
        private System.Windows.Forms.ColumnHeader Beschrijving;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader DatumRetour;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnUitlenenEnRetour;
        private System.Windows.Forms.Button btnDetail;
    }
}

