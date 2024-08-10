using HRSample.Models;

namespace HRSample.Repositories.Interfaces
{
    public interface ISalaryRepository
    {
        void AddSalaryToEmployee(Salary salary, int employeeId);
    }
}
