﻿using MarketplaceAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketplaceAPI.Data
{
    public class AuctionsRepository : BaseRepository<Auction>, IAuctionsRepository
    {
        public AuctionsRepository(AppDbContext context) : base(context){}

        public async Task<IEnumerable<Auction>> GetByCategory(Category category)
        {
            var auctions = await _context.Auctions.Where(a => a.Category == category).ToListAsync();

            return auctions;
        }
    }
}
