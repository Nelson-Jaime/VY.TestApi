using System;
using System.Collections.Generic;

#nullable disable

namespace VY.TestApi.Data.Contracts
{
    public partial class UserEntities
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ProductEntities Fk_Product { get; set; }
    }
}
