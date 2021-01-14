﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceAPI.Dtos
{
    public class AuctionForAddDto
    {
        public string Name { get; set; }
        public DateTime AddDate { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public AuctionForAddDto()
        {
            AddDate = DateTime.Now;
        }
    }
}