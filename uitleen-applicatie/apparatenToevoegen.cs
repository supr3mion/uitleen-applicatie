using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace uitleen_applicatie
{
    public partial class apparatenToevoegen : Form
    {
        
         private MySqlConnection connection;

        public apparatenToevoegen()
        {
            InitializeComponent();

            InitializeDatabaseConnection();
        }


        private void InitializeDatabaseConnection()
        {
            string server = "localhost";
            string database = "FriesePoort";
            string dbUsername = "root";
            string dbPassword = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string insertquery = "INSERT INTO friesepoort.apparaten(Naam, SerieNummer, Beschrijving, DatumRetour, Status, Foto) " +
                "VALUES(@Naam, @SerieNummer, @Beschrijving, @DatumRetour, 'beschikbaar', @FotoID)";
            
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(insertquery, connection);

            cmd.Parameters.Add("@Naam", MySqlDbType.VarChar,50);
            cmd.Parameters.Add("@SerieNummer", MySqlDbType.Int32,225);
            cmd.Parameters.Add("@Beschrijving", MySqlDbType.Text);
            cmd.Parameters.Add("@DatumRetour", MySqlDbType.DateTime);
            cmd.Parameters.Add("@FotoID", MySqlDbType.Int32,225);



            cmd.Parameters["@naam"].Value = txbNaam.Text;
            cmd.Parameters["@SerieNummer"].Value = Int32.Parse(txbSerieNummer.Text);
            cmd.Parameters["@Beschrijving"].Value = txbBeschrijving.Text;
            cmd.Parameters["@DatumRetour"].Value = DateTime.Now;
            cmd.Parameters["@FotoID"].Value = Int32.Parse(txbSerieNummer.Text);

            string imgPath1 = @"D:\device-images";
            string imgPath2 = @"C:\device-images";


            if (!Directory.Exists(imgPath1) || !Directory.Exists(imgPath2))
            {
                try
                {
                    Directory.CreateDirectory(imgPath1);
                    File.Copy(lblTest.Text, @"D:\device-images\" + Int32.Parse(txbSerieNummer.Text) + ".png");
                } 
                catch(Exception ex)
                {
                    Directory.CreateDirectory(imgPath2);
                    File.Copy(lblTest.Text, @"C:\device-images\" + Int32.Parse(txbSerieNummer.Text) + ".png");
                }
            }
            else
            {
                try
                {
                    File.Copy(lblTest.Text, @"D:\device-images\" + Int32.Parse(txbSerieNummer.Text) + ".png");
                }
                catch (Exception ex)
                {
                    File.Copy(lblTest.Text, @"C:\device-images\" + Int32.Parse(txbSerieNummer.Text) + ".png");
                }

            }

            if (cmd.ExecuteNonQuery()== 1)
            {
                MessageBox.Show("Opgeslagen");
            }
            connection.Close();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "kies afbeelding(*.jpg; *.png;)|*.jpg; *.png;";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                lblTest.Text = opf.FileName;
            }
        }


    }
}
