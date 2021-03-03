
namespace uitleen_applicatie
{
    partial class Overzicht
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
            this.mainPannel = new System.Windows.Forms.Panel();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lblStatusTag = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblBeschrijvingTag = new System.Windows.Forms.Label();
            this.lblBeschrijving = new System.Windows.Forms.Label();
            this.lblCommentaarTag = new System.Windows.Forms.Label();
            this.lblCommentaar = new System.Windows.Forms.Label();
            this.lblSerieNummerTag = new System.Windows.Forms.Label();
            this.lblSerieNummer = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblNaamApparaat = new System.Windows.Forms.Label();
            this.mainPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPannel
            // 
            this.mainPannel.BackColor = System.Drawing.Color.White;
            this.mainPannel.Controls.Add(this.btnVerwijder);
            this.mainPannel.Controls.Add(this.lblStatusTag);
            this.mainPannel.Controls.Add(this.lblStatus);
            this.mainPannel.Controls.Add(this.lblBeschrijvingTag);
            this.mainPannel.Controls.Add(this.lblBeschrijving);
            this.mainPannel.Controls.Add(this.lblCommentaarTag);
            this.mainPannel.Controls.Add(this.lblCommentaar);
            this.mainPannel.Controls.Add(this.lblSerieNummerTag);
            this.mainPannel.Controls.Add(this.lblSerieNummer);
            this.mainPannel.Controls.Add(this.pbFoto);
            this.mainPannel.Controls.Add(this.lblNaamApparaat);
            this.mainPannel.Location = new System.Drawing.Point(139, 60);
            this.mainPannel.Name = "mainPannel";
            this.mainPannel.Size = new System.Drawing.Size(527, 303);
            this.mainPannel.TabIndex = 0;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijder.Location = new System.Drawing.Point(363, 242);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(150, 36);
            this.btnVerwijder.TabIndex = 1;
            this.btnVerwijder.Text = "apperaat verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lblStatusTag
            // 
            this.lblStatusTag.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTag.Location = new System.Drawing.Point(360, 174);
            this.lblStatusTag.Name = "lblStatusTag";
            this.lblStatusTag.Size = new System.Drawing.Size(153, 15);
            this.lblStatusTag.TabIndex = 9;
            this.lblStatusTag.Tag = "";
            this.lblStatusTag.Text = "status:";
            this.lblStatusTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(363, 189);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 19);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Tag = "";
            this.lblStatus.Text = "[status]";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBeschrijvingTag
            // 
            this.lblBeschrijvingTag.BackColor = System.Drawing.Color.Transparent;
            this.lblBeschrijvingTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschrijvingTag.Location = new System.Drawing.Point(9, 132);
            this.lblBeschrijvingTag.Name = "lblBeschrijvingTag";
            this.lblBeschrijvingTag.Size = new System.Drawing.Size(74, 15);
            this.lblBeschrijvingTag.TabIndex = 7;
            this.lblBeschrijvingTag.Tag = "";
            this.lblBeschrijvingTag.Text = "beschrijving:";
            // 
            // lblBeschrijving
            // 
            this.lblBeschrijving.BackColor = System.Drawing.Color.Transparent;
            this.lblBeschrijving.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBeschrijving.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeschrijving.Location = new System.Drawing.Point(12, 147);
            this.lblBeschrijving.Name = "lblBeschrijving";
            this.lblBeschrijving.Size = new System.Drawing.Size(144, 97);
            this.lblBeschrijving.TabIndex = 6;
            this.lblBeschrijving.Tag = "";
            this.lblBeschrijving.Text = "[beschrijving]";
            // 
            // lblCommentaarTag
            // 
            this.lblCommentaarTag.BackColor = System.Drawing.Color.Transparent;
            this.lblCommentaarTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaarTag.Location = new System.Drawing.Point(182, 132);
            this.lblCommentaarTag.Name = "lblCommentaarTag";
            this.lblCommentaarTag.Size = new System.Drawing.Size(74, 15);
            this.lblCommentaarTag.TabIndex = 5;
            this.lblCommentaarTag.Tag = "";
            this.lblCommentaarTag.Text = "commentaar:";
            // 
            // lblCommentaar
            // 
            this.lblCommentaar.BackColor = System.Drawing.Color.Transparent;
            this.lblCommentaar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCommentaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaar.Location = new System.Drawing.Point(185, 147);
            this.lblCommentaar.Name = "lblCommentaar";
            this.lblCommentaar.Size = new System.Drawing.Size(144, 97);
            this.lblCommentaar.TabIndex = 4;
            this.lblCommentaar.Tag = "";
            this.lblCommentaar.Text = "[commentaar]";
            // 
            // lblSerieNummerTag
            // 
            this.lblSerieNummerTag.BackColor = System.Drawing.Color.Transparent;
            this.lblSerieNummerTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerieNummerTag.Location = new System.Drawing.Point(9, 90);
            this.lblSerieNummerTag.Name = "lblSerieNummerTag";
            this.lblSerieNummerTag.Size = new System.Drawing.Size(74, 15);
            this.lblSerieNummerTag.TabIndex = 3;
            this.lblSerieNummerTag.Tag = "";
            this.lblSerieNummerTag.Text = "serie nummer:";
            // 
            // lblSerieNummer
            // 
            this.lblSerieNummer.BackColor = System.Drawing.Color.Transparent;
            this.lblSerieNummer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSerieNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerieNummer.Location = new System.Drawing.Point(12, 105);
            this.lblSerieNummer.Name = "lblSerieNummer";
            this.lblSerieNummer.Size = new System.Drawing.Size(144, 16);
            this.lblSerieNummer.TabIndex = 2;
            this.lblSerieNummer.Tag = "";
            this.lblSerieNummer.Text = "[serie nummer]";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(363, 21);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 150);
            this.pbFoto.TabIndex = 1;
            this.pbFoto.TabStop = false;
            // 
            // lblNaamApparaat
            // 
            this.lblNaamApparaat.BackColor = System.Drawing.Color.Transparent;
            this.lblNaamApparaat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaamApparaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaamApparaat.Location = new System.Drawing.Point(12, 21);
            this.lblNaamApparaat.Name = "lblNaamApparaat";
            this.lblNaamApparaat.Size = new System.Drawing.Size(244, 69);
            this.lblNaamApparaat.TabIndex = 0;
            this.lblNaamApparaat.Text = "[naam]";
            // 
            // Overzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPannel);
            this.Name = "Overzicht";
            this.Text = "overzicht";
            this.mainPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPannel;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblNaamApparaat;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label lblStatusTag;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblBeschrijvingTag;
        private System.Windows.Forms.Label lblBeschrijving;
        private System.Windows.Forms.Label lblCommentaarTag;
        private System.Windows.Forms.Label lblCommentaar;
        private System.Windows.Forms.Label lblSerieNummerTag;
        private System.Windows.Forms.Label lblSerieNummer;
    }
}