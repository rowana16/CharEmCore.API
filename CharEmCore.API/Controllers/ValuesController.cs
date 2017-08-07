using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CharEmCore.Repository.Repositories;
using CharEmCore.Repository;

namespace CharEmCore.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IRepositoryCRUD _repo;

        public ValuesController(IRepositoryCRUD repo)
        {
            _repo = repo;
        }
        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var services = _repo.GetAllServices();
            return Ok(services);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var service = _repo.GetService(id);
            return Ok(service);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
