using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem_API.Data;
using SchoolManagementSystem_API.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace SchoolManagementSystem_API.Controllers
{
    [ApiController]
    [Route("api/grades")]
    public class GradeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GradeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Grade>>> Grades()
        {
            var grades = await _context.Grades.ToListAsync();
            return Ok(grades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Grade>> GetGrade(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
                return NotFound();

            return Ok(grade);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGrade(Grade grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetGrade), new { id = grade.Id }, grade);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateGrade(int id, Grade grade)
        {
            if (id != grade.Id)
                return BadRequest();

            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
                return NotFound();

            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
