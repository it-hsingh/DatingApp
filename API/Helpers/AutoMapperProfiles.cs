using System.Linq;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser,MemberDto>().ForMember(dest=>dest.PhotoUrl,
             opt=>opt.MapFrom(x=>x.Photos.FirstOrDefault(x=>x.IsMain==true).Url));
            CreateMap<Photo,PhotoDto>();
        }
    }
}