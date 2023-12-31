using UI.Views.Class;
using UI.Views.Manager;
using UI.Views.Student;
using UI.Views.Subject;
using UI.Views.Teacher;
using UI.Views.Transcript;

namespace UI
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
            Application.Run(new ManagerStudents());
        }
    }
}