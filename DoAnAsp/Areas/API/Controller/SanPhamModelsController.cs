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
    public class SanPhamModelsController : ControllerBase
    {
        private readonly DPContext _context;

        public SanPhamModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: api/SanPhamModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SanPhamModel>>> Getsanpham()
        {
            return await _context.sanpham.ToListAsync();
        }
        [HttpGet("GETdata")]
        public String searchAPI(String keyword)
        {
            var s = from cc in _context.sanpham
                    where cc.TenSP.Contains(keyword)
                    select cc;
            return JsonConvert.SerializeObject(s);
        }

        // GET: api/SanPhamModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SanPhamModel>> GetSanPhamModel(int id)
        {
            var sanPhamModel = await _context.sanpham.FindAsync(id);

            if (sanPhamModel == null)
            {
                return NotFound();
            }

            return sanPhamModel;
        }

        // PUT: api/SanPhamModels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSanPhamModel(int id, SanPhamModel sanPhamModel)
        {
            if (id != sanPhamModel.IdSP)
            {
                return BadRequest();
            }

            _context.Entry(sanPhamModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanPhamModelExists(id))
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

        // POST: api/SanPhamModels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SanPhamModel>> PostSanPhamModel(SanPhamModel sanPhamModel)
        {
            _context.sanpham.Add(sanPhamModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSanPhamModel", new { id = sanPhamModel.IdSP }, sanPhamModel);
        }

        // DELETE: api/SanPhamModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SanPhamModel>> DeleteSanPhamModel(int id)
        {
            var sanPhamModel = await _context.sanpham.FindAsync(id);
            if (sanPhamModel == null)
            {
                return NotFound();
            }

            _context.sanpham.Remove(sanPhamModel);
            await _context.SaveChangesAsync();

            return sanPhamModel;
        }

        private bool SanPhamModelExists(int id)
        {
            return _context.sanpham.Any(e => e.IdSP == id);
        }
    }
}
