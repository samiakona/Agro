using Agro_Aggregate;
using Agro_Repository.Data;
using Agro_Repository.IRepository;

namespace Agro_Repository.Repositroy
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext _context;

        public LocationRepository(ApplicationDbContext context)
        {
            _context = context;      
        }

        public List<Location> GetLocation()
        {
            var location = _context.Locations.ToList();
            return location;
        }
    }
}
