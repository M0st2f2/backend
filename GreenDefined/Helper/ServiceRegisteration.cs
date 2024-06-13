using GreenDefined.Models;
using Microsoft.AspNetCore.Identity;

namespace GreenDefined.Helper
{
    public static class ServiceRegisteration
    {
        public static IServiceCollection AddServiceRegisteration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>(option =>
            {
                // Password settings.
                option.Password.RequireDigit = false;
                option.Password.RequireLowercase = false;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireUppercase = false;
                option.Password.RequiredLength = 4;
                option.Password.RequiredUniqueChars = 0;
            });
            return services;
        }
        //why
    }

}
