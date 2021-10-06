using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context;

        }
        public void CreatPlatform(Platform plat)
        {
            if (plat == null)
            {
                throw new ArgumentNullException(nameof(plat));
            }

            _context.Platforms.Add(plat);

        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(p => p.Id == id);

        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public async Task<Platform> UpdatePlatform(Platform updatedPlat)
        {
            var platform = await _context.Platforms.FirstOrDefaultAsync(p => p.Id == updatedPlat.Id);

            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }

            platform.Name = updatedPlat.Name;
            platform.Cost = updatedPlat.Cost;
            platform.Publisher = updatedPlat.Publisher;

            return platform;

        }
    }
}