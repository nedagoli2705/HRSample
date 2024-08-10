using HRSample.Models;
using HRSample.Repositories.Interfaces;
using HRSample.Services.Interfaces;

namespace HRSample.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void CreateEmployee(Employee employee)
        {
            employee.CreatedDate = DateTime.Now;
            _employeeRepository.Add(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetEmployees();
        }
    }
}
