using System.ComponentModel.DataAnnotations;

namespace CourseHub.Resources
{
    public class SaveCompanyResource
    {
        [Required]
        [MaxLength(40)]
        public string FantasyName { get; set; }
        [Required]
        [MaxLength(50)]
        public string SocialReason { get; set; }
        [Required]
        [MaxLength(14)]
        public string Cnpj { get; set; }
    }
}