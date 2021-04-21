using System.Threading.Tasks;
using System.Collections.Generic;

using CourseHub.Domain.Model;
using CourseHub.Domain.Service;
using CourseHub.Domain.Repository;

namespace CourseHub.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public async Task<IEnumerable<Company>> GetCompanyListAsync()
        {
            return await _companyRepository.ListAsync();
        }
    }
}