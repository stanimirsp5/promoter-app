using System;
using AutoMapper;
using promotersapp.Models;

namespace promotersapp.ViewModels
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Promoter, PromoterDto>() // map from Promoter to PromoterDto
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City.CityName))
                .ForMember(dest => dest.Perks, opt => opt.MapFrom(src => src.PerksToPromoters))
                ;
            CreateMap<PromoterDto, Promoter>();

            CreateMap<Schedule, ScheduleDto>();
            CreateMap<ScheduleDto, Schedule>();

            CreateMap<Discussion, DiscussionDto>();
            CreateMap<DiscussionDto, Discussion>();

            CreateMap<Perk, PerkDto>();
            CreateMap<PerkDto, Perk>();

            CreateMap<PersonalDetail, PersonalDetailDto>();
            CreateMap<PersonalDetailDto, PersonalDetail>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Firm, FirmDto>();
            CreateMap<FirmDto, Firm>();
            
            CreateMap<PerksToPromoter, PerkDto>()
                 .ForMember(dest => dest.PerkName, opt => opt.MapFrom(src => src.Perk.PerkName));

            CreateMap<PerksToPromoter, PerksToPromoterDto>();
            CreateMap<PerksToPromoterDto, PerksToPromoter>();

            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>();
        }
    }
}
