using $ext_safeprojectname$.Application.Abstractions;
using $ext_safeprojectname$.Application.Services;
using $ext_safeprojectname$.Application.Validators;
using $ext_safeprojectname$.Data.EF.Repositories;
using $ext_safeprojectname$.Domain.Abstractions;
using $ext_safeprojectname$.Domain.Models;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace $ext_safeprojectname$.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //.Application
            services.AddScoped<ITodoService, TodoService>();

            //.Domain | .Data
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));

            //.Application/Validators
            services.AddTransient<IValidator<TodoItem>, TodoItemValidator>();
        }
    }
}
