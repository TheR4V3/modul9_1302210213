using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210213.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa
    {
        public static List<mahasiswa> mh = new List<mahasiswa>
        {
            new mahasiswa ("Rafa Eka", "1302210123", new List<string> { "KPL", "BD", "PBO" }, 2021),
            new mahasiswa ("Andry Nur Falah", "1302213005", new List<string> { "KPL", "BD", "PBO" }, 2021),
            new mahasiswa ("Reyhan Azani", "1302210110", new List<string> { "KPL", "BD", "PBO" }, 2021),
            new mahasiswa ("Satrio Agul", "1302210065", new List<string> { "KPL", "BD", "PBO" }, 2021),
            new mahasiswa ("Yosua William", "1302210126", new List<string> { "KPL", "BD", "PBO" }, 2021)
        };

        [HttpGet]
        public IEnumerable<mahasiswa> Get()
        {
            return mh;
        }

        [HttpPost]
        public void Post([FromBody] mahasiswa newMahasiswa)
        {
            mh.Add(newMahasiswa);
        }

        [HttpGet("{id}")]
        public mahasiswa Get(int id)
        {
            return mh[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mh.RemoveAt(id);
        }
    }
}
