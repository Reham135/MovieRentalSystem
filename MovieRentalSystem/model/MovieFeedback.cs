using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.model
{
    public class MovieFeedback

    {
            public int MovieId { get; set; }
            public Movie? Movie { get; set; }
            public int CustomerId { get; set; }
            public Customer Customer { get; set; }
            public int Rating { get; set; }
            public string? Comments { get; set; }
        
    }
}
