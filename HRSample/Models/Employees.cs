namespace HRSample.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public DateTime CreatedDate { get; set; }


        public List<Salaries> EmployeeSalariess { get; set; }
    }
}
