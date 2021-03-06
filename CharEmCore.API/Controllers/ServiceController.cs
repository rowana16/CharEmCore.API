using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CharEmCore.Repository;

namespace CharEmCore.API.Controllers
{
    [Produces("application/json")]
    [Route("api/Service")]
    public class ServiceController : Controller
    {
        private IRepositoryCRUD _repo;

        public ServiceController(IRepositoryCRUD repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("Types")]
        public IActionResult ServiceTypes()
        {
            var serviceTypes = _repo.ServiceTypesAll();
            return Ok(serviceTypes);
        }

        [HttpGet]
        [Route("Types/{serviceTypeId}/Locations")]
        public IActionResult LocationsByServiceType(int serviceTypeId)
        {
            var locations = _repo.LocationsByServiceType(serviceTypeId);
            return Ok(locations);
        }

        [HttpGet]
        [Route("Organizations")]
        public IActionResult Organizations()
        {
            var organizations = _repo.Organizations();
            return Ok(organizations);
        }


    }
}