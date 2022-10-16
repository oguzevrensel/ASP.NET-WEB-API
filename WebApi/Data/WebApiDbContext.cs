﻿using Microsoft.EntityFrameworkCore;
using WebApi.Models.Domain;

namespace WebApi.Data
{
    public class WebApiDbContext:DbContext
    {
        public WebApiDbContext(DbContextOptions<WebApiDbContext> options): base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
