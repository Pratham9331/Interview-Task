using AutoMapper;
using AutoMapperDAL.Entities;
using AutomapperWebTask.Models;

namespace AutomapperWebTask.Mapper
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            //src => dest
            CreateMap<Department, DepartmentViewModel>()
                           .ForMember(dest => dest.DepartmentId,
                           opt => opt.MapFrom(src => src.DepartmentId))
                           .ForMember(dest => dest.Name,
                           opt => opt.MapFrom(src => src.Name))
                           .ReverseMap(); //dest => src
        }
    }
}
