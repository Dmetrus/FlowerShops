using FlowerShops.Context.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Context.Contracts.Models
{
    /// <summary>
    /// Товары
    /// </summary>
    public class Product : BaseAuditEntity

    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public ProductTypes Type { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; } = 0;

        /// <summary>
        /// Описание
        /// </summary>
        public string? Description { get; set; }
    }
}
