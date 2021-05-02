using System.Threading.Tasks;
using System.Collections.Generic;

using CourseHub.Domain.Model;
using CourseHub.Domain.Service.Communication;

namespace CourseHub.Domain.Service
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetCompanyListAsync();
        Task<Company> GetCompanyDetailAsync(int id);
        Task<CompanyResponse> SaveAsync(Company company);
    }
}