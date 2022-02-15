using System;
using System.Collections.Generic;

#nullable disable

namespace VY.TestApi.Aplication.Console.Data
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual Product fk_Product { get; set; }
    }
}
