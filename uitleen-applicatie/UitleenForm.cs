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
     public partial class UitleenForm : Form
    {
        private MySqlConnection connection;

        public UitleenForm()
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

                //this.CloseConnection();

                return resultList;
            }
            else
            {
                return resultList;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lvDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
        }
    }
}


  
