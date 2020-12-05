using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDgel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Mime;

namespace CRUDgel.Controllers
{
    [ApiController]  
    [Route("api")]
    public class CharacterController : ControllerBase
    {

        [HttpGet]
        public CharacterModel Get()
        {
            var c =  new CharacterModel();
            return c;
        }
    }
}
