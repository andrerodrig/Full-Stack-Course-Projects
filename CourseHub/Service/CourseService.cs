using System.Threading.Tasks;
using System.Collections.Generic;

using CourseHub.Domain.Model;
using CourseHub.Domain.Service;
using CourseHub.Domain.Repository;

namespace CourseHub.Service
{
    public class CourseService : ICourseService
    {

        private readonly CourseRepository _courseRepository;
        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task<IEnumerable<Course>> GetCoursesListAsync()
        {
            return await _courseRepository.ListAsync(); 
        }
    }
}