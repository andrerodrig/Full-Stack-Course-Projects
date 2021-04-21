namespace CourseHub.Domain.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public string Observation { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}