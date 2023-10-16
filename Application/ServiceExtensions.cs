using Application.Features.Processes.Services;
using Application.Features.Processes.Storage;
using Application.Features.Workflows.Requests;
using Application.Features.Workflows.Services;
using Application.Features.Workflows.Storage;
using Application.Persistence.Storage;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        //
        // // repositories
        services.AddScoped<IWorkflowRepository, WorkflowRepository>();
        services.AddScoped<IProcessRepository, ProcessRepository>();
        //
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        // services
        services.AddTransient<IWorkflowService, WorkflowService>();
        services.AddTransient<IProcessService, ProcessService>();
        
        //services.AddValidatorsFromAssemblyContaining<CreateWorkflowCommand>();
        
        return services;
    }
    
    
    

}