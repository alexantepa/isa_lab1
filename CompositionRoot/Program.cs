using Book.BusinessLogic;
using Book.winform;
using CompositionRoot;
using Ninject;
using Presenter;
using Shared;
using System.Windows.Forms;
using Book.console;

namespace CompositionRoot
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Console.WriteLine("1-console, 2-winform");
            var choice = System.Console.ReadLine();

            if (choice == "2")
            {
                Application.EnableVisualStyles();

                using (var kernel = new StandardKernel(new SimpleConfigModule()))
                {
                    IModel model = kernel.Get<IModel>();
                    Form1 form = new Form1();
                    var presenter = new MainPresenter(form, model);
                    presenter.Run();

                    Application.Run(form);
                }
            }
            else
            {
                ConsoleApp consoleApp = new ConsoleApp();
                using (var kernel = new StandardKernel(new SimpleConfigModule()))
                {
                    IModel model = kernel.Get<IModel>();
                    MainPresenter presenter = new MainPresenter(consoleApp, model);

                    presenter.Run();

                    consoleApp.Run();
                }
            }
        }
    }
}