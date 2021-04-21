using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using CourseHub.Domain.Model;
using CourseHub.Domain.Service;

namespace CourseHub.Controllers
{
    [Route("/api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<IEnumerable<Company>> GetCompanyListAsync() => 
            await _companyService.GetCompanyListAsync();
    }
}