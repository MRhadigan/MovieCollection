using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class Movie : Entertainment
    {
        public int Id { get; set; }

        public string YearMade { get; set; }

        public string Director { get; set; }


        public Movie(int id, string title, string genre, string yearMade, string description, string director)
        {
            this.Id = id;
            this.Title = title;
            this.Genre = genre;
            this.YearMade = yearMade;
            this.Description = description;
            this.Director = director;
        }

        public Movie()
        {
        }
    }
}
