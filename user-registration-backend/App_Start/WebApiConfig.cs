using System.Web.Http;
//using Unity;
//using Unity.Lifetime;
//using UserRegistrationBackend.App_Start;
//using UserRegistrationBackend.Context;
//using UserRegistrationBackend.Services;
//using UserRegistrationBackend.Services.Implementations;

namespace UserRegistrationBackend
{
    public static class WebApiConfig
    {
        public static readonly int API_VERSION = 1;

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            //var container = new UnityContainer().AddExtension(new Diagnostic());
            //container.RegisterType<IRegistrationDbContext, RegistrationDbContext>(new HierarchicalLifetimeManager());

            //container.RegisterType<IAddressService, AddressService>(new HierarchicalLifetimeManager());
            //container.RegisterType<IContactService, ContactService>(new HierarchicalLifetimeManager());
            //container.RegisterType<INameService, NameService>(new HierarchicalLifetimeManager());
            //container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());

            //config.DependencyResolver = new UnityDependencyResolver(container);

            //TODO: IoC resolver...

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "RegistrationApi",
                routeTemplate: "api/" + API_VERSION + "/users/{controller}/{id}",
                defaults: new { controller = RouteParameter.Optional, id = RouteParameter.Optional }
            );
        }
    }
}
