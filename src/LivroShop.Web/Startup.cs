using AutoMapper;
using LivroShop.ApplicationCore.Intrfaces.Repositories;
using LivroShop.ApplicationCore.Intrfaces.Services;
using LivroShop.ApplicationCore.Services;
using LivroShop.Infrastructure.Data;
using LivroShop.Infrastructure.Repositories;
using LivroShop.Web.AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LivroShop.Web
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
            services.AddDbContext<LivroShopContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            Mapper.Initialize(cfg => cfg.AddProfile<AutoMapperProfile>());

            services.AddScoped<ILivroService, LivroService>();
            services.AddScoped<ILivroRepository, LivroRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Livros}/{action=Index}/{id?}");
            });
        }
    }
}
