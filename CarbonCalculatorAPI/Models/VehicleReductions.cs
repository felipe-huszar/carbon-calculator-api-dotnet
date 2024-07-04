using CarbonCalculatorAPI.Enums;

namespace CarbonCalculatorAPI.Models
{
    public class VehicleReductions 
    {
        public decimal ReducedMiles { get; set; }
        public MileageUnitEnum ReducedMilesUnit { get; set;}
        public decimal MilesperGaloonVehicleReplacement { get; set; }
    }

    
}