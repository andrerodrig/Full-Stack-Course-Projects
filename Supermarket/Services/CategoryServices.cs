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

        public async Task<SaveCategoryResponse> SaveAsync(Category category)
        {
            try {
                await this.categoryRepository.AddAsync(category);
                await this.unitOfWork.CompleteAsync();
                
                return new SaveCategoryResponse(category);
            }
            catch(Exception ex)
            {
                // Logging the error.
                return new SaveCategoryResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }

        public async Task<SaveCategoryResponse> UpdateAsync(int id, Category category)
        {
            var existingCategory = await this.categoryRepository.FindByIdAsync(id);

            if (existingCategory == null)
                return new SaveCategoryResponse("Category not found");

            existingCategory.Name = category.Name;

            try
            {
                this.categoryRepository.UpdateAsync(existingCategory);
                await unitOfWork.CompleteAsync();
                
                return new SaveCategoryResponse(existingCategory);
            }
            catch(Exception ex)
            {
            return new SaveCategoryResponse($"An error occurred when updating our category: {ex.Message}");
            }
        }
    }
}