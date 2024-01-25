using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Context.Contracts.Models
{
    /// <summary>
    /// Адреса магазинов
    /// </summary>
    public class Location : BaseAuditEntity
    {
        /// <summary>
        /// Город
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// Дом
        /// </summary>
        public string House { get; set; } = string.Empty;

        /// <summary>
        /// Индекс
        /// </summary>
        public int Index { get; set; }
    }
}
