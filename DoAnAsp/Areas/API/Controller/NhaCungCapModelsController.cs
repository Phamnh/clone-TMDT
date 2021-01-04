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
    public class NhaCungCapModelsController : ControllerBase
    {
        private readonly DPContext _context;

        public NhaCungCapModelsController(DPContext context)
        {
            _context = context;
        }

        // GET: api/NhaCungCapModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NhaCungCapModel>>> Getnhacungcap()
        {
            return await _context.nhacungcap.ToListAsync();
        }
        [HttpGet("GETdata")]
        public String searchAPI(String keyword)
        {
            var s = from cc in _context.nhacungcap
                    where cc.TenNCC.Contains(keyword)
                    select cc;
            return JsonConvert.SerializeObject(s);
        }
        // GET: api/NhaCungCapModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NhaCungCapModel>> GetNhaCungCapModel(int id)
        {
            var nhaCungCapModel = await _context.nhacungcap.FindAsync(id);

            if (nhaCungCapModel == null)
            {
                return NotFound();
            }

            return nhaCungCapModel;
        }

        // PUT: api/NhaCungCapModels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhaCungCapModel(int id, NhaCungCapModel nhaCungCapModel)
        {
            if (id != nhaCungCapModel.IdNCC)
            {
                return BadRequest();
            }

            _context.Entry(nhaCungCapModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhaCungCapModelExists(id))
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

        // POST: api/NhaCungCapModels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NhaCungCapModel>> PostNhaCungCapModel(NhaCungCapModel nhaCungCapModel)
        {
            _context.nhacungcap.Add(nhaCungCapModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNhaCungCapModel", new { id = nhaCungCapModel.IdNCC }, nhaCungCapModel);
        }

        // DELETE: api/NhaCungCapModels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NhaCungCapModel>> DeleteNhaCungCapModel(int id)
        {
            var nhaCungCapModel = await _context.nhacungcap.FindAsync(id);
            if (nhaCungCapModel == null)
            {
                return NotFound();
            }

            _context.nhacungcap.Remove(nhaCungCapModel);
            await _context.SaveChangesAsync();

            return nhaCungCapModel;
        }

        private bool NhaCungCapModelExists(int id)
        {
            return _context.nhacungcap.Any(e => e.IdNCC == id);
        }
    }
}
