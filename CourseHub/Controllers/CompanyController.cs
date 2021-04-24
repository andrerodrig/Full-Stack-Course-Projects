using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using CourseHub.Domain.Model;
using CourseHub.Domain.Service;
using CourseHub.Resources;

using AutoMapper;

namespace CourseHub.Controllers
{
    [Route("/api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        public CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CompanyResource>> GetCompanyListAsync(){
            var companies = await _companyService.GetCompanyListAsync();
            var resources = _mapper.Map<IEnumerable<Company>, IEnumerable<CompanyResource>>(companies);
            return resources;
        } 
    }
}