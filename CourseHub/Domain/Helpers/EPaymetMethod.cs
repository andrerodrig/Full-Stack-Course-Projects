using System.ComponentModel;

namespace CourseHub.Domain.Helpers
{
    public enum EPaymentMethod : byte
    {
        [Description("Boleto")]
        Boleto = 1
    }
}