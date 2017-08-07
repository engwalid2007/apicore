﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesWebApi.Models
{
    public class CityModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<PointOfInterstModel> States { get; set; }
    }
}
