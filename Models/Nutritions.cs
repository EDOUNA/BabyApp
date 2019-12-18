using System;

namespace BabyApp.Models
{
    public class Nutritions
    {
        public Int64 Id { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public Nullable<DateTime> UpdatedTimestamp { get; set; }
        public int NutritionValue { get; set; }
    }
}