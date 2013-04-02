using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace GD
{
    // Примечание: Инструкции по включению классического режима IIS6 или IIS7 
    // см. по ссылке http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Имя маршрута
                "{controller}/{action}/{id}", // URL-адрес с параметрами
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Параметры по умолчанию
            );

        }
        public static void AddAdmin()
        {
            //Если нет в системе роли admin - создаем её
            if (!Roles.RoleExists(Constants.ROLE_ADMIN))
                Roles.CreateRole(Constants.ROLE_ADMIN);
            //Если в системе нет пользователя admin создаем его
            if (Membership.GetUser("admin") == null)
            {
                MembershipCreateStatus status = MembershipCreateStatus.Success;
                Membership.CreateUser("admin", "temp_pass","" ,"","",true,out status);
            }
            //Если у пользователя admin нет роли admin, присваиваем её
            if (!Roles.IsUserInRole("admin", Constants.ROLE_ADMIN)) 
            Roles.AddUserToRole("admin", Constants.ROLE_ADMIN);
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            AddAdmin();
        }
    }
}