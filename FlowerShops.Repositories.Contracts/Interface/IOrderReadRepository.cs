using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Contracts.Interface
{
    public interface IOrderReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Order"/>
        /// </summary>
        Task<List<Order>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Order"/> по идентификатору id
        /// </summary>
        Task<Order?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
