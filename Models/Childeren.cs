using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BabyApp.Models
{
    [Table("Childeren")]
    public class Childeren
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "A name is required")]
        public String Name { get; set; }

        public DateTime CreatedTimestamp { get; set; }

        public Nullable<DateTime> UpdatedTimestamp { get; set; }

        public int Active { get; set; }
    }
}