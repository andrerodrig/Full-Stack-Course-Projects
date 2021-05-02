using CourseHub.Domain.Model;

namespace CourseHub.Domain.Service.Communication
{
    public class CompanyResponse : BaseResponse
    {
        public Company Company { get; private set; }

        public CompanyResponse(bool success, string message, Company company): base(success, message)
        {
            Company = company;
        }

        /// <summary>Create a success response.</summary>
        /// <param name="company">Saved Company.</param>
        /// <returns>Response.</returns>
        public CompanyResponse(Company company) : this(true, string.Empty, company)
        {}

        /// <summary>Creates an error message.</summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public CompanyResponse(string message) : this(false, message, null)
        {}

    }
}