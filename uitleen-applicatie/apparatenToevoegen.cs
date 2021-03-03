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
            string insertquery = "INSERT INTO friesepoort.apparaten(Naam, SerieNummer, Beschrijving) VALUES(@Naam, @SerieNummer, @Beschrijving)";
            
            connection.Open();

            MySqlCommand cmd = new MySqlCommand(insertquery, connection);

            cmd.Parameters.Add("@Naam", MySqlDbType.VarChar,50);
            cmd.Parameters.Add("@SerieNummer", MySqlDbType.Int32,225);
            cmd.Parameters.Add("@Beschrijving", MySqlDbType.Text, 50);
           
            
            cmd.Parameters["@naam"].Value = txbNaam;
            cmd.Parameters["@SerieNummer"].Value = txbSerieNummer;
            cmd.Parameters["@Beschrijving"].Value = txbBeschrijving;

            if (cmd.ExecuteNonQuery()== 1)
            {
                MessageBox.Show("Verstuurd");
            }
            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "kies afbeelding(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
