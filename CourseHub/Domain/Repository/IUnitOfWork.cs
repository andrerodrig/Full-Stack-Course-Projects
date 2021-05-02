using System.Threading.Tasks;

namespace CourseHub.Domain.Repository
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}