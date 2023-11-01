using PlatformService.Web.Models;

namespace PlatformService.Web.Data.Interfaces;

public interface IPlatformRepo
{
    bool SaveChanges();
    IEnumerable<Platform> GetAllPlatforms();
    Platform GetPlatformById(int id);
    void CreatePlatform(Platform platform);
}
