using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Entity
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string? Status { get; set; }

    }
}
