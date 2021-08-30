using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureProject.Application.Interfaces.Repository;
using OnionArchitectureProject.Persistence.Context;
using OnionArchitectureProject.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitectureProject.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(opt=>opt.UseInMemoryDatabase("memoryDb"));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
