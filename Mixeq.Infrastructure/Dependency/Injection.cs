using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mixeq.Domain;

namespace Mixeq.Infrastructure;

public static class Injection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppContext>(opt =>
            opt.UseMySql(configuration.GetConnectionString("DefaultConnection"),
                new MySqlServerVersion(new Version(8, 0, 3))));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IPaymentRepository, PaymentRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<PublishDomainEventsInterceptor>();
        services.AddMassTransit(config =>
        {
            config.AddConsumer<PaymentConsumer>();
            config.UsingRabbitMq((context, configuration) =>
            {
                configuration.Host("localhost", "/", h =>
                {
                    
                    h.Username("guest");
                    h.Password("guest");
                });
                configuration.ConfigureEndpoints(context);
            });
        });
        
        //services.AddExceptionHandler<GlobalExceptionHandle>();
        return services;
    }
}
