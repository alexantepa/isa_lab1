using Book.businessLogic;
using DataAccessLayer;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.BusinessLogic
{
    public class SimpleConfigModule: NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Book.model.Book>>()
                .To<EntityRepository<Book.model.Book>>()
                .InSingletonScope();

            Bind<AppDbContext>()
                .ToMethod(_ => new AppDbContext())
                .InSingletonScope();

            Bind<ILogic>().To<Logic>().InSingletonScope();

        }
    }
}
