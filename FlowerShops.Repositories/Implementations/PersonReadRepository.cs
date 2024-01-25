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
    public class PersonReadRepository : IPersonReadRepository
    {
        private readonly IFlowerShopsContext context;

        public PersonReadRepository(IFlowerShopsContext context)
        {
            this.context = context;
        }

        Task<List<Person>> IPersonReadRepository.GetAllAsync(CancellationToken cancellationToken)
        => Task.FromResult(context.Persons
            .AsQueryable()
            .NotDeletedAt()
            .OrderBy(x => x.LastName)
            .ToList());

        Task<Person?> IPersonReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
         => Task.FromResult(context.Persons
            .AsQueryable()
            .NotDeletedAt()
            .ById(id)
            .FirstOrDefault());
    }
}
