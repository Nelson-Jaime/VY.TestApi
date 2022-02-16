using System;
using System.Collections.Generic;

#nullable disable

namespace VY.TestApi.Busines.Contracts.Domain
{
    public partial class UserModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ProductModel Fk_Product { get; set; }
    }
}
