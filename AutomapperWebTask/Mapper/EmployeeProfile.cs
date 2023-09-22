﻿using AutoMapper;
using AutoMapperDAL.Entities;
using AutomapperWebTask.Models;
using Microsoft.AspNetCore.Routing.Constraints;

namespace AutomapperWebTask.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeViewModel>()
            .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.EmployeeId))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
            .ForMember(dest => dest.DepartmentId, opt => opt.MapFrom(src => src.DepartmentId))
            .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name))
            .ReverseMap()
            .ForMember(src => src.Department, opt => opt.Ignore());


        }
    }
}