using FlowerShops.Context.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Repositories.Contracts.Interface
{
    public interface IPersonReadRepository
    {
        /// <summary>
        /// Получить список всех <see cref="Person"/>
        /// </summary>
        Task<List<Person>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="Person"/> по идентификатору id
        /// </summary>
        Task<Person?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
