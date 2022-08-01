using BazaarOnline.Application.Interfaces.Auth;
using BazaarOnline.Application.Interfaces.Senders;
using BazaarOnline.Application.Interfaces.Users;
using BazaarOnline.Application.Services.Auth;
using BazaarOnline.Application.Services.Senders;
using BazaarOnline.Application.Services.Users;
using BazaarOnline.Domain.Interfaces.Users;
using BazaarOnline.Infra.Data.Repositories.Users;
using Microsoft.Extensions.DependencyInjection;

namespace BazaarOnline.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IAuthService, AuthService>();

            #region Users
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IActiveCodeService, ActiveCodeService>();
            #endregion

            #region Senders
            services.AddScoped<IEmailService, EmailService>();
            #endregion

            #endregion

            #region Repositories

            #region Users
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IActiveCodeRepository, ActiveCodeRepository>();
            #endregion

            #endregion
        }
    }
}