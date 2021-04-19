using System.Threading.Tasks;
using System.Collections.Generic;

using Supermarket.Domain.Models;
using Supermarket.Domain.Services.Communication;

namespace Supermarket.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}