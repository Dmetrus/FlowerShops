using FlowerShops.Service.Contracts.ModelRequest;
using FlowerShops.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Interface
{
    public interface IWorkerService
    {
        /// <summary>
        /// Получить список всех <see cref="WorkerModel"/>
        /// </summary>
        Task<IEnumerable<WorkerModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="WorkerModel"/> по идентификатору
        /// </summary>
        Task<WorkerModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавляет нового работника
        /// </summary>
        Task<WorkerModel> AddAsync(WorkerRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Редактирует существующего работника
        /// </summary>
        Task<WorkerModel> EditAsync(WorkerRequestModel source, CancellationToken cancellationToken);


        /// <summary>
        /// Удаляет существующего работника
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
