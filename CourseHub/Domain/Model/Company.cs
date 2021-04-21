using System.Collections.Generic;

namespace CourseHub.Domain.Model
{
    public class Company
    {
        public int Id { get; set; }
        public string FantasyName { get; set; }
        public string SocialReason { get; set; }
        public string Cnpj {get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}