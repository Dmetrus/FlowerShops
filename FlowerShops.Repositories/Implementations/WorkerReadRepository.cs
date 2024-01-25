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
    public class WorkerReadRepository : IWorkerReadRepository
    {
        private readonly IFlowerShopsContext context;

        public WorkerReadRepository(IFlowerShopsContext context)
        {
            this.context = context;
        }
        Task<List<Worker>> IWorkerReadRepository.GetAllAsync(CancellationToken cancellationToken)
        => Task.FromResult(context.Workers
            .AsQueryable()
            .NotDeletedAt()
            .OrderBy(x => x.Number)
            .ToList());

        Task<Worker?> IWorkerReadRepository.GetByIdAsync(Guid id, CancellationToken cancellationToken)
        => Task.FromResult(context.Workers
            .AsQueryable()
            .NotDeletedAt()
            .ById(id)
            .FirstOrDefault());
    }
}
