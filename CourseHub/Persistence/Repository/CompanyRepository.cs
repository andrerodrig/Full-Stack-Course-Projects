using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using CourseHub.Domain.Model;
using CourseHub.Domain.Repository;
using CourseHub.Persistence.Context;

namespace CourseHub.Persistence.Repository
{
    public class CompanyRepository : BaseRepository, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context) {}

        public async Task<IEnumerable<Company>> ListAsync()
        {
            return await this.context.Companies.ToListAsync();
        }
    }
}