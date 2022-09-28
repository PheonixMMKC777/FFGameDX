using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Net.Http;

namespace ffgameRedux
{


    


    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]




        static void Main()
        {



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetDefaultFont(new Font(new FontFamily("Consolas"), 9f));
            Application.Run(new MainForm());
        }
    }
}