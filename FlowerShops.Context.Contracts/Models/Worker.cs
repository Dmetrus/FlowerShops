using FlowerShops.Context.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Context.Contracts.Models
{
    /// <summary>
    /// Работники
    /// </summary>
    public class Worker : BaseAuditEntity
    {
      

        /// <summary>
        /// Тип
        /// </summary>
        public AccessLevelTypes Type { get; set; } = AccessLevelTypes.Client;

        /// <summary>
        /// Номер трудового договора
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// IDПерсоны
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Расположение магазина
        /// </summary>
        public Guid LocationId { get; set; }
    }
}
