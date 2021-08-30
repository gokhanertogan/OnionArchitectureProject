using OnionArchitectureProject.Application.Interfaces.Repository;
using OnionArchitectureProject.Domain.Entities;
using OnionArchitectureProject.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureProject.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext):base(dbContext)
        {

        }
    }
}
