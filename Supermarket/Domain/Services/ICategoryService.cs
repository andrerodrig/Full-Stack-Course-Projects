using System.Threading.Tasks;
using System.Collections.Generic;

using Supermarket.Domain.Models;
using Supermarket.Domain.Services.Communication;

namespace Supermarket.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
    }
}