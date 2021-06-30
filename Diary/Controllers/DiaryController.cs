using Diary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Controllers
{
	public class DiaryController : Controller
	{
		private static List<DiaryEntryModel> entries = new()
		{
			new() { Id = 1, Title = "Title1", Content = "Content1", Day = 5 },
			new() { Id = 2, Title = "Title2", Content = "Content2", Day = 13 },
		};

		// GET: Diary
		public ActionResult Index()
		{
			return View(entries);
		}

		// GET: Diary/Details/5
		public ActionResult Details(int id)
		{
			return View(entries.FirstOrDefault(x => x.Id == id));
		}

		// GET: Diary/Create
		public ActionResult Create()
		{
			return View(new DiaryEntryModel());
		}

		// POST: Diary/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(DiaryEntryModel entry)
		{
			entry.Id = entries.Count + 1;
			entry.Day = DateTime.Today.DayOfYear;
			entries.Add(entry);
			return RedirectToAction(nameof(Index));
		}

		// GET: Diary/Delete/5
		public ActionResult Delete(int id)
		{
			return View(entries.FirstOrDefault(x => x.Id == id));
		}

		// POST: Diary/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, DiaryEntryModel entry)
		{
			entries.Remove(entries.FirstOrDefault(x => x.Id == id));
			return RedirectToAction(nameof(Index));
		}
	}
}
