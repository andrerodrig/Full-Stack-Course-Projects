using System;

using CourseHub.Domain.Helpers;

using CourseHub.Domain.Model;

namespace CourseHub.Domain.Model
{
    public class Purchase
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime Date { get; set; }
        public EPaymentMethod PaymentMethod { get; set; }
        public EPurchaseStatus PurchaseStatus { get; set; }
        public string Observation { get; set; }
        public string Cep { get; set; }
        public string Address { get; set; }

        public User User { get; set; }
        public Course Course { get; set; }
    }
}