using Presentation;

namespace Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Crear el formulario de inicio (Login) con el icono asignado
            Login loginForm = new Login();
            // Ejecutar la aplicación con el formulario de inicio
            Application.Run(loginForm);
        }
    }
}