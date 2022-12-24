using DemoDiary.Data;
using DemoDiary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoDiary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        public ContextClass Diary { get; set; }
        public EntryController(ContextClass contextClass)
        {
            this.Diary = contextClass;

        }
        [HttpPost("insEntry")]
        public async Task<ActionResult> insEntry(Entries cu)
        {

            Diary.tbldiary.Add(cu);
            await Diary.SaveChangesAsync();
            return Ok(cu);
        }


        [HttpGet("viewdata")]
        public async Task<List<Entries>> ViewData()
        {
            return Diary.tbldiary.ToList();
        }

        [HttpGet("ViewdataByid/{id}")]
        public IActionResult ViewCourseByid(int id)
        {
            return Ok(Diary.tbldiary.Find(id));
        }

        [HttpPost("Update")]
        public IActionResult Update(Entries cu)
        {

            Diary.tbldiary.Update(cu);
            Diary.SaveChanges();
            return Ok(cu);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Entries cu)
        {

            Diary.tbldiary.Remove(cu);
            Diary.SaveChanges();
            return Ok(cu);
        }
    }
}
