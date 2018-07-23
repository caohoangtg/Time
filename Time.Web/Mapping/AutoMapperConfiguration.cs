using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time.Model;
using Time.Web.ViewModels;

namespace Time.Web.Mapping
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Subject, SubjectViewModel>();
                x.CreateMap<Schedule, ScheduleViewModel>();

                x.CreateMap<Schedule, ScheduleFormViewModel>()
                .ForMember(g => g.Id, map => map.MapFrom(vm => vm.Id))
                .ForMember(g => g.Day, map => map.MapFrom(vm => vm.Day))
                .ForMember(g => g.Time, map => map.MapFrom(vm => vm.Time))
                .ForMember(g => g.Name, map => map.MapFrom(vm => vm.Subject.Name));

                x.CreateMap<ScheduleViewModel, Schedule>()
                .ForMember(g => g.Day, map => map.MapFrom(vm => vm.Day))
                .ForMember(g => g.Time, map => map.MapFrom(vm => vm.Time))
                .ForMember(g => g.SubjectId, map => map.MapFrom(vm => vm.SubId));

                // x.AddProfile<DomainToViewModelMappingProfile>();
                // x.AddProfile<ViewModelToDomainMappingProfile>();
            });

        }
    }
}