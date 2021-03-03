namespace snake_game
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvsnakegame = new System.Windows.Forms.DataGridView();
            this.lblscores = new System.Windows.Forms.Label();
            this.cboScores = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtfirstnames = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnPlayagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsnakegame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsnakegame
            // 
            this.dgvsnakegame.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvsnakegame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsnakegame.Location = new System.Drawing.Point(267, 47);
            this.dgvsnakegame.Name = "dgvsnakegame";
            this.dgvsnakegame.ReadOnly = true;
            this.dgvsnakegame.Size = new System.Drawing.Size(410, 294);
            this.dgvsnakegame.TabIndex = 0;
            // 
            // lblscores
            // 
            this.lblscores.AutoSize = true;
            this.lblscores.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscores.Location = new System.Drawing.Point(294, 448);
            this.lblscores.Name = "lblscores";
            this.lblscores.Size = new System.Drawing.Size(62, 18);
            this.lblscores.TabIndex = 3;
            this.lblscores.Text = "Scores";
            // 
            // cboScores
            // 
            this.cboScores.FormattingEnabled = true;
            this.cboScores.Location = new System.Drawing.Point(384, 445);
            this.cboScores.Name = "cboScores";
            this.cboScores.Size = new System.Drawing.Size(121, 21);
            this.cboScores.TabIndex = 4;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(511, 422);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 59);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(592, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 59);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = " SNAKE SCORE-BOARD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::snake_game.Properties.Resources.pic_1a;
            this.pictureBox1.InitialImage = global::snake_game.Properties.Resources.Capture4;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 434);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(294, 367);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(41, 16);
            this.lblfirstname.TabIndex = 18;
            this.lblfirstname.Text = "Non-";
            // 
            // txtfirstnames
            // 
            this.txtfirstnames.Location = new System.Drawing.Point(389, 363);
            this.txtfirstnames.Name = "txtfirstnames";
            this.txtfirstnames.Size = new System.Drawing.Size(116, 20);
            this.txtfirstnames.TabIndex = 19;
            this.txtfirstnames.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(592, 363);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 52);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPlayagain
            // 
            this.btnPlayagain.Location = new System.Drawing.Point(511, 363);
            this.btnPlayagain.Name = "btnPlayagain";
            this.btnPlayagain.Size = new System.Drawing.Size(75, 52);
            this.btnPlayagain.TabIndex = 22;
            this.btnPlayagain.Text = "&Play Again";
            this.btnPlayagain.UseVisualStyleBackColor = true;
            this.btnPlayagain.Click += new System.EventHandler(this.btnPlayagain_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(679, 482);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnPlayagain);
            this.Controls.Add(this.txtfirstnames);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cboScores);
            this.Controls.Add(this.lblscores);
            this.Controls.Add(this.dgvsnakegame);
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Load += new System.EventHandler(this.Scoreboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsnakegame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsnakegame;
        private System.Windows.Forms.Label lblscores;
        private System.Windows.Forms.ComboBox cboScores;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtfirstnames;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnPlayagain;
    }
}