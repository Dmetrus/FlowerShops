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
    public class ServiceReadRepository : IServiceReadRepository
    {
        private readonly IFlowerShopsContext context;

        public ServiceReadRepository(IFlowerShopsContext context)
        {
            this.context = context;
        }
        Task<List<Service>> IServiceReadRepository.GetAllAsync(CancellationToken cancellationToken)
        => Task.FromResult(context.Services
            .AsQueryable()
            .NotDeletedAt()
            .OrderBy(x => x.Name)
            .ToList());

        Task<Service?> IServiceReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => Task.FromResult(context.Services
            .AsQueryable()
            .NotDeletedAt()
            .ById(id)
            .FirstOrDefault());
    }
}
