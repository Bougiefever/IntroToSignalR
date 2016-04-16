using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;

namespace SignalRHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string sqlConnectionString = "Data Source=LT1088; Initial Catalog=SignalrBackplane; Integrated Security=true;";
            GlobalHost.DependencyResolver.UseSqlServer(sqlConnectionString);


            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }
}