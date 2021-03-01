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
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
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

        public List<string>[] GetAllDevices()
        {
            string sqlQuery = "SELECT * FROM apparaten";

            List<string>[] resultList = new List<string>[6];
            resultList[0] = new List<string>();
            resultList[1] = new List<string>();
            resultList[2] = new List<string>();
            resultList[3] = new List<string>();
            resultList[4] = new List<string>();
            resultList[5] = new List<string>();

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    resultList[0].Add(dataReader["Naam"] + "");
                    resultList[1].Add(dataReader["SerieNummer"] + "");
                    resultList[2].Add(dataReader["Beschrijving"] + "");
                    resultList[3].Add(dataReader["Status"] + "");
                    resultList[4].Add(dataReader["DatumRetour"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return resultList;
            }
            else
            {
                return resultList;
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            lvDevices.Items.Clear();

            List<string>[] allDevices = GetAllDevices();

            for (int i = 0; i < allDevices[0].Count; i++)
            {
                ListViewItem newDeviceItem = new ListViewItem(new string[]
                {
                    allDevices[0][i],
                    allDevices[1][i],
                    allDevices[2][i],
                    allDevices[3][i],
                    allDevices[4][i]
                });

                lvDevices.Items.Add(newDeviceItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lvDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string selectedItem = lvDevices.SelectedItems[0].ToString();
                MessageBox.Show(selectedItem.ToString());

        }
    }
}
