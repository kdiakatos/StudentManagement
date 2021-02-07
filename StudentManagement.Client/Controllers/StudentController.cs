using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentManagement.Client.Models;
using StudentManagement.Client.Services;
using System;
using System.Threading.Tasks;

namespace StudentManagement.Client.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService;
        private readonly SemesterService _semesterService;

        public StudentController(StudentService studentService, SemesterService semesterService)
        {
            _semesterService = semesterService;
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
            ViewData["SemesterId"] = new SelectList(await _semesterService.GetSemestersListAsync(), "SemesterId", "Name");
            return View(student);
        }

        [HttpPost]
        public async Task<JsonResult> AssignAsync(Guid studentId, Guid semesterId)
        {
            var studentSemester = new StudentSemesterViewModel
            {
                StudentId = studentId,
                SemesterId = semesterId
            };
            var result = await _studentService.AddStudentSemesterAsync(studentSemester);
            return new JsonResult(result);
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
