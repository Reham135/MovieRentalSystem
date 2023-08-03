using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.model
{
    public class MovieCustomer
    {
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public DateTime Date_Rented { get; set; }
        public DateTime Due_Date { get; set;}




        public override string ToString()
        {
            return $"{Date_Rented}:{Due_Date}:{CustomerId}:{MovieId} ";
        }
    }
}
