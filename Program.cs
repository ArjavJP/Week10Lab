// See https://aka.ms/new-console-template for more information
using Week10Lab.Models.Entities;

class Program
{
    static void Main(string[] args)
    {
       
        using (var dbContext = new MMABooksContext())
        {
            
            var customers = dbContext.Customers.ToList();

            
            Console.WriteLine("Customer Names:");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}