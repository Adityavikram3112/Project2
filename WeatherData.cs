﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class WeatherData
    {
        public class main
        {
            public double temp_max { get; set; }
            public double temp_min { get; set; }
        }

        public class wind
        {
            public float speed { get; set; }

            public float deg { get; set; }
        }


        public class root
        {
            public main main { get; set; }
            public wind wind { get; set; }
        }

    }
}
