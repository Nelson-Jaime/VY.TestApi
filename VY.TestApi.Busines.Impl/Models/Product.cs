using System;
using System.Collections.Generic;

#nullable disable

namespace VY.TestApi.Aplication.Console.Data
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual User User { get; set; }
    }
}
