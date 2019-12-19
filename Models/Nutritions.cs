using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyApp.Models
{
    [Table("Nutritions")]
    public class Nutritions
    {
        public long Id { get; set; }

        public DateTime CreatedTimestamp { get; set; }

        public Nullable<DateTime> UpdatedTimestamp { get; set; }

        [Required(ErrorMessage = "A nutrition value is required.")]
        public int NutritionValue { get; set; }

        public virtual Childeren Childeren { get; set; }
    }
}