﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carousel.Models
{
    public class Slide
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Link { get; set; }
        public int DisplayIndex { get; set; }
    }
}
