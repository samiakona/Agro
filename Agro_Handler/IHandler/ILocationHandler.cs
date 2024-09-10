using Agro_Aggregate;
using Agro_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Handler.IHandler
{
    public interface ILocationHandler
    {
        List<Location> GetLocations();
    }
}
