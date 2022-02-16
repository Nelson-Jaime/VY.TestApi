using System;
using System.Collections.Generic;

#nullable disable

namespace VY.TestApi.Data.Contracts
{
    public partial class ProductEntities
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual UserEntities User { get; set; }
    }
}
