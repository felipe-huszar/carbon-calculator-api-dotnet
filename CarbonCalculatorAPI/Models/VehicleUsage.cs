using CarbonCalculatorAPI.Enums;

namespace CarbonCalculatorAPI.Models
{
    public class VehicleUsage 
    {
        public decimal MilesDriven { get; set; }
        public MileageUnitEnum MileageUnit { get; set; }
        public float GasMileage { get; set; }
        public float Reductions { get; set; }
    }
}