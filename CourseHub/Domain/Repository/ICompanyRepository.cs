using System.Threading.Tasks;
using System.Collections.Generic;

using CourseHub.Domain.Model;

namespace CourseHub.Domain.Repository
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> ListAsync();
    }
}