using Microsoft.AspNetCore.Mvc;
using StudentManagement.Client.Models;
using StudentManagement.Client.Services;
using System;
using System.Threading.Tasks;

namespace StudentManagement.Client.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        public async Task<ActionResult> IndexAsync()
        {
            var studentList = await _studentService.GetStudentListAsync();
            return View(studentList);
        }

        public async Task<ActionResult> DetailsAsync(Guid id)
        {
            var student = await _studentService.GetStudentByIdAsync(id);
            return View(student);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("StudentId,FirstName,LastName,DateOfBirth")] StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                await _studentService.AddStudentAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        public async Task<ActionResult> EditAsync(Guid? id)
        {
            if (id == null)
                return NotFound();

            var student = await _studentService.GetStudentByIdAsync(id.Value);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(Guid id, [Bind("StudentId,FirstName,LastName,DateOfBirth")] StudentViewModel student)
        {
            if (id != student.StudentId)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _studentService.UpdateStudentAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        //public async Task<ActionResult> DeleteAsync(Guid? id)
        //{
        //    if (id == null)
        //        return NotFound();

        //    var student = await _studentService.GetStudentByIdAsync(id.Value);
        //    if (student == null)
        //        return NotFound();

        //    return View(student);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    await _studentService.DeleteStudentAsync(id);
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
