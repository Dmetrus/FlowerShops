using FlowerShops.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Interface
{
    public interface ILocationService
    {
        /// <summary>
        /// Получить список всех <see cref="LocationModel"/>
        /// </summary>
        Task<IEnumerable<LocationModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="LocationModel"/> по идентификатору
        /// </summary>
        Task<LocationModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавляет новый адрес
        /// </summary>
        Task<LocationModel> AddAsync(LocationRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет существующий адрес
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
