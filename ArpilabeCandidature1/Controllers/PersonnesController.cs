using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArpilabeCandidature1.Models;
using ArpilabeCandidature1.Data;

namespace ArpilabeCandidature1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnesController : ControllerBase
    {
        private readonly PersonneContext _context;
        private readonly IDataRepository<Personne> _repo;

        public PersonnesController(PersonneContext context, IDataRepository<Personne> _repo)
        {
            _context = context;
            _repo = _repo;
        }

        // GET: api/Personnes
        [HttpGet]
        public IEnumerable<Personne> GetPersonne()
        {
            return _context.Personne.OrderByDescending(p => p.id);
        }

        // GET: api/Personnes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personne>> GetPersonne([FromRoute] int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var personne = await _context.Personne.FindAsync(id);

            if (personne == null)
            {
                return NotFound();
            }

            return Ok(personne);
        }

        // PUT: api/Personnes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonne([FromRoute] int id, [FromBody] Personne personne)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != personne.id)
            {
                return BadRequest();
            }

            _context.Entry(personne).State = EntityState.Modified;

            try
            {
                _repo.Update(personne);
                var save = await _repo.SaveAsync(personne);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonneExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Personnes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Personne>> PostPersonne([FromBody] Personne personne)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repo.Add(personne);
            var save = await _repo.SaveAsync(personne);

            return CreatedAtAction("GetPersonne", new { id = personne.id }, personne);
        }

        // DELETE: api/Personnes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Personne>> DeletePersonne([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var personne = await _context.Personne.FindAsync(id);
            if (personne == null)
            {
                return NotFound();
            }

            _repo.Delete(personne);
            var save = await _repo.SaveAsync(personne);

            return Ok(personne);
        }

        private bool PersonneExists(int id)
        {
            return _context.Personne.Any(e => e.id == id);
        }
    }
}
