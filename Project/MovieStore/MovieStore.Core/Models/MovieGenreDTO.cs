using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Entities
{
    public class MovieGenreDTO
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
        //navigation properties
      
        public virtual GenreDTO Genre { get; set; }
    }
}
