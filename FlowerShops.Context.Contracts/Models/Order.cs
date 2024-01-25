using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Context.Contracts.Models
{
    public class Order : BaseAuditEntity
    {

        /// <summary>
        /// IDКлиента
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// IDРаботника
        /// </summary>
        public Guid WorkerId { get; set; }

        /// <summary>
        /// IDУслуги
        /// </summary>
        public Guid? ServiceId { get; set; }

        /// <summary>
        /// IDТовара
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime OrderTime { get; set; } = DateTime.UtcNow;
    }
}
