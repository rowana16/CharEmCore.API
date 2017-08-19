using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CharEmCore.Repository.Entities;
using CharEmCore.Repository;
using AutoMapper;
using CharEmCore.API.Models;

namespace CharEmCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/County")]
    public class CountyController : Controller
    {
        private IRepositoryCRUD _repo;
        private IMapper _mapper;

        public CountyController(IRepositoryCRUD repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET: api/County
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var counties = _repo.Counties();
                return Ok(counties);
            }
            catch
            {
                return BadRequest();
            }
            
        }

        // GET: api/County/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_repo.Counties(id));
            }
            catch
            {
                return BadRequest();
            }
           
        }
        
        // POST: api/County
        [HttpPost]
        public IActionResult Post([FromBody]CountyDTO model)
        {
            County county;
            try
            {
                county = _mapper.Map<County>(model);
            }
            catch
            {
                return BadRequest("No Mapping");
            }
            try
            {
                _repo.Add(county); 
            }
            catch
            {
                return BadRequest("No Save");
            }

            var newUri = Url.Link("Get", new { id = county.Id });
            return Created(newUri, _mapper.Map<CountyDTO>(county));
                      
        }
        
        // PUT: api/County/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]CountyDTO model)
        {
            try
            {
                var beforeObject = _repo.Counties(id);
                if(beforeObject ==null) { return NotFound(); }

                _mapper.Map(model, beforeObject);
                _repo.Update(beforeObject);
                return Ok(_mapper.Map<CountyDTO>(beforeObject));
            }
            catch
            {
                return BadRequest();
            }            
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var deleteObject = _repo.Counties(id);
                _repo.Delete(deleteObject);
                return Ok();
            }
            catch 
            {
                return BadRequest();
            }
        }
    }
}
