using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Web.Models;
using Domain.Entities;
using System.Web;

namespace Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<InTaskViewModel, InTask>();
            Mapper.CreateMap<StatusViewModel, Status>();
        }
    }
}