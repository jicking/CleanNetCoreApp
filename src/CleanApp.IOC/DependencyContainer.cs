using CleanApp.Application.Abstractions;
using CleanApp.Application.Services;
using CleanApp.Data.EF.Repositories;
using CleanApp.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp.IOC
{
    class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //.Application
            services.AddScoped<ITodoService, TodoServices>();

            //.Domain | .Data
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
