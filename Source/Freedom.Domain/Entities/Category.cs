
using System;
using System.Data.SqlTypes;
using Freedom.Domain.Core;

namespace Freedom.Domain.Entities
{

    public class Category : Entity, IAggregateRoot
    {
        public string Title { get; set; }
        public Category Parent { get; set; }
        public int? ParentId { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public bool IsNull { get; }
    }
}
