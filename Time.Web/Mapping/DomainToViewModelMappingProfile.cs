using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time.Model;
using Time.Web.ViewModels;

namespace Time.Web.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        //protected override void Configure()
        //{
        //    Mapper.CreateMap<Subject, SubjectViewModel>();
        //    Mapper.CreateMap<Schedule, ScheduleViewModel>();
        //    Mapper.CreateMap<Schedule, ScheduleFormViewModel>()
        //        .ForMember(g => g.Id, map => map.MapFrom(vm => vm.Id))
        //        .ForMember(g => g.Day, map => map.MapFrom(vm => vm.Day))
        //        .ForMember(g => g.Time, map => map.MapFrom(vm => vm.Time))
        //        .ForMember(g => g.Name, map => map.MapFrom(vm => vm.Subject.Name));
        //}
    }
}