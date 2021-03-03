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
     public partial class UitleenForm : Form
    {
        private MySqlConnection connection;
        private int selectedId = 0;

        public UitleenForm(int id)
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            selectedId = id;

            string sqlQuery = "SELECT * FROM apparaten WHERE ID = " + selectedId;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.Read())
                {
                    tbCommentaar.Text = dataReader["Commetaar"] + "";
                }
            }
            CloseConnection();
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


        public void UpdateDevice()
        {

            

            string insertquery = "UPDATE apparaten SET NaamLeerling = @NaamLeerling, LeerlingNummer = @LeerlingNummer, DatumRetour = @DatumRetour, Commetaar = @commetaar, Status = uitgeleend WHERE ID = " + selectedId + "";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(insertquery, connection);

            cmd.Parameters.Add("@NaamLeerling", MySqlDbType.VarChar, 50);
            cmd.Parameters.Add("@LeerlingNummer", MySqlDbType.VarChar, 20);
            cmd.Parameters.Add("@DatumRetour", MySqlDbType.DateTime);
            cmd.Parameters.Add("@commetaar", MySqlDbType.Text);


            cmd.Parameters["@NaamLeerling"].Value = tbNaam.Text;
            cmd.Parameters["@Leerlingnummer"].Value = tbLeerlingnummer.Text;
            cmd.Parameters["@DatumRetour"].Value = DateTime.Parse(dtpDatumRetour.Text);
            cmd.Parameters["@commetaar"].Value = tbCommentaar.Text;

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Opgeslagen");
            }
            CloseConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lvDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateDevice();
        }

        private void tbCommentaar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


  
