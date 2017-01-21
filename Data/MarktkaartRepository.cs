using System;
using System.Collections.Generic;
using System.Linq;
using Marktkaart.Models;
using Marktkaart.Interfaces;

namespace Marktkaart.Data
{
    public class MarktkaartRepository : IMarktkaartRepository
    {
        private readonly MarktkaartDbContext _context;
        public MarktkaartRepository(MarktkaartDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Markt> GetAll()
        {
            return _context.Markten;
        }

        public void Add(Markt item)
        {
            item.Guid = Guid.NewGuid().ToString();
            _context.Markten.Add(item);
            _context.SaveChanges();
        }

        public Markt Find(string guid)
        {
            var item = _context.Markten.Where(a => a.Guid == guid).FirstOrDefault();
            return item;
        }

        public void Remove(string guid)
        {
            var item = _context.Markten.Where(a => a.Guid == guid).FirstOrDefault();
            if (item != null)
            {
                _context.Markten.Remove(item);
                _context.SaveChanges();
            }           
        }

        public void Update(Markt item)
        {
            var itemToUpdate = _context.Markten.Where(a => a.Guid == item.Guid).FirstOrDefault();

            if (itemToUpdate != null)
            {            
                itemToUpdate.Adres = item.Adres;
                itemToUpdate.Beschrijving = item.Beschrijving;
                itemToUpdate.Naam = item.Naam;
                itemToUpdate.Plaats = item.Plaats;
                itemToUpdate.X = item.X;
                itemToUpdate.Y = item.Y;

                _context.Markten.Update(itemToUpdate);
                _context.SaveChanges();
            }
        }
    }
}