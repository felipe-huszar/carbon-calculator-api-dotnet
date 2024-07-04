using CarbonCalculatorAPI.Enums;

namespace CarbonCalculatorAPI.Models 
{
    public class HomeEnergyUsage
    {
        public decimal NaturalGasAmount { get; set; }
        public UsageUnitEnum NaturalGasUnit { get; set; }
        public decimal ElectricityAmount { get; set; }
        public decimal ElectricityGreenPercentage { get; set; }
        public decimal FuelOilAmount { get; set; }
        public UsageUnitEnum FuelOilUnit { get; set; }
        public decimal PropaneAmount { get; set; }
        public UsageUnitEnum PropaneUnit { get; set; }
        public required HomeEnergyReductions Reductions { get; set; }
    }
}