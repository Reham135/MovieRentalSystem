using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.model
{
    public class Movie
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        public string Title { get; set; }
        public char? Rating { get; set; }
        public int ProducerId { get;set; }
        public Producer? Producer { get; set; }
        public List<MovieCustomer> MovieCustomers { get; set; }


        public override string ToString()
        {
            return $"{ Duration}:{Rating }:{Title } ";
        }

    }
}
