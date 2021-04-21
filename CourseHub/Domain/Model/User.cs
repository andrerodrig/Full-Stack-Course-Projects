using System.Collections.Generic;

namespace CourseHub.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public List<Purchase> PurchaseList { get; set;} = new List<Purchase>();
    }
}