using GeometricLayouts.Interfaces;
using GeometricLayouts.Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace GeometricLayouts
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IService, TriangleService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}