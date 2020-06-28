using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeloturgWasm.Shared
{
    public class Ad
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Email { get; set; }
        public string FrameSize { get; set; }
        public string Type { get; set; }
        public Location Location { get; set; }
        public ImageLink[] Images { get; set; }

    }
}
