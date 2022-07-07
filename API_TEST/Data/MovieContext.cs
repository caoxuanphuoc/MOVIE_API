using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_TEST.Models;

namespace API_TEST.Data{
     public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options)
            : base(options)
        {
        }
        public DbSet<API_TEST.Models.Bill>? Bill { get; set; }
        public DbSet<API_TEST.Models.Customer>? Customer { get; set; }
        public DbSet<API_TEST.Models.Food>? Food { get; set; }
        public DbSet<API_TEST.Models.Movie>? Movie { get; set; }

    }
}
   
