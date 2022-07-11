using System;
using System.ComponentModel.DataAnnotations;

namespace challenge.Models
{
    public class Compensation
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Employee Employee { get; set; }

        public int Salary { get; set; }

        public DateTime EffectiveDate { get; set; }
    }
}
