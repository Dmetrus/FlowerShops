using FlowerShops.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Interface
{
    public interface IServiceService
    {
        /// <summary>
        /// Получить список всех <see cref="ServiceModel"/>
        /// </summary>
        Task<IEnumerable<ServiceModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="ServiceModel"/> по идентификатору
        /// </summary>
        Task<ServiceModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавляет новую услугу
        /// </summary>
        Task<ServiceModel> AddAsync(ServiceRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Редактирует существующую услуги
        /// </summary>
        Task<ServiceModel> EditAsync(ServiceRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет существующую услугу
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
