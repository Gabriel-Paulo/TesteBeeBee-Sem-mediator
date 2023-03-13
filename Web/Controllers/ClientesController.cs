using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Web.Models;

namespace Web.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ClientesContext _context;

        public ClientesController(ClientesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetAllClientes()
        {
            return await _context.Clientes
            .Include(c => c.Documentos)
            .Include(c => c.Enderecos)
            .ToListAsync(); ;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetClienteId(int id)
        {
            //var cliente = await _context.Clientes.FindAsync(id);
            var cliente = await _context.Clientes
              .Include(c => c.Documentos)
              .Include(c => c.Enderecos)
              .FirstOrDefaultAsync(c => c.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return cliente;
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> CreateCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClienteId), new { id = cliente.Id }, cliente);
        }

        [HttpGet("{id}/documentos")]
        public async Task<ActionResult<IEnumerable<Documento>>> GetDocumentos(int id)
        {
            var documentos = await _context.Documentos.Where(d => d.ClienteId == id).ToListAsync();

            if (documentos == null || documentos.Count == 0)
            {
                return NotFound();
            }

            return documentos;
        }

        [HttpGet("{id}/enderecos")]
        public async Task<ActionResult<IEnumerable<Endereco>>> GetEnderecos(int id)
        {
            var enderecos = await _context.Enderecos.Where(e => e.ClienteId == id).ToListAsync();

            if (enderecos == null || enderecos.Count == 0)
            {
                return NotFound();
            }

            return enderecos;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCliente(int id, Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
