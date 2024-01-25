using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Contracts.Interface
{
    public interface IWorkerReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Worker"/>
        /// </summary>
        Task<List<Worker>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Worker"/> по идентификатору id
        /// </summary>
        Task<Worker?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
