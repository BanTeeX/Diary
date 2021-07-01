using Diary.Models;
using System.Linq;

namespace Diary.Repository
{
	public class DiaryEntryRepository : IDiaryEntryRepository
	{
		private readonly DiaryEntryContext _context;

		public DiaryEntryRepository(DiaryEntryContext context)
		{
			_context = context;
		}

		public DiaryEntryModel Get(int id)
		{
			return _context.Entries.FirstOrDefault(x => x.Id == id);
		}

		public IQueryable<DiaryEntryModel> GetAll()
		{
			return _context.Entries;
		}

		public void Add(DiaryEntryModel entry)
		{
			_context.Entries.Add(entry);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			DiaryEntryModel entry = _context.Entries.FirstOrDefault(x => x.Id == id);
			if (entry != null)
			{
				_context.Entries.Remove(entry);
				_context.SaveChanges();
			}
		}
	}
}
