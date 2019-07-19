namespace Service
{
    using Data;
    using Microsoft.AspNet.OData.Builder;
    using Microsoft.AspNet.OData.Extensions;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Newtonsoft.Json;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore().AddJsonFormatters(config =>
            {
                config.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
            services.AddOData();
        }

        public void Configure(IApplicationBuilder app)
        {
            var builder = new ODataConventionModelBuilder(app.ApplicationServices);

            builder.EntitySet<Users>("Users");

            app.UseMvc(routeBuilder =>
            {
                routeBuilder.MapRoute("default", "Custom/{*action}");

                routeBuilder.Select().Expand().Filter().OrderBy().MaxTop(100).Count();
                routeBuilder.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
            });
        }
    }
}
