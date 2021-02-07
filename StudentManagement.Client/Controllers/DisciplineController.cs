using Microsoft.AspNetCore.Mvc;
using StudentManagement.Client.Models;
using StudentManagement.Client.Services;
using System;
using System.Threading.Tasks;

namespace StudentManagement.Client.Controllers
{
    public class DisciplineController : Controller
    {
        private readonly DisciplineService _disciplineService;

        public DisciplineController(DisciplineService disciplineService)
        {
            _disciplineService = disciplineService;
        }

        public async Task<ActionResult> IndexAsync()
        {
            var disciplineList = await _disciplineService.GetDisciplineListAsync();
            return View(disciplineList);
        }

        public async Task<ActionResult> DetailsAsync(Guid id)
        {
            var discipline = await _disciplineService.GetDisciplineByIdAsync(id);
            return View(discipline);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync([Bind("DisciplineId,DisciplineName,ProfesorName,Score")] DisciplineViewModel discipline)
        {
            if (ModelState.IsValid)
            {
                await _disciplineService.AddDisciplineAsync(discipline);
                return RedirectToAction(nameof(Index));
            }
            return View(discipline);
        }

        public async Task<ActionResult> EditAsync(Guid? id)
        {
            if (id == null)
                return NotFound();

            var discipline = await _disciplineService.GetDisciplineByIdAsync(id.Value);
            if (discipline == null)
                return NotFound();

            return View(discipline);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(Guid id, [Bind("DisciplineId,DisciplineName,ProfesorName,Score")] DisciplineViewModel discipline)
        {
            if (id != discipline.DisciplineId)
                return NotFound();

            if (ModelState.IsValid)
            {
                await _disciplineService.UpdateDisciplineAsync(discipline);
                return RedirectToAction(nameof(Index));
            }
            return View(discipline);
        }
    }
}
