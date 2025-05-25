using FlexHouseDashboard;
using System;
using System.Windows.Forms; // Adicionado para corrigir o erro

namespace FlexHouseDashboard
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Substituí ApplicationConfiguration.Initialize() por Application.EnableVisualStyles() e Application.SetCompatibleTextRenderingDefault().
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}