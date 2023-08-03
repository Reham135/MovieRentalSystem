using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieRentalSystem.model;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace MovieRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CyberDBContext db = new CyberDBContext();
            //db.Database.Migrate();

            #region add data to Producer table
            //db.Producers.AddRange(
            //    new MovieRentalSystem.model.Producer() { CompanyName = "EGCompany", Country = "Egypt" },
            //    new Producer() { CompanyName = "FRCompany", Country = "France" },
            //    new Producer() { CompanyName = "JACompany", Country = "Japan" },
            //    new Producer() { CompanyName = "CHCompany", Country = "China" });
            //db.SaveChanges();
            #endregion

            #region add data to Customer table
            //db.Customers.Add(
            //    new MovieRentalSystem.model.Customer() { FirstName = "Reham", LastName = "Ahmed", Address = "Suez", PhoneNumber = 012000 });
            //db.SaveChanges();

            //db.Customers.AddRange(
            //    new MovieRentalSystem.model.Customer() { FirstName = "Ethar", LastName = "Abdelrahman", Address = "Cairo", PhoneNumber = 015000,BirthDate=new DateTime(1998,1,1) },
            //    new MovieRentalSystem.model.Customer() { FirstName = "Manar", LastName = "Ahmed", Address = "Mansoura", PhoneNumber = 018000, BirthDate = new DateTime(2000, 11, 28) });
            //db.SaveChanges();
            #endregion

            #region add data to Movie TAble
            //db.Movies.AddRange(
            //    new MovieRentalSystem.model.Movie() {Title="HarryBotter",Duration=120,Rating='5',ProducerId=1 },
            //    new MovieRentalSystem.model.Movie() { Title = "Elgzera", Duration = 200, Rating = '6', ProducerId = 3 },
            //    new MovieRentalSystem.model.Movie() { Title = "Darbt Haz",Duration = 160,Rating = '3',ProducerId = 4 },
            //    new MovieRentalSystem.model.Movie() { Title = "GreenMan",Duration = 100,Rating = '4',ProducerId = 2 },
            //    new MovieRentalSystem.model.Movie() { Title = "SuperMan",Duration = 420,Rating = '8',ProducerId = 2 },
            //    new MovieRentalSystem.model.Movie() { Title = "SpiderMan",Duration = 105,Rating = '7',ProducerId = 2 },
            //    new MovieRentalSystem.model.Movie() { Title = "BatMan",Duration = 115,Rating = '9',ProducerId = 2 });
            //db.SaveChanges();
            #endregion

            #region add Rentals to MovieCustomer Table
            //db.MovieCustomers.Add(new MovieCustomer() { CustomerId = 2, MovieId = 1, Date_Rented =new (2023,6,3),Due_Date=new(2023,6,4) });
            //db.SaveChanges();
            //db.MovieCustomers.Add(new MovieCustomer() { CustomerId = 2, MovieId = 3, Date_Rented = new(2023, 6, 18), Due_Date = new(2023, 6, 19) });
            //db.SaveChanges();
            //db.MovieCustomers.AddRange(
            //    new MovieCustomer() { CustomerId = 2, MovieId = 2, Date_Rented = new DateTime(2023, 6, 1, 3, 30, 0), Due_Date = new DateTime(2023, 6, 1, 10, 30, 0) },
            //    new MovieCustomer() { CustomerId = 4, MovieId = 4, Date_Rented = new DateTime(2023, 6, 2, 8, 0, 0), Due_Date = new DateTime(2023, 6, 3, 8, 0, 0) },
            //    new MovieCustomer() { CustomerId = 4, MovieId = 5, Date_Rented = new DateTime(2023, 6, 4, 3, 30, 0), Due_Date = new DateTime(2023, 6, 4, 9, 30, 0) },
            //    new MovieCustomer() { CustomerId = 4, MovieId = 6, Date_Rented = new DateTime(2023, 6, 5, 11, 30, 0), Due_Date = new DateTime(2023, 6, 6, 0, 0, 0) },
            //    new MovieCustomer() { CustomerId = 4, MovieId = 7, Date_Rented = new DateTime(2023, 6, 7, 18, 30, 0), Due_Date = new DateTime(2023, 6, 7, 23, 59, 0) },
            //    new MovieCustomer() { CustomerId = 5, MovieId = 1, Date_Rented = new DateTime(2023, 6, 9, 22, 0, 0), Due_Date = new DateTime(2023, 6, 10, 22, 0, 0) },
            //    new MovieCustomer() { CustomerId = 5, MovieId = 4, Date_Rented = new DateTime(2023, 6, 10, 6, 0, 0), Due_Date = new DateTime(2023, 6, 10, 10, 0, 0) },
            //    new MovieCustomer() { CustomerId = 5, MovieId = 7, Date_Rented = new DateTime(2023, 6, 10, 18, 30, 0), Due_Date = new DateTime(2023, 6, 11, 0, 0, 0) });
            //   db.SaveChanges();

            #endregion

            #region Queries
            ///****1****/

            //var topMovies = db.Movies.OrderByDescending(m => m.Rating).Take(3);
            //Console.WriteLine("The top 3 rented movie names are:");
            //foreach (var item in topMovies)
            //{
            //    Console.WriteLine(item.Title);

            //}

            ///****2****/


            // var TopProducer = db.Producers.Include(p => p.Movies)
            //                  .OrderByDescending(p => p.Movies.Count) 
            //                  .FirstOrDefault();

            // string companyName = TopProducer.CompanyName;
            // int movieCount = TopProducer.Movies.Count;

            //Console.WriteLine($"Top Producer is: {companyName}, Movie Count: {movieCount}");



            ///****3****/

            //var customers = from c in db.MovieCustomers.Include(w => w.Customer).ToList()
            //                group c by new { RentalName = c.Customer.FirstName + " " + c.Customer.LastName } into g
            //                orderby g.Count() descending
            //                select new
            //                {
            //                    RentalName = g.Key.RentalName,
            //                    RentalCount = g.Count()
            //                };
            //var index = 1;
            //foreach (var item in customers)
            //{
            //   Console.WriteLine($"{index++}/ Rental Name: {item.RentalName}, Rental Count: {item.RentalCount}");
            //}

                ///****4****/

                //var movies = db.Movies.Include(w => w.Producer).Include(w => w.MovieCustomers).ThenInclude(w => w.Customer).ToList();
                //foreach (var movie in movies)
                //{
                //    Console.WriteLine($"movie Name : {movie.Title} ,producer Name:{movie.Producer.CompanyName}, " +
                //        $"Customer Name :");

                //    foreach (var customer in movie.MovieCustomers.Where(w => w.Due_Date > DateTime.Now))
                //    {
                //        Console.WriteLine($" {customer.Customer.FirstName} {customer.Customer.LastName} " +
                //            $"and its due Date is {(customer.Due_Date.Date.Subtract(DateTime.Today).TotalDays)} days");

                //    }
                //}


                /******5********/

                //var movies = db.Movies.Include(w => w.Producer).Include(w => w.MovieCustomers).ThenInclude(w => w.Customer).ToList();
                //foreach (var movie in movies)
                //{
                //    foreach (var customer in movie.MovieCustomers.Where(w => w.Due_Date < DateTime.Now))
                //    {
                //        Console.WriteLine($"the overdue Rental name is : {customer.Customer.FirstName} " +
                //            $"and its overdue is {DateTime.Now.Subtract(customer.Due_Date).Days} days");
                //    }
                //}
                #endregion




        }

    }
}