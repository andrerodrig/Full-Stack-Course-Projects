using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Supermarket.Domain.Models;
using Supermarket.Domain.Services;
using Supermarket.Domain.Services.Communication;
using Supermarket.Domain.Repositories;

namespace Supermarket.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
        } 
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await this.categoryRepository.ListAsync();
        }

        public async Task<CategoryResponse> SaveAsync(Category category)
        {
            try {
                await this.categoryRepository.AddAsync(category);
                await this.unitOfWork.CompleteAsync();
                
                return new CategoryResponse(category);
            }
            catch(Exception ex)
            {
                // Logging the error.
                return new CategoryResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }

        public async Task<CategoryResponse> UpdateAsync(int id, Category category)
        {
            var existingCategory = await this.categoryRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new CategoryResponse("Category not found");

            existingCategory.Name = category.Name;

            try
            {
                this.categoryRepository.Update(existingCategory);
                await unitOfWork.CompleteAsync();
                
                return new CategoryResponse(existingCategory);
            }
            catch(Exception ex)
            {
            return new CategoryResponse($"An error occurred when updating our category: {ex.Message}");
            }
        }

        public async Task<CategoryResponse> DeleteAsync(int id)
        {
            var existingCategory = await this.categoryRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new CategoryResponse("Category no found");

            try
            {
                this.categoryRepository.Remove(existingCategory);
                await this.unitOfWork.CompleteAsync();
                return new CategoryResponse(existingCategory);
            }
            catch(Exception ex)
            {
                return new CategoryResponse($"an error occurred when deleting the category: {ex.Message}");
            }
        }
    }
}