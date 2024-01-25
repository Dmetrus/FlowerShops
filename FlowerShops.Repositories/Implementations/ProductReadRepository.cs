using FlowerShops.Common.Entity.Repositories;
using FlowerShops.Context.Contracts.Interface;
using FlowerShops.Context.Contracts.Models;
using FlowerShops.Repositories.Contracts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Implementations
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly IFlowerShopsContext context;

        public ProductReadRepository(IFlowerShopsContext context)
        {
            this.context = context;
        }

        Task<List<Product>> IProductReadRepository.GetAllAsync(CancellationToken cancellationToken)
        => Task.FromResult(context.Products
            .AsQueryable()
            .NotDeletedAt()
            .OrderBy(x => x.Name)
            .ToList());

        Task<Product?> IProductReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => Task.FromResult(context.Products
            .AsQueryable()
            .NotDeletedAt()
            .ById(id)
            .FirstOrDefault());
    }
}
