using AutoMapper;
using Domain.Entities;
using Web.Models;

namespace Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<InTask, InTaskViewModel>();
            Mapper.CreateMap<Status, StatusViewModel>();
        }
    }
}
