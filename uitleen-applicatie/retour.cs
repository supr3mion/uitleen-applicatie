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
    public partial class retour : Form
    {

        private MySqlConnection connection;
        private int selectedId = 0;

        public retour(int id)
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
                    tbCommentaar.Text = dataReader["commetaar"] + "";
                }

            }
            connection.Close();
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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            string updatequery = "UPDATE apparaten SET Commetaar = @commetaar, Status = 'beschikbaar' WHERE ID = " + selectedId + "";

            connection.Open();

            MySqlCommand cmd = new MySqlCommand(updatequery, connection);

            cmd.Parameters.Add("@commetaar", MySqlDbType.Text);

            cmd.Parameters["@commetaar"].Value = tbCommentaar.Text;

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("geretourneerd");
            }

            CloseConnection();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
