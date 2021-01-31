using LibrarySystem.Application.Interfaces;
using LibrarySystem.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LibrarySystem.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<IBooksService, BooksService>();

            //Domain Layer

        }
    }
}
