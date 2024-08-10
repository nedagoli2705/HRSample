using HRSample.Data;
using HRSample.Models;
using HRSample.Repositories.Interfaces;

namespace HRSample.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public void Add(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void Update(Employee employee)
        {
            _context.Update(employee);
        }
    }
}
