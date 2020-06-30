﻿using AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace TechEvalBert.Models
{
    public class Photo
    {
        public int id { get; set; }
        public int albumId { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}
