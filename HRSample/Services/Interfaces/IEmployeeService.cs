using HRSample.Models;

namespace HRSample.Services.Interfaces
{
    public interface IEmployeeService
    {
        void CreateEmployee(Employee employee);
        List<Employee> GetAllEmployees();
    }
}
