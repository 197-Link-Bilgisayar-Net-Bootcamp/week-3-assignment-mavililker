﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerService
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List <string> Errors { get; set; }

        public int Status { get; set; }

    }
}
