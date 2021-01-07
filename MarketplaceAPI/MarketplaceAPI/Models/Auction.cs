﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceAPI.Models
{
    public class Auction : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Description { get; set; }
        public ICollection<Photo> Photos { get; set; }

    }
}
