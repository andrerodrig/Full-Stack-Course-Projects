using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using CourseHub.Domain.Model;
using CourseHub.Domain.Service;
using CourseHub.Domain.Repository;
using CourseHub.Domain.Service.Communication;

namespace CourseHub.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CompanyService(ICompanyRepository companyRepository, IUnitOfWork unitOfWork)
        {
            _companyRepository = companyRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Company>> GetCompanyListAsync()
        {
            return await _companyRepository.ListAsync();
        }

        public async Task<Company> GetCompanyDetailAsync(int id)
        {
            return await _companyRepository.DetailAsync(id);
        }

        public async Task<CompanyResponse> SaveAsync(Company company)
        {
            try
            {
                await _companyRepository.AddAsync(company);
                await _unitOfWork.CompleteAsync();

                return new CompanyResponse(company);
            }
            catch(Exception ex)
            {
                // Logging the error.
                return new CompanyResponse($"An error occurred when saving the category {ex.Message}");
            }
        }
    }
}