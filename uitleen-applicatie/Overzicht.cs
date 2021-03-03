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
    public partial class Overzicht : Form
    {

        private MySqlConnection connection;
        private int selectedId = 0;


        public Overzicht(int id)
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
                    lblNaamApparaat.Text = dataReader["Naam"] + "";
                    lblSerieNummer.Text = dataReader["SerieNummer"] + "";
                    lblBeschrijving.Text = dataReader["Beschrijving"] + "";
                    lblCommentaar.Text = dataReader["commetaar"] + "";
                    lblStatus.Text = "[" + dataReader["Status"] + "]";
                    lblDatumRetour.Text = "Datum Retour: " + dataReader["DatumRetour"];
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

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            string sqlQuery = "DELETE FROM apparaten WHERE ID = " + selectedId;

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                cmd.ExecuteNonQuery();

            }
            CloseConnection();

            Close();
        }
    }
}
