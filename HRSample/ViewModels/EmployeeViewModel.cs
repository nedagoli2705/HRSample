using HRSample.Models;

namespace HRSample.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime CreatedDate { get; set; }


        public List<Salary> EmployeeSalaries { get; set; }
    }
}
