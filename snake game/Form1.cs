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
using System.Media;

namespace snake_game
{
    public partial class Form1 : Form
    {
        Random randFood = new Random();

        Graphics paper;
        snake snakes = new snake();
        Food food;
        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;
        private int score = 0;
        private int duration = 0;
        private string sname = PlayerDetails.surname;
        private string fname = PlayerDetails.firstname;

        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
        }
    
        // declare variable for database connection 
        MySqlConnection myConn;

        // declare data table object
        private DataTable dTable = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // create and use database form  to get database
            // connection details
            DatabaseForm databaseFrm = new DatabaseForm();

            databaseFrm.ShowDialog();

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

            if (sname == "" || fname == "")
            {
                PlayerDetails playerform = new PlayerDetails();
                playerform.ShowDialog();
            }

           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawFood(paper);
            snakes.drawSnake(paper);
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                swimsnake.Text= "";
                spaceBarLabel.Text = "";
                down = false;
                up = false;
                left = false;
                right = true;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snakeScoreLabel.Text = Convert.ToString(score);
            if (down) { snakes.moveDown(); }
            if (up) { snakes.moveUp(); }
            if (right) { snakes.moveRight(); }
            if (left) { snakes.moveLeft(); }
            this.Invalidate();
            collision();
            for (int i = 0; i < snakes.SnakeRec.Length; i++)
            {
                if (snakes.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    score += 1;
                    snakes.growSnake();
                    food.foodlocation(randFood);
                }
            }
        }

        public void collision()
        {
            for (int i = 1; i < snakes.SnakeRec.Length; i++)
            {
                if (snakes.SnakeRec[0].IntersectsWith(snakes.SnakeRec[1]))
                {
                    restart();
                }
            }
            if (snakes.SnakeRec[0].X < 0 || snakes.SnakeRec[0].X > 290)
            {
                restart();
            
            }
            if (snakes.SnakeRec[0].Y < 0 || snakes.SnakeRec[0].Y > 290)
            {
                restart();
            }

        
            
        }

        public void restart()
        {
            timer1.Enabled = false;
           
           
                addscore();
                MessageBox.Show("GAME OVER");
                snakeScoreLabel.Text = "0";
                score = 0;
                duration = 0;
                spaceBarLabel.Text = "Press SpaceBar to begin";
                swimsnake.Text = "SNAKE DESIGN";
                snakes = new snake();
         


        }

        private void addscore()
        {
            

            // select game table into new table/adapter
            MySqlDataAdapter dAdapter = new MySqlDataAdapter(" SELECT * FROM snakegame", myConn);

            DataTable dTable = new DataTable();

            dAdapter.Fill(dTable);

            // create a new row and add data
            // Leave gameId field empty as this auto-increaments
            DataRow dr = dTable.NewRow();

            dr["scores"] = score;
            dr["duration"] = duration;
            dr["firstname"] = fname;
            dr["surname"] = sname;
            


            // add row to table
            dTable.Rows.Add(dr);

            // set up command builder and upgrade adapter to save data
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dAdapter);

            int iRowsAffected = dAdapter.Update(dTable);

            if (iRowsAffected == 1)
            {
                MessageBox.Show( "added to scoreboard", "Record Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Error adding record", "Record Added",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            snakeScoreLabel.Text = "0";
            score = 0;
            duration = 0;
            snakes = new snake();
        }

        private void mediumGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            snakeScoreLabel.Text = "0";
            score = 0;
            duration = 0;
            snakes = new snake();
            timer1.Interval = 100;
        }

        private void hardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            snakeScoreLabel.Text = "0";
            score = 0;
            duration = 0;
            snakes = new snake();
            timer1.Interval = 50;
        }

        private void aboutTheGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboardform = new Scoreboard();
            scoreboardform.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //clear form and return to MainForm
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }      

        private void gameOverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("GAME OVER");
            snakeScoreLabel.Text = "0";
            score = 0;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showScoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboardform = new Scoreboard();
            scoreboardform.Show();
        }

        private void soundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer(@"C:\\mywavfile.wav");
            Player.Play();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer(@"C:\\mywavfile.wav");
            Player.Play();
        }
       
       

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
       
    }
}
