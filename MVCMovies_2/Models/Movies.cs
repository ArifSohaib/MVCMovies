using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MVCMovies_2.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name="Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}",ApplyFormatInEditMode=true)]
        public DateTime ReleaseDate { get; set; }

        public string Genere { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
    }
}