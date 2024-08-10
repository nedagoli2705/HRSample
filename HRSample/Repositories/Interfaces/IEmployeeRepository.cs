using HRSample.Models;

namespace HRSample.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        void Add(Employee employee);
        void Update(Employee employee);
        List<Employee> GetEmployees(); 
        Employee GetById(int id);   
    }
}
