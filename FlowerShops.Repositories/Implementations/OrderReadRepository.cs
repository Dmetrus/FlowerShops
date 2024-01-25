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
    public class OrderReadRepository : IOrderReadRepository
    {
        private readonly IFlowerShopsContext context;

        public OrderReadRepository(IFlowerShopsContext context)
        {
            this.context = context;
        }

        Task<List<Order>> IOrderReadRepository.GetAllAsync(CancellationToken cancellationToken)
        => Task.FromResult(context.Orders
            .AsQueryable()
            .NotDeletedAt()
            .OrderBy(x =>x.CreatedAt)
            .ToList());

        Task<Order?> IOrderReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => Task.FromResult(context.Orders
            .AsQueryable()
            .NotDeletedAt()
            .ById(id)
            .FirstOrDefault());
    }
}
