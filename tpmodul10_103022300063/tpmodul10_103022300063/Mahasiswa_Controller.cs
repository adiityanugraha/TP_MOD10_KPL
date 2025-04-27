using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace tpmodule10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Anak Agung Aryadipa Aditya Nugraha", Nim = "103022300063" },
            new Mahasiswa { Nama = "Rakha Raihanurrahman", Nim = "103022300046" },
            new Mahasiswa { Nama = "Jack Kelvin Guevara Rihilo", Nim = "103022300024" },
            new Mahasiswa { Nama = "Muhammad Azki Abdul Malik", Nim = "103022300131" },
            new Mahasiswa { Nama = "Muhammad Raihan Hidayatulloh", Nim = "103022330167" }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public IEnumerable<Mahasiswa> GetAll()
        {
            return daftarMahasiswa;
        }

        // GET: api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            return daftarMahasiswa[index];
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult<Mahasiswa> Create(Mahasiswa mahasiswa)
        {
            daftarMahasiswa.Add(mahasiswa);
            return Ok(mahasiswa);
        }

        // DELETE: api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound();
            }
            daftarMahasiswa.RemoveAt(index);
            return NoContent();
        }
    }

    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }
    }
}
