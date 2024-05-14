using AdeyanjuApplication.Entities.DbSet;
using AdeyanjuApplication.Entities.DTO.Response;
using AutoMapper;

namespace AdeyanjuApplication.API.MappingProfile
{
    public class DomainToResponse : Profile
    {
        public DomainToResponse()
        {
            CreateMap<Pastor, GetPastor>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Occupation, opt => opt.MapFrom(src => src.Occupation))
                .ForMember(dest => dest.BranchName, opt => opt.MapFrom(src => src.BranchName))
                .ForMember(dest => dest.ChurchAddress, opt => opt.MapFrom(src => src.ChurchAddress))
                .ForMember(dest => dest.YearsInService, opt => opt.MapFrom(src => src.YearsInService))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.StateOfOrigin, opt => opt.MapFrom(src => src.StateOfOrigin))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.UserRoleId));

            CreateMap<Evangelist, GetEvangelist>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Occupation, opt => opt.MapFrom(src => src.Occupation))
                .ForMember(dest => dest.PastorInCharge, opt => opt.MapFrom(src => src.PastorInCharge))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.StateOfOrigin, opt => opt.MapFrom(src => src.StateOfOrigin))
                .ForMember(dest => dest.YearsInService, opt => opt.MapFrom(src => src.YearsInService))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.HomeAddress, opt => opt.MapFrom(src => src.HomeAddress))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role));

            CreateMap<Members, GetUser>()
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.EmailAddress, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.HomeAddress, opt => opt.MapFrom(src => src.HomeAddress))
                .ForMember(dest => dest.Occupation, opt => opt.MapFrom(src => src.Occupation))
                .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
                .ForMember(dest => dest.StateOfOrigin, opt => opt.MapFrom(src => src.StateOfOrigin))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role))
                .ForMember(dest => dest.PastorInCharge, opt => opt.MapFrom(src => src.PastorInCharge));

            CreateMap<Announcement, GetAnnouncement>()
                .ForMember(dest => dest.AnnouncementTitle, opt => opt.MapFrom(src => src.AnnouncementTitle))
                .ForMember(dest => dest.AnnouncementDetail, opt => opt.MapFrom(src => src.AnnouncementDetail))
                .ForMember(dest => dest.CoverImageUrl, opt => opt.MapFrom(src => src.CoverImageUrl));

            CreateMap<ChurchActivity, GetChurchActivity>()
                .ForMember(dest => dest.ActivityName, opt => opt.MapFrom(src => src.ActivityName))
                .ForMember(dest => dest.ActivityTime, opt => opt.MapFrom(src => src.ActivityTime))
                .ForMember(dest => dest.ActivityDay, opt => opt.MapFrom(src => src.ActivityDay))
                .ForMember(dest => dest.ActivityDescription, opt => opt.MapFrom(src => src.ActivityDescription));
        }
    }
}
