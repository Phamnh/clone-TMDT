using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DoAnAsp.Areas.Admin.Data;
using DoAnAsp.Areas.Admin.Models;
using Newtonsoft.Json;

namespace DoAnAsp.Areas.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiSPModelcsController : ControllerBase
    {
        private readonly DPContext _context;

        public LoaiSPModelcsController(DPContext context)
        {
            _context = context;
        }

        // GET: api/LoaiSPModelcs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoaiSPModelcs>>> Getloaisanpham()
        {
            return await _context.loaisanpham.ToListAsync();
        }

        // GET: api/LoaiSPModelcs/5
        [HttpGet("GETdata")]
        public String searchAPI(String keyword)
        {
            var s = from cc in _context.loaisanpham
                    where cc.TenLSP.Contains(keyword)
                    select cc;
            return JsonConvert.SerializeObject(s);
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> PutLoaiSPModelcs(int id, LoaiSPModelcs loaiSPModelcs)
        {
            if (id != loaiSPModelcs.IdLSP)
            {
                return BadRequest();
            }

            _context.Entry(loaiSPModelcs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiSPModelcsExists(id))
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

        // POST: api/LoaiSPModelcs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LoaiSPModelcs>> PostLoaiSPModelcs(LoaiSPModelcs loaiSPModelcs)
        {
            _context.loaisanpham.Add(loaiSPModelcs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoaiSPModelcs", new { id = loaiSPModelcs.IdLSP }, loaiSPModelcs);
        }

        // DELETE: api/LoaiSPModelcs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoaiSPModelcs>> DeleteLoaiSPModelcs(int id)
        {
            var loaiSPModelcs = await _context.loaisanpham.FindAsync(id);
            if (loaiSPModelcs == null)
            {
                return NotFound();
            }

            _context.loaisanpham.Remove(loaiSPModelcs);
            await _context.SaveChangesAsync();

            return loaiSPModelcs;
        }

        private bool LoaiSPModelcsExists(int id)
        {
            return _context.loaisanpham.Any(e => e.IdLSP == id);
        }
    }
}
