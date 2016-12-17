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
    }
}