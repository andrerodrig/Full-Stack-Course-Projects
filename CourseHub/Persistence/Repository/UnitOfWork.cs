using System.Threading.Tasks;

using CourseHub.Domain.Repository;
using CourseHub.Persistence.Context;


namespace CourseHub.Persistence.Repository
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