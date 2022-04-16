﻿namespace CommonApp.Server;
public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        CreateMap<Group, GroupViewModel>().ReverseMap();
    }
}