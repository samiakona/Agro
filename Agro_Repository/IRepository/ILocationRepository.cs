using Agro_Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Repository.IRepository
{
    public interface ILocationRepository
    {
        List<Location> GetLocation();
    }
}
