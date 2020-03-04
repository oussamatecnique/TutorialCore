using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TutorialCore.Data;
using TutorialCore.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using TutorialCore.Models.Ressources;
using Microsoft.AspNetCore.Cors;

namespace TutorialCore.Controllers
{


    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper mapper;

        public MakesController(ApplicationDbContext _context, IMapper mapper)
        {
            this._context = _context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<MakeRessource>> GetMakes()
        {
            var makes = await _context.Makes.Include(a => a.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeRessource>>(makes);
        }
        [HttpPost]
        public async Task<ActionResult<Make>> AddMake([FromBody] Make m)
        {

            if (ModelState.IsValid)
            {
                _context.Makes.Add(m);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetMakes), new { id = m.Id }, m);

            }
            else
            {
                return BadRequest();
            }

        }
        [HttpDelete("{ido}")]
        public async Task<ActionResult> Delete(int ido)
        {
            if (_context.Makes.Any(m => m.Id == ido))
            {
                var c = _context.Makes.Where(m => m.Id == ido).FirstOrDefault();
                _context.Makes.Remove(c);
                await _context.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return BadRequest("Id dont exist");
            }

        }
    }
}