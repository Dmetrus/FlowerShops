using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Models
{
    public class OrderModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Номер клиента
        /// </summary>
        public PersonModel Client { get; set; }

        /// <summary>
        /// Номер продавца
        /// </summary>
        public PersonModel Seller { get; set; }

        /// <summary>
        /// Выбранная услуга
        /// </summary>
        public ServiceModel? Service { get; set; }

        /// <summary>
        /// Выбранный товар 
        /// </summary>
        public ProductModel? Product { get; set; }

        /// <summary>
        /// Время заказа
        /// </summary>
        public DateTime OrderTime { get; set; }
    }
}
