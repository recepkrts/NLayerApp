using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime InsertDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public string? Status { get; set; }
    }
}
