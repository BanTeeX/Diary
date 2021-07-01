using Diary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diary
{
	public class DiaryEntryContext : DbContext
	{
		public DbSet<DiaryEntryModel> Entries { get; set; }

		public DiaryEntryContext(DbContextOptions options) : base(options)
		{
		}

		public DiaryEntryModel Get(int id)
		{
			return Entries.FirstOrDefault(x => x.Id == id);
		}

		public IQueryable<DiaryEntryModel> GetAllEntries()
		{
			return Entries;
		}

		public void Add(DiaryEntryModel entry)
		{
			Entries.Add(entry);
			SaveChanges();
		}

		public void Delete(int id)
		{
			DiaryEntryModel entry = Entries.FirstOrDefault(x => x.Id == id);
			if (entry != null)
			{
				Entries.Remove(entry);
				SaveChanges();
			}
		}
	}
}
