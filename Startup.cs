using Microsoft.Restier.Providers.EntityFramework;
using Owin;
using WinInsider.HttpHosting.Http;
using WinInsider.HttpHosting.Restier;

namespace RestireCore
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			var config = new HttpConfiguration();
			config.RouteTemplate = "odata";
			app.UseRouteTemplate<EntityFrameworkApi<YourDbContext>>(config);
		}
	}
}
