using Microsoft.AspNetCore.Mvc;
using StudentManagement.Client.Models;
using StudentManagement.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Client.Controllers
{
    public class SemesterController : Controller
    {
        private readonly SemesterService _semesterService;

        public SemesterController(SemesterService semesterService)
        {
            _semesterService = semesterService;
        }

        public async Task<ActionResult> IndexAsync()
        {
            var semesterList = await _semesterService.GetSemestersListAsync();
            return View(semesterList);
        }

        public async Task<ActionResult> DetailsAsync(Guid id)
        {
            var semester = await _semesterService.GetSemesterByIdAsync(id);
            return View(semester);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("SemesterId,Name,StartDate,EndDate")] SemesterViewModel semester)
        {
            if (ModelState.IsValid)
            {
                await _semesterService.AddSemesterAsync(semester);
                return RedirectToAction(nameof(Index));
            }
            return View(semester);
        }

        public async Task<ActionResult> EditAsync(Guid? id)
        {
            if (id == null)
                return NotFound();

            var semester = await _semesterService.GetSemesterByIdAsync(id.Value);
            if (semester == null)
                return NotFound();

            return View(semester);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(Guid id, [Bind("SemesterId,Name,StartDate,EndDate")] SemesterViewModel semester)
        {
            if (id != semester.SemesterId)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _semesterService.UpdateSemesterAsync(semester);
                return RedirectToAction(nameof(Index));
            }
            return View(semester);
        }

        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
