﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class Paths
    {
        public int Id { get; set; }
        public string path { get; set; }
        public ICollection<object> Words { get; internal set; }
    }
}
