using Core;
using Core.Interfaces;
using Infrastructure.Repositories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Interfaces;
using Presentation.Services;
using Presentation.ViewModels;

namespace IoC
{
    public class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IBookAppService, BookAppServices>();
            services.AddScoped<IBookRepository, BookRepository>();

            services.Scan(scan => scan
                      .FromAssemblyOf<BookViewModel>()
                      .AddClasses(classes => classes.AssignableTo(typeof(IRequestHandler<,>)))
                      .AddClasses(classes => classes.Where(type => type.Name.EndsWith("Handler")))
                      .AsImplementedInterfaces()
                      .WithScopedLifetime());

            services.AddScoped<IMediatorHandler, MediatorHandler>();
        }
    }
}
