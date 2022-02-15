using System;
using VY.TestApi.Aplication.Console.Data;

namespace VY.TestApi.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ProductDto fk_Product { get; set; }
    }
}
