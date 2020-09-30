using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;

namespace SportsStore.WebUI.App_Start
{
    private static void RegisterServices(IKernel kernel)
    {
        System.Web.Mvc.DependencyResolver.SetResolver(new
        SportsStore.WebUI.Infrastructure.NinjectDependencyResolver(kernel));
    }

}