using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.model
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? BirthDate { get; set; }
        public int PhoneNumber { get; set; }
        public List<MovieCustomer>? CustomerMovies { get; set; }



        public override string ToString()
        {
            return $"{FirstName}:{LastName}:{Address}:{BirthDate}:{PhoneNumber} ";
        }

    }
}
