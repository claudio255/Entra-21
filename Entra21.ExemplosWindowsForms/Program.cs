using Entra21.ExemplosWindowsForms.Exemplo01;
using Entra21.ExemplosWindowsForms.exemplo02;

namespace Entra21.ExemplosWindowsForms
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new PacientesForm());
            ApplicationConfiguration.Initialize();
            Application.Run(new MediaForms());
        }
    }
}