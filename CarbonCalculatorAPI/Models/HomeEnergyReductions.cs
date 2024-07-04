using CarbonCalculatorAPI.Enums;

namespace CarbonCalculatorAPI.Models 
{
    public class HomeEnergyReductions
    {
        public int ReduceThermostatSummerDegrees { get; set; }
        public int ReduceThermostatWinterNightsDegrees { get; set; }
        public int LedBulbsReplacementCount { get; set; }
        public ReductionCommitmentEnum EnablePowerManagementOnPCCommitment { get; set; }
        public decimal GreenPowerUsageIncrease { get; set; }
        public ReductionCommitmentEnum washingClothesColdWaterCommitment { get; set; }
        public int WashingClothesColdWaterLoadsPerWeek { get; set; }
        public ReductionCommitmentEnum LineDryClothingCommitment { get; set; }
        public decimal LineDryClothingPercentage { get; set; }
        public ReductionCommitmentEnum EnergyStarRefrigeratorCommitment { get; set; }
        public ReductionCommitmentEnum EnergyStarFurnaceCommitment { get; set; }
        public ReductionCommitmentEnum EnergyStarWindowsCommitment { get; set; }
    }
}