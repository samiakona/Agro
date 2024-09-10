using Agro_Aggregate;
using Agro_DTO;
using Agro_Handler.IHandler;
using Agro_Repository.IRepository;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_Handler
{
    public class LocationHandler : ILocationHandler
    {
        private readonly ILocationRepository _locationRepository;

        public LocationHandler(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        public List<Location> GetLocations()
        {
            var locations = _locationRepository.GetLocation();

            //List<LocationDTO> locationDTOs = new List<LocationDTO>();

            //if (locations.Any())
            //{
            //    foreach (var location in locations)
            //    {
            //        var locationDto = new LocationDTO();

            //        locationDto.LocationName = location.LocationName;
            //        locationDto.LocationAddress = location.LocationAddress;
            //        locationDto.LocationCity = location.LocationCity;
            //        locationDto.Capacity = location.Capacity;
            //        locationDto.Cost = (int)location.Cost;

            //        locationDTOs.Add(locationDto);
            //    }
            //}
            //return locationDTOs;

            return locations;
        }

    }
}
