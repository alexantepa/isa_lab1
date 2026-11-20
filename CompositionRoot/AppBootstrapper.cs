using Ninject;
using Presenter;
using Book.BusinessLogic;
using Shared;

namespace CompositionRoot
{
    public class AppBootstrapper
    {
        private readonly IKernel kernel;
        private MainPresenter presenter;

        public AppBootstrapper()
        {
            kernel = new StandardKernel(new SimpleConfigModule());
        }

        public void Run(IView view)
        {

            IModel model = kernel.Get<Shared.IModel>();

            presenter = new MainPresenter(view, model);

            presenter.Run();
        }

        public void Dispose()
        {
            kernel.Dispose();
        }

    }
}
