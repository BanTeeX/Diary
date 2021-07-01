using Diary.Models;
using Diary.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Diary.Controllers
{
	public class DiaryController : Controller
	{
		private readonly IDiaryEntryRepository _repository;

		public DiaryController(IDiaryEntryRepository context)
		{
			_repository = context;
		}

		// GET: Diary
		public IActionResult Index()
		{
			return View(_repository.GetAll());
		}

		// GET: Diary/Details/5
		public IActionResult Details(int id)
		{
			return View(_repository.Get(id));
		}

		// GET: Diary/Create
		public IActionResult Create()
		{
			return View(new DiaryEntryModel());
		}

		// POST: Diary/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(DiaryEntryModel entry)
		{
			if (ModelState.IsValid)
			{
				_repository.Add(entry);
				return RedirectToAction(nameof(Index));
			}
			return View(entry);
		}

		// GET: Diary/Delete/5
		public IActionResult Delete(int id)
		{
			return View(_repository.Get(id));
		}

		// POST: Diary/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(int id, DiaryEntryModel entry)
		{
			_repository.Delete(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
