﻿using APS_4.View.Forms;
using System;
using System.Windows.Forms;

namespace APS_4.View
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConfiguration());
        }
    }
}
