using BookFinder.Business.Abstract;
using BookFinder.Business.Concrete;
using BookFinder.DataAccess.Abstract;
using BookFinder.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace BookFinder.API
{
    public class Startup
    {
       
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            //Constructorda 
            services.AddSingleton<IBookService, BookManager>();
            services.AddSingleton<IBookRepository, BookRepository>();
            //tarayýcý için handshake
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //allowanymethod ile get post put iþlemlerini yapabiliriz. Header ise gelen headerlarýn her türlüsünü kabul eder.
            //allowanyorigin istek nereden gelirse gelsin
            //app.UseCors(x=>x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().AllowCredentials());

            app.UseRouting();
            // global cors policy
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(x => x.MapControllers());
        }
    }
}
