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

        // Get all items
        [HttpGet]
        public IEnumerable<Markt> GetAll()
        {
            var result = _repository.GetAll();
            return result;
        }

        // Get item by Id (guid)
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

        // Create new item
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

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] Markt item)
        {
            if (item == null || id == null)
            {
                return BadRequest();
            }

            var markt = _repository.Find(id);
            if (markt == null)
            {
                return NotFound();
            }

            _repository.Update(item);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var markt = _repository.Find(id);
            if (markt == null)
            {
                return NotFound();
            }

            _repository.Remove(id);
            return new NoContentResult();
        }
    }
}