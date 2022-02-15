using System;
using System.Collections.Generic;
using VY.TestApi.Dtos;

#nullable disable

namespace VY.TestApi.Aplication.Console.Data
{
    public partial class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual UserDto User { get; set; }
    }
}
