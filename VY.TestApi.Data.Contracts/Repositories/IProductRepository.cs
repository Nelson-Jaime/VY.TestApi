using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY.TestApi.Data.Contracts.Repositories
{
    public interface IProductRepository : IRepository<ProductEntities, Guid>
    {
    }
}
