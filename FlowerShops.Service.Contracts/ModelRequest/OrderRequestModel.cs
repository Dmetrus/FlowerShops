using FlowerShops.Service.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.ModelRequest
{
    public class OrderRequestModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер клиента
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// Номер продавца
        /// </summary>
        public Guid SellerId { get; set; }

        /// <summary>
        /// Выбранная услуга
        /// </summary>
        public Guid? ServiceId { get; set; }

        /// <summary>
        /// Выбранный товар 
        /// </summary>
        public Guid? ProductId { get; set; }

        /// <summary>
        /// Время заказа
        /// </summary>
        public DateTime OrderTime { get; set; }
    }
}
