using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw_11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw_11.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly HospitalDbContext _context;
        public HospitalController(HospitalDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctor.ToList());
        }
        [HttpPost]
        public IActionResult AddDoctors(Doctor doc)
        {
            _context.Doctor.Add(doc);
            _context.SaveChanges();
            return Ok("Dodano lekarza");
        }
        [HttpPut]
        public IActionResult UpdateDoctors(Doctor doc)
        {
            var d = _context.Doctor.Where(a => a.IdDoctor == doc.IdDoctor).First();
            d.FirstName = doc.FirstName;
            d.LastName = doc.LastName;
            d.Email = doc.Email;
            _context.SaveChanges();
            return Ok("Zmieniona dane lekarza");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctors(string id)
        {
            var d = _context.Doctor.Where(a => a.IdDoctor == int.Parse(id)).First();
            _context.Doctor.Remove(d);
            _context.SaveChanges();
            return Ok("Usunieto lekarza");
        }
    }
}