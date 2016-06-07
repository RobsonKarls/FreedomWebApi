
using System;
using Freedom.Domain.Core;

namespace Freedom.Domain.Entities
{
    public class Farm : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
