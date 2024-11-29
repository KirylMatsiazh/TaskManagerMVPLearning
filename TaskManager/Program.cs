using TaskManager.Presenter;
using TaskManager.Repository;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager
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

            IRepository<UTask> repository = new JSONRepository<UTask>();
            IService<UTask> service = new UTaskService(repository);
            UTaskPresenter testPresenter = new UTaskPresenter(service);

            Application.Run(new Form1(testPresenter));
        }
    }
}