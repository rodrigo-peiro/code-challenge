namespace challenge.Models
{
    public class ReportingStructure
    {
        Employee _employee;

        public ReportingStructure(Employee employee)
        {
            _employee = employee;
        }
        
        public Employee Employee 
        { 
            get => _employee; 
            set => _employee = value; 
        }

        public int NumberOfReports 
        { 
            get
            {               
                return (int)GetDirectReports(_employee);
            }
        }

        private int? GetDirectReports(Employee employee)
        {
            var totalDirectReports = employee.DirectReports?.Count;

            if (totalDirectReports > 0)
            {
                foreach (var directReport in employee.DirectReports)
                {
                    if (directReport.DirectReports?.Count > 0)
                    {
                        totalDirectReports += GetDirectReports(directReport);
                    }
                }
            }

            return totalDirectReports;
        }
    }    
}
