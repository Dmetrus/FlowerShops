using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShops.Common.Entity.EntityInterface
{
    /// <summary>
    /// Сущность с идентификатором
    /// </summary>
    public interface IEntityWithId
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
    }
}
