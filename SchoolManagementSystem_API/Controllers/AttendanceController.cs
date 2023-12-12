using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem_API.Data;
using SchoolManagementSystem_API.Models;
using System;

namespace SchoolManagementSystem_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly ApplicationDbContext _attendanceContext;
        private Attendance attendance;

        public AttendanceController(ApplicationDbContext attendanceContext)
        {
            _attendanceContext = attendanceContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attendance>>> GetAttendance()
        {
            if (_attendanceContext.Attendances == null)
            {
                return NotFound();
            }
            return await _attendanceContext.Attendances.ToListAsync();
        }
        [HttpGet("{attendance_id}")]
        public async Task<ActionResult<Attendance>> GetAttendance(int attendance_id)
        {
            if (_attendanceContext.Attendances == null)
            {
                return NotFound();
            }
            var attendance = await _attendanceContext.Attendances.FindAsync(attendance_id);
            if (attendance == null)
            {
                return NotFound();
            }
            return attendance;
        }
        [HttpPost]
        public async Task<ActionResult<Attendance>> PostAttendance(Attendance attendance)
        {
            _attendanceContext.Attendances.Add(attendance);
            await _attendanceContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAttendance), new { id = attendance.Id }, attendance);
        }


        [HttpPut]
        public async Task<IActionResult> PutAttendance(int attendance_id, Attendance attendance)
        {
            if (attendance_id != attendance.attendance_id)
            {
                return BadRequest();
            }
            _attendanceContext.Entry(attendance).State = EntityState.Modified;

            try
            {
                await _attendanceContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendanceAvailable(attendance_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();

        }
        private bool AttendanceAvailable(int id)
        {
            return (_attendanceContext.Attendances?.Any(x => x.Id == id)).GetValueOrDefault();
        }

        [HttpDelete("{attendance_id}")]
        public async Task<IActionResult> DeleteUser(int attendance_id)
        {
            if (_attendanceContext.Attendances == null)
            {
                return NotFound();
            }

            var attendance = await _attendanceContext.Attendances.FindAsync(attendance_id);
            if (attendance == null)
            {
                return NotFound();
            }
            _attendanceContext.Attendances.Remove(attendance);

            await _attendanceContext.SaveChangesAsync();

            return Ok();
        }
    }
}
