using FlowerShops.Common.Entity.Repositories;
using FlowerShops.Context.Contracts.Interface;
using FlowerShops.Context.Contracts.Models;
using FlowerShops.Repositories.Contracts.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Implementations
{
    public class LocationReadRepository : ILocationReadRepository
    {
        private readonly IFlowerShopsContext context;

        public LocationReadRepository(IFlowerShopsContext context)
        {
            this.context = context;
        }

        Task<List<Location>> ILocationReadRepository.GetAllAsync(CancellationToken cancellationToken)
        => Task.FromResult(context.Locations
            .AsQueryable()
            .NotDeletedAt()
            .OrderBy(x => x.Index)
            .ToList());
           
        

        Task<Location?> ILocationReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => Task.FromResult(context.Locations
            .AsQueryable()
            .NotDeletedAt()
            .ById(id)
            .FirstOrDefault());

    }
}
