using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nodes.Data;
using Nodes.Entities;

namespace Nodes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NodesTreesController : ControllerBase
    {
        private readonly ApidDbContext _context;

        public NodesTreesController(ApidDbContext context)
        {
            _context = context;
        }

        // GET: api/NodesTrees
        [HttpGet("GetNodosPadres")]
        public async Task<ActionResult<IEnumerable<NodesTree>>> GetNodosPadres()
        {
            return await _context.Nodos.Where(x => x.parent == "padre" || x.parent == "null").ToListAsync();
        }

        // GET: api/NodesTrees
        [HttpGet("GetNodosHijo")]
        public async Task<ActionResult<IEnumerable<NodesTree>>> GetNodosHijo()
        {
            return await _context.Nodos.Where(x => x.parent == "hijo").ToListAsync();
        }

        /*// GET: api/NodesTrees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NodesTree>> GetNodesTree(int id)
        {
            var nodesTree = await _context.Nodos.FindAsync(id);

            if (nodesTree == null)
            {
                return NotFound();
            }

            return nodesTree;
        }*/

        // PUT: api/NodesTrees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /*[HttpPut("{id}")]
        public async Task<IActionResult> PutNodesTree(int id, NodesTree nodesTree)
        {
            if (id != nodesTree.id)
            {
                return BadRequest();
            }

            _context.Entry(nodesTree).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NodesTreeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/

        // POST: api/NodesTrees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("CrearNodo")]
        public async Task<ActionResult<NodesTree>> PostNodesTree(NodesTree nodesTree)
        {
            if (nodesTree.id == 0)
            {
                return BadRequest("No puede crear un nodo con id 0");
            }
            if (nodesTree.created_At.ToString() == null || nodesTree.created_At.ToString() == string.Empty)
            nodesTree.created_At = DateTime.Now;
            // Sí envian Zona horaria hacemos la conversión de creación
            if ((nodesTree.timeZone != null || nodesTree.timeZone != string.Empty) && nodesTree.timeZone != "string")
            {
                TimeZoneInfo otraZona = TimeZoneInfo.FindSystemTimeZoneById(nodesTree.timeZone);
                    if (otraZona != null)
                nodesTree.created_At = TimeZoneInfo.ConvertTime(nodesTree.created_At, otraZona);
            }

            _context.Nodos.Add(nodesTree);
            await _context.SaveChangesAsync();

            return Ok("Nodo Creado " + CreatedAtAction("GetNodesTree", new { id = nodesTree.id }, nodesTree));
        }

        // DELETE: api/NodesTrees/5
        [HttpDelete("EliminarNodo")]
        public async Task<IActionResult> DeleteNodesTree(int id)
        {
            var nodesTree = await _context.Nodos.FindAsync(id);
            if (nodesTree == null)
            {
                return NotFound();
            }
            var nodesTree1 = await _context.Nodos.FindAsync(nodesTree.childNode);
            if (nodesTree.childNode != 0 && nodesTree1 != null)//Tiene Hijos, no debemos eliminar
            {
                return BadRequest("No puede eliminar el siguiente nodo, tiene el siguiente hijo: " + nodesTree1.parent  + " id: " + nodesTree1.id);
            }
            _context.Nodos.Remove(nodesTree);
            await _context.SaveChangesAsync();

            return Ok("Nodo eliminado con exito!");
        }

        private bool NodesTreeExists(int id)
        {
            return _context.Nodos.Any(e => e.id == id);
        }
    }
}
