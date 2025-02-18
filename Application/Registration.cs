using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Reflection;

namespace Application
{
    public static class Registration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            //services.AddTransient<ExceptionMiddleware>();


            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
    

            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            //ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");

            //services.AddLocalization(options => options.ResourcesPath = "Resources");
            //services.AddControllersWithViews().AddDataAnnotationsLocalization();

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            return services;

        }
        private static IServiceCollection AddRulesFromAssemblyContaining(
          this IServiceCollection services,
          Assembly assembly,
          Type type)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                services.AddTransient(item);

            return services;
        }

    }
}