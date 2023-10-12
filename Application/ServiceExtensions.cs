using Application.Features.Workflows.Services;
using Application.Features.Workflows.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IWorkflowRepository, WorkflowRepository>();
        services.AddTransient<IWorkflowService, WorkflowService>();
        
        return services;
    }
    
    
    

}