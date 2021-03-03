using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace snake_game
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }
        // declare variable for database connection 
        MySqlConnection myConn;

        // declare data table object
        private DataTable dTable = new DataTable();

        

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            // create and use database form to get database
            // connection details
            DatabaseForm databaseFrm = new DatabaseForm();

           

            // create connection string for particular database
            // (from database form)
            string connStr = DatabaseForm.sConnStr;

            // create connecting
            myConn = new MySqlConnection(connStr);

            // create query string to display all records
            //initially
            string sQuery = "SELECT * FROM snakegame";

            // Call helper function to load data
            updateDataGrid(sQuery);

            // Fill datagrid
            dgvsnakegame.DataSource = dTable;


            dgvsnakegame.Columns[0].HeaderText = "playerid";
            dgvsnakegame.Columns[1].HeaderText = "firstname";
            dgvsnakegame.Columns[2].HeaderText = "surname";
            dgvsnakegame.Columns[3].HeaderText = "duration";
            dgvsnakegame.Columns[4].HeaderText = "gamescored";


            dgvsnakegame.Columns[0].ReadOnly = true;
        }
        // declare class-level variable to act as row pointer
        private int rowIndex;
        public void UpdateTextBoxes()
        {
           
            
        }
      
        private void btnsearch_Click(object sender, EventArgs e)
        {
              string sQuery;
            sQuery = "SELECT * FROM snakegame WHERE firstname like '%" + lblfirstname.Text + "%'";
            updateDataGrid(sQuery);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
             // create a data adapter object with the specified
            // connection and query

            MySqlDataAdapter dAdapter = new MySqlDataAdapter("SELECT * FROM snakegame", myConn);

            // create a command builder and attach it to the data
            // adapter
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder (dAdapter);

            // update the data adapter with the modified table
            // data
            int iRowsAffected = dAdapter.Update(dTable);
            dAdapter.Dispose();

            

            if (iRowsAffected > 0)
            {
                // update datagrid so newly created catalog id is 
                // displayed if rows are added
                string sQuery = "SELECT * FROM snakegame";
                updateDataGrid(sQuery);
                
                MessageBox.Show(iRowsAffected + " Rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No rows modified", "Data Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void updateDataGrid(string psQuery)
        {

            dTable.Clear();

            // create and execute the query on the database
            MySqlDataAdapter dAdapter = new MySqlDataAdapter(psQuery, myConn);

            // fill the data table
            dAdapter.Fill(dTable);

            // close the connection
            dAdapter.Dispose();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // create a new row and add data
            DataRow dr = dTable.NewRow();
            dr["firstname"] = txtfirstnames.Text;
           
            // add row to table
            dTable.Rows.Add(dr);
        }

        

        public class scoreboard
        {
            public string susername;
            public int iscore;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //show the previous record if the current one is 
            // not the first
            if (rowIndex > 0)
            {
                rowIndex = rowIndex - 1; // decrease rowIndex by 1
                    UpdateTextBoxes();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //show the previous record if the current one is 
            // not the last
            if (rowIndex < dTable.Rows.Count - 1)
            {
                rowIndex += 1; // increase rowIndex by 1
                UpdateTextBoxes();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            exit.Show();
            this.Hide();
        }

        private void btnPlayagain_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            exit.Show();
            this.Hide();
        }

        

        

     }

 }

  