﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTestApp1.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime? CreatedTime { get; set; }
        public double Double { get; set; }
        public float Float { get; set; }
    }
}