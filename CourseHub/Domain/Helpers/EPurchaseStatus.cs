using System.ComponentModel;

namespace CourseHub.Domain.Helpers
{
    public enum EPurchaseStatus : byte
    {
        [Description("Unirealized")]
        Un = 1,

        [Description("Error")]
        Er = 2,

        [Description("Success")]
        Su = 3
    }
}