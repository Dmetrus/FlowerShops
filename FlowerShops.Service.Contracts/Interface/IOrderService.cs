﻿using FlowerShops.Service.Contracts.ModelRequest;
using FlowerShops.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Interface
{
    public interface IOrderService
    {
        /// <summary>
        /// Получить список всех <see cref="OrderModel"/>
        /// </summary>
        Task<IEnumerable<OrderModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="OrderModel"/> по идентификатору
        /// </summary>
        Task<OrderModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавляет новый заказ
        /// </summary>
        Task<OrderModel> AddAsync(OrderRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Редактирует существующий заказ
        /// </summary>
        Task<OrderModel> EditAsync(OrderRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет существующий заказ
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
