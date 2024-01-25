using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Contracts.Interface
{
    public interface ILocationReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Location"/>
        /// </summary>
        Task<List<Location>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Location"/> по идентификатору id
        /// </summary>
        Task<Location?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    }
}
