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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            // close this form after the interval has timed out
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Scoreboard exit = new Scoreboard();
            exit.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 exit = new Form1();
            exit.Show();
            this.Hide();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            SplashForm exit = new SplashForm();
            exit.Show();
            this.Hide();
        }

       
    }
}
