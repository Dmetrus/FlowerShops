﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Common.Entity.EntityInterface
{
    /// <summary>
    /// Аудит изменения сущности
    /// </summary>
    public interface IEntityAuditUpdated
    {
        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Кто изменил
        /// </summary>
        public string UpdatedBy { get; set; }
    }
}
