using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace snake_game
{
    public partial class DatabaseForm : Form
    {
        public DatabaseForm()
        {
            InitializeComponent();
        }

        static public string sConnStr;

        private void btnOK_Click(object sender, EventArgs e)
        {
            sConnStr = "server=" + txtServer.Text + ";";
            sConnStr += "database=" + txtDatabase.Text + ";";
            sConnStr += "uid=" + txtUsername.Text + ";";
            sConnStr += "pwd=" + txtPassword.Text + ";";
            this.Close();
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
