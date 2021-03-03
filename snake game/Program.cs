﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace snake_game
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // added next two lines to make the splash form display
            SplashForm aSplashForm = new SplashForm();
            aSplashForm.ShowDialog();
            Application.Run(new Form1());
        }
    }
}
