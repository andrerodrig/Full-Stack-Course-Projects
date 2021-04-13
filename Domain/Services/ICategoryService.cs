using System.Threading.Tasks;
using System.Collections.Generic;

using Supermarket.Domain.Models;

namespace Supermarket.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}