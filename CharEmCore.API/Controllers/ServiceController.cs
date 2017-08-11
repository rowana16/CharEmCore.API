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


    }
}