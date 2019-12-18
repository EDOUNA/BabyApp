using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BabyApp.Models
{
    public class Nutritions
    {
        public int Id { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public Nullable<DateTime> UpdatedTimestamp { get; set; }
    }
}
