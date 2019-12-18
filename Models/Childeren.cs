using System;

namespace BabyApp.Models
{
    public class Childeren
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public Nullable<DateTime> UpdatedTimestamp { get; set; }
        public int Active { get; set; }
    }
}