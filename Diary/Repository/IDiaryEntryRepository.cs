using Diary.Models;
using System.Linq;

namespace Diary.Repository
{
	public interface IDiaryEntryRepository
	{
		void Add(DiaryEntryModel entry);
		void Delete(int id);
		DiaryEntryModel Get(int id);
		IQueryable<DiaryEntryModel> GetAll();
	}
}
