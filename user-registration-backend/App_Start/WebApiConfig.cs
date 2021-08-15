using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using System.Reflection;
using System.Web.Http;
using UserRegistrationBackend.Config;
using UserRegistrationBackend.Context;
using UserRegistrationBackend.Services;
using UserRegistrationBackend.Services.Implementations;

namespace UserRegistrationBackend
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<RegistrationDbContext>().As<IRegistrationDbContext>();

            builder.RegisterType<AddressService>().As<IAddressService>();
            builder.RegisterType<ContactService>().As<IContactService>();
            builder.RegisterType<NameService>().As<INameService>();
            builder.RegisterType<UserService>().As<IUserService>();

            // Automapper setup
            var mapConfig = new MapperConfiguration(cfg => {
                cfg.AddProfile<AutomapperProfile>();
            });
            var mapper = mapConfig.CreateMapper();
            builder.RegisterInstance(mapper).As<IMapper>();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(builder.Build());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "RegistrationApi",
                routeTemplate: "api/v1/user/{userId}/{controller}/{id}",
                defaults: new {
                    userId = RouteParameter.Optional,
                    controller = RouteParameter.Optional,
                    id = RouteParameter.Optional
                }
            );
        }
    }
}
