using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Marktkaart.Models;
using Marktkaart.Interfaces;

namespace Marktkaart.Controllers
{
    [Route("api/[controller]")]
    public class MarktController : Controller
    {
        private readonly IMarktkaartRepository _repository;

        public MarktController(IMarktkaartRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        public IEnumerable<Markt> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        [HttpGet("{id}", Name = "GetMarkt")]
        public IActionResult GetById(string id)
        {
            var item = _repository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Markt item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _repository.Add(item);
            return CreatedAtRoute("GetMarkt", new { id = item.Guid }, item);
        }
    }
}