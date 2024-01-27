using FlowerShops.Service.Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Service.Contracts.Models
{
    public class WorkerModel
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public AccessLevelTypesModel Type { get; set; } = AccessLevelTypesModel.Client;

        /// <summary>
        /// Номер трудового договора
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// IDПерсоны
        /// </summary>
        public PersonModel Person { get; set; }

        /// <summary>
        /// Расположение магазина
        /// </summary>
        public LocationModel Location { get; set; }
    }
}
