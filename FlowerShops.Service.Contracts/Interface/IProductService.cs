﻿using FlowerShops.Service.Contracts.ModelRequest;
using FlowerShops.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Interface
{
    public interface IProductService
    {
        /// <summary>
        /// Получить список всех <see cref="ProductModel"/>
        /// </summary>
        Task<IEnumerable<ProductModel>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получить <see cref="ProductModel"/> по идентификатору
        /// </summary>
        Task<ProductModel?> GetByIdAsync(Guid id, CancellationToken cancellationToken);


        /// <summary>
        /// Добавляет новый компонент
        /// </summary>
        Task<ProductModel> AddAsync(ProductRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Редактирует существующий компонент
        /// </summary>
        Task<ProductModel> EditAsync(ProductRequestModel source, CancellationToken cancellationToken);

        /// <summary>
        /// Удаляет существующий компонент
        /// </summary>
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
