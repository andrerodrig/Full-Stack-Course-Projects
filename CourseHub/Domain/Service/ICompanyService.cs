using System.Threading.Tasks;
using System.Collections.Generic;

using CourseHub.Domain.Model;

namespace CourseHub.Domain.Service
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetCompanyListAsync();
    }
}