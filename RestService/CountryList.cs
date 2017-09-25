﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestService
{
    public class Country
    {
       
            public string name { get; set; }
            public string alpha2_code { get; set; }
            public string alpha3_code { get; set; }
        
    }
    public class CountryList
    {
        public List<Country> Countries { get; set; }
    }
    
}
