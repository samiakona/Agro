﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agro_DTO
{
    public class LocationDTO
    {
        public string LocationName { get; set; }
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public int Cost { get; set; }
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }
    }
}
