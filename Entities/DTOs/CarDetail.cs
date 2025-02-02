﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.DTOs
{
    public class CarDetail : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ColorName { get; set; }
        public string CategoryName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int ModelYear { get; set; }
    }
}
