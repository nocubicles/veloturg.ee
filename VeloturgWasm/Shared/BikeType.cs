using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloturgWasm.Shared
{
    public class BikeType
    {
        public List<string> Types { get; set; } = new List<string>
        {
            "Maantee",
            "Maastiku",
            "Tänava",
            "Elektri",
            "Hübriid",
            "Cyclocross"
        };
    }
}
