﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SClab2
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void allRecordsButton_Click_1(object sender, EventArgs e)
        {
            allArtifacts(); 
        }
        
        private void allArtifacts()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
            string query = "SELECT * FROM artifacts";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
               
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                                         reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), };
                        allRecordsListBox.Items.Add(row[0] + ".  " + row[1] + "      " + row[2] + " by " + row[3] + "     " + row[4] + "      " + row[5] + "     " + row[6] + "      " + row[7] + "      " + row[8] + "       " + row[9] + "       " + row[10]);
                      // allRecordsListBox.Items.Add(row[2]);

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonTitle_Click_1(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();
            textBoxGenre.Clear();
            textBoxAuthor.Clear();
            searchByTitle(textBoxTitle.Text);
            
        }

        private void searchByTitle(string a)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
            string query = "select * from artifacts where artName ='" + a + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                                         reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), };
                        listBoxSearch.Items.Add(row[1]+"            "+row[2] + " by " + row[3]  +" is " + row[10]);
                        // allRecordsListBox.Items.Add(row[2]);

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();
            textBoxTitle.Clear();
            textBoxAuthor.Clear();
            searchByGenre(textBoxGenre.Text);
        }

        private void searchByGenre(string a)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
            string query = "select * from artifacts where genre ='" + a + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                                         reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), };
                        listBoxSearch.Items.Add(row[1] + "            " + row[5] + "       " + row[2] + " by " + row[3] + " is " + row[10]);
                        // allRecordsListBox.Items.Add(row[2]);

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();
            textBoxTitle.Clear();
            textBoxGenre.Clear();
            searchByAuthor(textBoxAuthor.Text);
        }
        
        private void searchByAuthor(string a)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=library;";
            string query = "select * from artifacts where author ='" + a + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), 
                                         reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8), reader.GetString(9), reader.GetString(10), };
                        listBoxSearch.Items.Add(row[1] + "            " + row[2] + " by " + row[3] + " is " + row[10] + "          " + row[5]);
                        // allRecordsListBox.Items.Add(row[2]);

                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
