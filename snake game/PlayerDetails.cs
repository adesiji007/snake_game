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
using System.IO;

namespace snake_game
{
    public partial class PlayerDetails : Form
    {
        public PlayerDetails()
        {
            InitializeComponent();
        }

        public static string firstname = "";
        public static string surname = "";

        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
             // select loan table into new table/adapter
            MySqlDataAdapter dAdapter = new MySqlDataAdapter(" SELECT * FROM snakegame", myConn);

            DataTable dTable = new DataTable();

            dAdapter.Fill(dTable);

            // create a new row and add data
            // Leave LoanId field empty as this auto-increaments
            DataRow dr = dTable.NewRow();

            dr["surname"] = txtsurname.Text;
            dr["firstname"] = txtfirstname.Text;
            

            // add row to table
            dTable.Rows.Add(dr);

            // set up command builder and upgrade adapter to save data
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapter);

            int iRowsAffected = dAdapter.Update(dTable);

            if (iRowsAffected == 1)
            {
                MessageBox.Show(txtfirstname.Text + "" + txtsurname.Text + " Your name is now " + "", "Record Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error adding record", "Record Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



           
          
           this.Close();
        }

        


        private void btnOK_Click(object sender, EventArgs e)
        {
            //close form and return to ScoreboardForm
            this.Close();
        }


        // declare variable for database connection 
        MySqlConnection myConn;

        // declare data table object
        private DataTable dTable = new DataTable();
        private void PlayerDetails_Load(object sender, EventArgs e)
        {
            // create and use database form  to get database
            // connection details
            DatabaseForm databaseFrm = new DatabaseForm();


            // create connection string for particular database
            // (from database form)

            string connStr = DatabaseForm.sConnStr;
            myConn = new MySqlConnection(connStr);

            // create a query string
            string sqlStr = "SELECT * FROM snakegame";

            // create a data adapter object with the specified
            // connection and query
            MySqlDataAdapter dAdapter = new MySqlDataAdapter(sqlStr, connStr);

            // fill the data table and close the connection
            dAdapter.Fill(dTable);
            dAdapter.Dispose();
        }

      
       

    }
}
