using DAL.Interface;
using DAL.ORM.EntityFramework;
using DAL.ORM.NHibarnate.Maps;
using DAL.ORM.NHibarnate.Repositories;
using FluentNHibernate.Cfg;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BLL.Service.EfCoreService;
using BLL.Interface;
using Entities.Model.NHibarnateModel;
//using Entities.Model.EfCoreModel;

namespace BLL.RepositoryExtensions
{
    public static class RepositoryExtensions
    {
        public static IConfiguration Configuration { get; }
        public static IServiceCollection AddRepositoryService(this IServiceCollection services)
        {
            return services
                // .AddDbContext<DAL.ORM.EntityFramework.EfCoreContext>(
                //     opt => opt.UseSqlServer(Configuration.GetConnectionString("cnn")))
                // .AddScoped<ICategoryDAL, EfCategoryRepository>()
                // .AddScoped<IProductDAL, EfProductRepository>()
                .AddScoped<ICategoryDAL, NhCategoryRepository>()
                //.AddScoped<IProductDAL, NhProductRepository>()
                .AddScoped<ICategoryService<Category>, CategoryService>()
                .AddSingleton<NHibernate.ISessionFactory>(factory => 
                {
                    return Fluently.Configure()
                    .Database(
                        () => 
                        {
                            return FluentNHibernate.Cfg.Db.MsSqlConfiguration.MsSql2012
                            .ShowSql()
                            .ConnectionString(Configuration.GetConnectionString("cnn"));
                        }
                    )
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CategoryMap>())
                    .BuildSessionFactory();     
                }
                );

            // return services
            //     .AddScoped<ICategoryDAL, NhCategoryRepository>()
            //     .AddScoped<IProductDAL, NhProductRepository>();
        }
    }
}