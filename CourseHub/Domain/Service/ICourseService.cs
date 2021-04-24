using System.Collections.Generic;
using System.Threading.Tasks;

using CourseHub.Domain.Model;

namespace CourseHub.Domain.Service
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetCoursesListAsync();
    }
}