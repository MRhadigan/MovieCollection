using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class Show : Entertainment
    {
        public int Id { get; set; }

        public string YearsMade { get; set; }

        public string Creator { get; set; }
    }
}
