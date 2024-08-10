using AutoMapper;
using HRSample.Models;
using HRSample.ViewModels;

namespace HRSample.AutoMapperProfile
{
    public class EmployeeDepartmentProfile : Profile
    {
        public EmployeeDepartmentProfile()
        {
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(x => x.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}")); 
        }
    }
}
