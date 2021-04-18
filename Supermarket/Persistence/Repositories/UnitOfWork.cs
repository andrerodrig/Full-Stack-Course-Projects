using System.Threading.Tasks;

using Supermarket.Domain.Repositories;
using Supermarket.Persistence.Context;

namespace Supermarket.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext context;
        public UnitOfWork(AppDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    } 
}