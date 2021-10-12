using System.Collections.Generic;
using System.Threading.Tasks;
using PlatformService.Models;

namespace PlatformService.Data
{

    public interface IPlatformRepo
    {
        bool SaveChanges();
        bool IsModified(Platform platform);
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatPlatform(Platform plat);
        Task<Platform> UpdatePlatform(Platform plat);
        Task SaveChangesAsync();

    }
}