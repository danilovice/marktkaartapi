using System.Linq;
using Marktkaart.Models;

namespace Marktkaart.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MarktkaartDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any markten.
            if (context.Markten.Any())
            {
                return;   // DB has been seeded
            }

            var markten = new Markt[]
            {
                new Markt{Guid="025bfa35-6496-4f92-803e-0fcf185c3342",Naam="Amersfoort",Beschrijving="Leuke markt!",Adres="Marktplein 1, Amersfoort",X=144000,Y=415000}
            };
            foreach (Markt m in markten)
            {
                context.Markten.Add(m);
            }
            context.SaveChanges();            
        }
    }
}