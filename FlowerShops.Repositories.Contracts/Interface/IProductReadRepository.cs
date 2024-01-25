using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Contracts.Interface
{
    public interface IProductReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Product"/>
        /// </summary>
        Task<List<Product>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Product"/> по идентификатору id
        /// </summary>
        Task<Product?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
