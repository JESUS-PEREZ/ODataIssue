using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData.Edm;
using Microsoft.AspNet.OData.Builder;
using ODataInheritanceIssue.Models;
using Microsoft.EntityFrameworkCore;
using ODataInheritanceIssue.Database;

namespace ODataComplexTypeInheritance
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOData();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            
            services.AddDbContext<TestDBContext>(options
                => options.UseInMemoryDatabase(databaseName: "TestDB"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc(appBuilder =>
            {
                appBuilder.MapODataServiceRoute("odata", "odata", GetModel());
            });
        }

        private static IEdmModel GetModel()
        {
            var builder = new ODataConventionModelBuilder();

            var objects = builder.EntitySet<Object>("Objects");
            var objectsWithManualExpanding = builder.EntitySet<Object>("ObjectsWithManualExpanding");
            var relationships = builder.EntitySet<Relationship>("Relationships");

            var objectEntity = objects.EntityType;
            var relationshipEntity = relationships.EntityType;
            var objectWithManualExpandingEntity = objectsWithManualExpanding.EntityType;

            builder.EntitySet<AttributeValue>("AttributeValues");

            objectEntity.Expand(nameof(Object.AttributeValues));
            relationshipEntity.Expand(nameof(Relationship.AttributeValues));
            objectWithManualExpandingEntity.Expand(nameof(Object.AttributeValues));

            builder.AddComplexType(typeof(ChoiceValue));
            builder.AddComplexType(typeof(HyperlinkValue));

            return builder.GetEdmModel();
        }
    }
}
