using System.Threading.Tasks;
using System.Collections.Generic;

using Supermarket.Domain.Models;
using Supermarket.Domain.Repositories;
using Supermarket.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Supermarket.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository   
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await this.context.Categories.ToListAsync(); 
        }

        public async Task AddAsync(Category category)
        {
            await this.context.Categories.AddAsync(category);
        }

        public async Task<Category> FindByIdAsync(int id)
        {
            return await this.context.Categories.FindAsync(id);
        }

        public void Update(Category category)
        {
            this.context.Categories.Update(category);
        }

        public void Remove(Category category)
        {
            this.context.Categories.Remove(category);
        }
    }
}