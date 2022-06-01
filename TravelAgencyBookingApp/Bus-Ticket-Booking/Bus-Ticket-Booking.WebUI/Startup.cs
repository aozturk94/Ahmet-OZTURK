using Bus_Ticket_Booking.Business.Abstract;
using Bus_Ticket_Booking.Business.Concrete;
using Bus_Ticket_Booking.Data.Abstract;
using Bus_Ticket_Booking.Data.Concrete.EfCore;
using Bus_Ticket_Booking.WebUI.EmailServices;
using Bus_Ticket_Booking.WebUI.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.WebUI
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
            services.AddControllersWithViews();

            services.AddScoped<ICityRepository, EfCoreCityRepository>();
            services.AddScoped<IRouteRepository, EfCoreRouteRepository>();
            services.AddScoped<ITicketRepository, EfCoreTicketRepository>();
            services.AddScoped<IBusRepository, EfCoreBusRepository>();

            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IRouteService, RouteManager>();
            services.AddScoped<ITicketService, TicketManager>();
            services.AddScoped<IBusService, BusManager>();

            services.AddDbContext<ApplicationContext>(options => options.UseSqlite("Data Source=BookingDb"));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                //Password
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 6;

                //Lockout
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

                //User
                options.User.RequireUniqueEmail = true;

                //SignIn
                options.SignIn.RequireConfirmedEmail = true;


            });

            services.ConfigureApplicationCookie(options => {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";



                options.Cookie = new CookieBuilder()
                {
                    HttpOnly = true,
                    Name = "Oztur.Security.Cookie",
                    SameSite = SameSiteMode.Strict
                };
                options.SlidingExpiration = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
            });

            services.AddScoped<IEmailSender, SmtpEmailSender>(i => new SmtpEmailSender(
                Configuration["EmailSender:Host"],
                Configuration.GetValue<int>("EmailSender:Port"),
                Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                Configuration["EmailSender:UserName"],
                Configuration["EmailSender:Password"]
                ));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                SeedDatabase.Seed();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "adminlist",
                    pattern: "admin/adminlist",
                    defaults: new { controller = "Admin", action = "AdminList" }
                    );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
