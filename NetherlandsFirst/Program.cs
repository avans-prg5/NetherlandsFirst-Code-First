using AmericaSecond;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace NetherlandsFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var NLFirst = new ContextFactory().CreateDbContext(null))
            {
                var Eric = NLFirst.Persons.Where(p => p.FirstName == "Eric").Include(p => p.OwnedVehicles).FirstOrDefault();
                var captuurtje = NLFirst.Cars.Where(c => c.Model == "Capture").FirstOrDefault();
                if (Eric != null && captuurtje != null)
                {
                    Console.WriteLine(Eric.LastName);
                    Console.Write(captuurtje.LicensePlate);
                    Eric.OwnedVehicles.Add(captuurtje);
                }
                NLFirst.SaveChanges();
                Console.WriteLine(Eric.Id);
                Console.ReadLine();
            }
        }
    }
}
