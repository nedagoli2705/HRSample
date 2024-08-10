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
            var employeesViewModel = _mapper.Map<IEnumerable<EmployeeViewModel>>(employees);
            return View(employeesViewModel);
        }

        public IActionResult Create()
        {
            _logger.LogInformation("Create action has been called.");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _logger.LogInformation("Creation is going to be done.");
            _employeeService.CreateEmployee(employee);

            return View();
        }

        public IActionResult Edit(int id)
        {
            var employee =  _employeeService.GetEmployeeById(id);
            if (employee == null)
            {
                _logger.LogError("Employee for edit not found");
                return NotFound();
            }
            var employeeViewModel = _mapper.Map<IEnumerable<EmployeeViewModel>>(employee);

            return PartialView("_EditPartialView", employeeViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
