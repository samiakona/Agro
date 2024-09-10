using Agro_Aggregate;
using Agro_DTO;
using AutoMapper;

namespace Agro
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Location, LocationDTO>().ReverseMap();
        }
    }
}
