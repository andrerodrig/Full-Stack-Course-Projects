using System.Collections.Generic;
using System.Threading.Tasks;

using CourseHub.Domain.Model;

namespace CourseHub.Domain.Repository
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> ListAsync();
    }
}