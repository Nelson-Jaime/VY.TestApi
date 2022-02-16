using System;
using System.Collections.Generic;

#nullable disable

namespace VY.TestApi.Busines.Contracts.Domain
{
    public partial class ProductModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual UserModel User { get; set; }
    }
}
