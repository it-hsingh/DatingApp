using System.Linq;
using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser,MemberDto>().ForMember(dest=>dest.PhotoUrl,
             opt=>opt.MapFrom(x=>x.Photos.FirstOrDefault(x=>x.IsMain==true).Url))
             .ForMember(dest => dest.Age, opt=>opt.MapFrom(x=>x.DateOfBirth.CalculateAge()));
            CreateMap<Photo,PhotoDto>();
        }
    }
}