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
            }           
        }

        public void Update(Markt item)
        {
            if (_context.Markten.Where(a => a.Guid == item.Guid).Any())
            {
                _context.Markten.Update(item);
            }
        }
    }
}