using System.ComponentModel;

namespace Supermarket.Domain.Helpers
{
    public enum EUnitOfMeasurement : byte
    {
        [Description("UN")]
        Unit = 1,

        [Description("MG")]
        Miligram = 2,
        
        [Description("G")]
        Gram = 3,

        [Description("KG")]
        Kilogram = 4,
        
        [Description("L")]
        Liter = 5
    }
}