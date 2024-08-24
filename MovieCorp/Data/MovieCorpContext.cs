using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCorp.Models;

namespace MovieCorp.Data
{
    public class MovieCorpContext : DbContext
    {
        public MovieCorpContext (DbContextOptions<MovieCorpContext> options)
            : base(options)
        {
        }

        public DbSet<MovieCorp.Models.Movie> Movie { get; set; } = default!;
    }
}
