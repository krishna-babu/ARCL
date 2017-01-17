using ARCL.BusinessService;
using ARCL.BusinessService.Interface;
using ARCL.DBModel;
using ARCL.Repository;
using ARCL.Repository.Interface;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace ARCL.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ARCLContext, ARCLContext>();

            //Repo DI's
            container.RegisterType<ITeamRepository, TeamRepository>();
            container.RegisterType<ISeasonRepository, SeasonRepository>();

            //Service DI's
            container.RegisterType<ITeamService, TeamService>();
            container.RegisterType<ISeasonService, SeasonService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}