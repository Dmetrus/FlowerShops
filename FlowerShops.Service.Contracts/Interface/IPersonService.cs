using FlowerShops.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Interface
{
    public interface IPersonService
    {
        /// <summary>
        /// Получить список всех <see cref="PersonModel"/>
        /// </summary>
        Task<IEnumerable<PersonModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="PersonModel"/> по идентификатору
        /// </summary>
        Task<PersonModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавляет нового работника
        /// </summary>
        Task<PersonModel> AddAsync(WorkerRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Редактирует существующего работника
        /// </summary>
        Task<PersonModel> EditAsync(WorkerRequestModel source, CancellationToken cancellationToken);


        /// <summary>
        /// Удаляет существующего работника
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
