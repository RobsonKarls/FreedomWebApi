using System;
using Freedom.Domain.Core;
using Freedom.Domain.Enum;

namespace Freedom.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public MeasureUnit MeasureUnit { get; set; }
        public double Size { get; set; }
        public Farm Farm { get; set; }
        public int FarmId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
