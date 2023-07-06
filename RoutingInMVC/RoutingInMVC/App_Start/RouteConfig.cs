using System.Web.Mvc;
using System.Web.Routing;

namespace RoutingInMVC
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			//Custom Route Defining
			routes.MapRoute(
				name: "Employee",
				url: "Employee/{id}",
				defaults: new { controller = "Employee", action = "Index", id = UrlParameter.Optional },
				// Restriction for controller and action
				// It restrict the user for those URLs that have controller name with H prefix and action name should be only Details or About.
				//=>		new { controller = @”^H.*”, action = @”^(Detail|Index)$”, id = @”\d+|” }

				// Restriction for int id only
				constraints: new { id = @"\d+" }
			);

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
