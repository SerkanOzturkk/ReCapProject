﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entites;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ModelYear { get; set; }
    }
}
