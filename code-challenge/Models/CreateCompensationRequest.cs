using System;

namespace challenge.Models
{
    public class CreateCompensationRequest
    {
        public int Salary { get; set; }

        public DateTime EffectiveDate { get; set; } = DateTime.Now;
    }
}
