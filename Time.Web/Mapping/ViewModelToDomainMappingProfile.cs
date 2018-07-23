using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time.Model;
using Time.Web.ViewModels;

namespace Time.Web.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        //protected override void Configure()
        //{
        //    Mapper.CreateMap<ScheduleFormViewModel, Schedule>()
        //        .ForMember(g => g.Day, map => map.MapFrom(vm => vm.Day))
        //        .ForMember(g => g.Time, map => map.MapFrom(vm => vm.Time))
        //        .ForMember(g => g.SubjectId, map => map.MapFrom(vm => vm.SubId));
        //}
    }
}