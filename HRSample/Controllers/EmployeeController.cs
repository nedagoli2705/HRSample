using AutoMapper;
using HRSample.Models;
using HRSample.Services.Interfaces;
using HRSample.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Threading.Tasks;

namespace HRSample.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(ILogger<EmployeeController> logger,
            IEmployeeService employeeService,
            IMapper mapper)
        {
            _logger = logger;
            _employeeService = employeeService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index action has been called.");
            var employees = _employeeService.GetAllEmployees();
            var employeeViewModels = _mapper.Map<IEnumerable<EmployeeViewModel>>(employees);
            return View(employeeViewModels);
        }

        public IActionResult Create()
        {
            _logger.LogInformation("Create action has been called.");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeService.CreateEmployee(employee);

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
