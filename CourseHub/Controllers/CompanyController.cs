using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

using CourseHub.Domain.Model;
using CourseHub.Domain.Service;
using CourseHub.Resources;
using CourseHub.Extensions;

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

        [HttpGet("{id}")]
        public async Task<Company> GetCompanyDetailAsync(int id)
        {
            var company = await _companyService.GetCompanyDetailAsync(id);
            return company;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCompanyResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var company = _mapper.Map<SaveCompanyResource, Company>(resource);
            var result = await _companyService.SaveAsync(company);

            if (!result.Success)
                return BadRequest(result.Message);

            var CompanyResource = _mapper.Map<Company, CompanyResource>(result.Company);
            return Ok(CompanyResource);
        }      
    }
}