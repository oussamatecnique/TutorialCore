using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TutorialCore.Data;
using TutorialCore.Models;

namespace TutorialCore.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ModelsController(ApplicationDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public async Task<IList<Model>> GetModels()
        {
            var Mods = await context.Models.ToListAsync();
            return Mods;
        }
        [HttpPost]
        public async Task<ActionResult<Model>> AddModel( Model M)
        {
            if (ModelState.IsValid)
            {
                context.Models.Add(M);
                await context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetModels), new { id = M.Id }, M);

            }
            else
            {
                return BadRequest("Model non Valide");
            }
        }
    }
}