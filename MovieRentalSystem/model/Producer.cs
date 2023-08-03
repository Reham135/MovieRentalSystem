using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem.model
{
    public class Producer
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string CompanyName { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
