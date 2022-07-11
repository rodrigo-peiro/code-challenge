using challenge.Models;
using System.Threading.Tasks;

namespace challenge.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(string id);
        Compensation GetByEmployeeId(string id);
        Employee Add(Employee employee);
        Compensation Add(Compensation compensation);
        Employee Remove(Employee employee);
        Task SaveAsync();
    }
}