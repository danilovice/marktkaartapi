using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Marktkaart.Models;
using Marktkaart.Data;

namespace Marktkaart.Controllers
{
    [Route("api/[controller]")]
    public class MarktController : Controller
    {
        private readonly MarktkaartDbContext _context;

        public MarktController(MarktkaartDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Markt> GetAll()
        {
            var result = _context.Markten;
            return result;
        }
    }
}