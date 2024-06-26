using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using db_siswa_api.Models;
using System.Threading.Tasks;
using System.Linq;

namespace db_siswa_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        private readonly SiswaContext _context;

        public SiswaController(SiswaContext context)
        {
            _context = context;
        }

        // GET: api/Siswa
        [HttpGet]
        public async Task<ActionResult<ApiResponse<List<Siswa>>>> GetAllSiswa()
        {
            var siswaList = await _context.siswa.ToListAsync();
            return Ok(new ApiResponse<List<Siswa>>(true, "All Siswa retrieved successfully", siswaList));
        }

        // GET: api/Siswa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<Siswa>>> GetSiswa(int id)
        {
            var siswa = await _context.siswa.FindAsync(id);

            if (siswa == null)
            {
                return NotFound(new ApiResponse<Siswa>(false, "Siswa not found", null));
            }

            return Ok(new ApiResponse<Siswa>(true, "Siswa retrieved successfully", siswa));
        }

        // POST: api/Siswa
        [HttpPost]
        public async Task<ActionResult<ApiResponse<Siswa>>> PostSiswa(Siswa siswa)
        {
            _context.siswa.Add(siswa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSiswa), new { id = siswa.id }, new ApiResponse<Siswa>(true, "Siswa created successfully", siswa));
        }

        // PUT: api/Siswa/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSiswa(int id, Siswa siswa)
        {
            if (id != siswa.id)
            {
                return BadRequest(new ApiResponse<Siswa>(false, "ID mismatch", null));
            }

            _context.Entry(siswa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiswaExists(id))
                {
                    return NotFound(new ApiResponse<Siswa>(false, "Siswa not found", null));
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Siswa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSiswa(int id)
        {
            var siswa = await _context.siswa.FindAsync(id);
            if (siswa == null)
            {
                return NotFound(new ApiResponse<Siswa>(false, "Siswa not found", null));
            }

            _context.siswa.Remove(siswa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SiswaExists(int id)
        {
            return _context.siswa.Any(e => e.id == id);
        }
    }
}
// fungsi kontroller disini sbg aksi ketika menembak dari postman akan mengarah ke kontroller ini
//sesuaikan saja fungsi nya dg kebutuhan
//contoh diatas kita menggunakan key berupa ID pada database untuk akses nya, ketika tidak ada id(key) akan not found
//dan contoh di atas ada tambahan api respon
//buat di folder models dg nama apiresponse