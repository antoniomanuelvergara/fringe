﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avergara.Fringe.Application.DTO
{
    public class TypeFringeDto: BaseDto
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public int CategoryFringeId { get; set; }
    }
}
