//using System;
//using System.Collections.Generic;
//using System.Web.Http.Dependencies;
//using Unity;

////TODO: (probably) delete later b/c Unity seems pretty horrible

//namespace UserRegistrationBackend.App_Start
//{
//    public class UnityDependencyResolver : IDependencyResolver
//    {
//        protected IUnityContainer container;

//        public UnityDependencyResolver(IUnityContainer container)
//        {
//            if (container == null)
//            {
//                throw new ArgumentNullException(nameof(container));
//            }
//            this.container = container;
//        }

//        public object GetService(Type serviceType)
//        {
//            try
//            {
//                return container.Resolve(serviceType);
//            }
//            catch (ResolutionFailedException ex)
//            {
//                throw new InvalidOperationException($"Failed to resolve {serviceType}", ex);
//            }
//        }

//        public IEnumerable<object> GetServices(Type serviceType)
//        {
//            try
//            {
//                return container.ResolveAll(serviceType);
//            }
//            catch (ResolutionFailedException ex)
//            {
//                throw new InvalidOperationException($"Failed to resolve {serviceType}", ex);
//            }
//        }

//        public IDependencyScope BeginScope()
//        {
//            var child = container.CreateChildContainer();
//            return new UnityDependencyResolver(child);
//        }

//        public void Dispose()
//        {
//            Dispose(true);
//        }

//        protected virtual void Dispose(bool disposing)
//        {
//            container.Dispose();
//        }
//    }
//}