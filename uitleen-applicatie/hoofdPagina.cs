﻿using System;
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
    public partial class hoofdPagina : Form
    {
        private MySqlConnection connection;

        public hoofdPagina()
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

                    DateTime dateValue = DateTime.Parse(dataReader["DatumRetour"]+ "");

                    resultList[4].Add(dateValue.ToString("dd-MM-yyyy"));

                    resultList[5].Add(dataReader["ID"] + "");
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

        private void btnReload_Click(object sender, EventArgs e)
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
                    allDevices[4][i],
                    allDevices[5][i]
                }) ;

                lvDevices.Items.Add(newDeviceItem);
            }
        }
        
        private void btnUitlenenEnRetour_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedId = lvDevices.SelectedItems[0].SubItems[5].Text;
                int id = Int32.Parse(selectedId);

                string sqlQuery = "SELECT * FROM apparaten WHERE ID = " + id;

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        string status = dataReader["Status"] + "";

                        if (status == "beschikbaar")
                        {
                            UitleenForm myUitleenForm = new UitleenForm(id);
                            myUitleenForm.ShowDialog();
                        }
                        else
                        {
                            retour myRetourForm = new retour(id);
                            myRetourForm.ShowDialog();
                        }
                    }

                }
                connection.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("selecteer een apparaat" + "\r\n" + ex.Message);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {

                string selectedId = lvDevices.SelectedItems[0].SubItems[5].Text;
                int id = Int32.Parse(selectedId);

                Overzicht myOverzicht = new Overzicht(id);
                myOverzicht.ShowDialog();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("selecteer een apparaat" + "\r\n" + ex.Message);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            apparatenToevoegen openapparatenToevoegen = new apparatenToevoegen();
            openapparatenToevoegen.ShowDialog();
        }
    }
}
