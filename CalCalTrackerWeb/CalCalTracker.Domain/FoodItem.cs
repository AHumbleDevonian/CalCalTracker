using CalCalTracker.Domain.Base;

namespace CalCalTracker.Domain
{
    public class FoodItem : CalCalEntity
    {
        public string Name { get; set; }
        public bool IsGlobal { get; set; }
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double SaturatedFat { get; set; }
        public double PolyunsaturatedFat { get; set; }
        public double MonounsaturatedFat { get; set; }
        public double Cholesterol { get; set; }
        public double Carbohydrates { get; set; }
        public double Sugar { get; set; }
        public double Fibre { get; set; }
        public double Protein { get; set; }
        public double VitaminA { get; set; }
        public double VitaminB1 { get; set; }
        public double VitaminB2 { get; set; }
        public double VitaminB3 { get; set; }
        public double VitaminB6 { get; set; }
        public double VitaminB7 { get; set; }
        public double VitaminB12 { get; set; }
        public double PantothenicAcid { get; set; }
        public double FolicAcid { get; set; }
        public double VitaminC { get; set; }
        public double VitaminD { get; set; }
        public double VitaminE { get; set; } 
        public double VitaminK { get; set; }
        public double BetaCarotene { get; set; }
        public double Calcium { get; set; }
        public double Chromium { get; set; }
        public double Cobalt { get; set; }
        public double Copper { get; set; }
        public double Iodine { get; set; }
        public double Iron { get; set; }
        public double Magnesium { get; set; }
        public double Manganese { get; set; }
        public double Molybdenum { get; set; }
        public double Phosphorus { get; set; }
        public double Potassium { get; set; }
        public double Selenium { get; set; }
        public double Sodium { get; set; }
        public double Zinc { get; set; }
    }
}
