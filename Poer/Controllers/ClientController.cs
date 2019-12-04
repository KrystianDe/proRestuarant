using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poer.Models;

namespace Poer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private s16891Context _context;
        public ClientController(s16891Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            return Ok(_context.Klient.ToList());
        }

        [HttpGet("P{id:init}")]
        public IActionResult GetClients(int id)
        {
            var client = _context.Klient.FirstOrDefault(e => e.IdKlient == id);
            if(client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }
    }
}