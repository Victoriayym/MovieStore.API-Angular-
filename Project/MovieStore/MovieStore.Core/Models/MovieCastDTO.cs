using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace MovieStore.Core.Entities
{
    public class MovieCastDTO
    {
        
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }
        public CastDTO Cast { get; set; }

        
    }
}
