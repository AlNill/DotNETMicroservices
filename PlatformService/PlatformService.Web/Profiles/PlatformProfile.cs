using AutoMapper;
using PlatformService.Web.Dtos;
using PlatformService.Web.Models;

namespace PlatformService.Web.Profiles;

public class PlatformProfile: Profile
{
    public PlatformProfile()
    {
        CreateMap<Platform, PlatformReadDto>();
        CreateMap<PlatformCreateDto, Platform>();
    }
}
