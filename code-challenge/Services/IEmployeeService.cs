using challenge.Models;
using System;

namespace challenge.Services
{
    public interface IEmployeeService
    {
        Employee GetById(string id);
        Compensation GetByEmployeeId(string id);
        ReportingStructure GetReportStructureById(string id);
        Employee Create(Employee employee);
        Compensation Create(Compensation compensation);
        Employee Replace(Employee originalEmployee, Employee newEmployee);
    }
}
