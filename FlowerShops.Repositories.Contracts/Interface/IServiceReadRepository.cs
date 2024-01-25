using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Contracts.Interface
{
    public interface IServiceReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Service"/>
        /// </summary>
        Task<List<Service>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Service"/> по идентификатору id
        /// </summary>
        Task<Service?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
