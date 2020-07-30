using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using Basicinfo.Application.GoodsGroupType;
using Basicinfo.Domain.Model.GoodsType;
using Basicinfo.Domain.Validator;
using Basicinfo.Interface.CommandController;
using Basicinfo.Interface.Facade.Query;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Framework.Application;
using Framework.CastleWindsor;
using Framework.Core;
using Framework.NHibernate;
using NHibernate;
using Basicinfo.PersistenceNH.Mappings;
using Basicinfo.PersistenceNH.Repositories;
using Framework.Domain;

//using System.Data.Entity;
//using Basicinfo.PersistenceEF;
//using Basicinfo.PersistenceEF.Repositories;

namespace Basicinfo.Wireup
{
    public class Configurator
    {
        public static void Config(IWindsorContainer container)
        {
            
            var sessionFactory = SessionFactoryBuilder.Create("DBConnection", typeof(GoodsTypeMapping).Assembly);
            container.Register(Component.For<ISession>().UsingFactoryMethod(a =>
            {
                var connection = a.Resolve<IDbConnection>();
                var session = sessionFactory.OpenSession(connection);
                return session;
            }).LifestylePerWebRequest());


            container.Register(Component.For<IDbConnection>().UsingFactoryMethod(a =>
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }).LifestylePerWebRequest().Forward<DbConnection>().OnDestroy(a => a.Close()));


            /*container.Register(Component.For<DbContext>().ImplementedBy<BiContext>());

            container.Register(Component.For<DbContext>().UsingFactoryMethod(a =>
            {
                var db = new BiContext();
                return db;
            }).LifestylePerWebRequest());*/



            container.Register(Component.For<IGoodsTypeValidator>()
                .ImplementedBy<GoodsTypeValidator>().LifestylePerWebRequest());


            ServiceLocator.Set(new WindsorServiceLocator(container));


            container.Register(Component.For<ICommandBus>()
                        .ImplementedBy<CommandBus>().LifestyleSingleton());



            container.Register(Classes.FromAssemblyContaining<GoodsRepository>()
              .BasedOn<IRepository>()
              .WithService.FromInterface().LifestylePerWebRequest());
            //container.Register(Component.For<IGoodsRepository>()
            //    .ImplementedBy<GoodsRepository>());


/*            container.Register(Classes.FromAssemblyContaining<GoodsTypeRepository>()
              .BasedOn<IRepository>()
              .WithService.FromInterface().LifestylePerWebRequest());
            //container.Register(Component.For<IGoodsTypeRepository>()
            //    .ImplementedBy<GoodsTypeRepository>());


            container.Register(Classes.FromAssemblyContaining<GoodsGroupRepository>()
              .BasedOn<IRepository>()
              .WithService.FromInterface().LifestylePerWebRequest());
            //container.Register(Component.For<IGoodsGroupRepository>()
            //    .ImplementedBy<GoodsGroupRepository>());
*/

            


            container.Register(Classes.FromAssemblyContaining<GoodsCommandHandler>()
                .BasedOn(typeof(ICommandHandler<>))
                .WithService.AllInterfaces().LifestyleTransient());


            container.Register(Classes.FromAssemblyContaining<GoodsTypeQueryHandler>()
               .BasedOn(typeof(IQueryHandler<>))
               .WithService.AllInterfaces().LifestyleTransient());



            container.Register(Component.For<IUnitofwork>().ImplementedBy<NhUnitofwork>()
                .LifestyleBoundTo<ICommandHandler>());



            container.Register(Classes.FromAssemblyContaining<GoodsTypeLuncher>()
                .BasedOn<IFacadeService>().WithServiceFromInterface().LifestylePerWebRequest());

            container.Register(Classes.FromAssemblyContaining<GoodsTypeFacadeQuery>()
                .BasedOn<IFacadeService>().WithServiceFromInterface().LifestylePerWebRequest());




            
            //container.Register(Classes.FromAssemblyContaining<ProductsController>()
            //    .BasedOn<ApiController>().LifestylePerWebRequest());

        }
    }
}
