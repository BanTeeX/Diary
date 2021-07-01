using Diary.Models;
using Microsoft.EntityFrameworkCore;

namespace Diary.Repository
{
	public class DiaryEntryContext : DbContext
	{
		public DbSet<DiaryEntryModel> Entries { get; set; }
		public DiaryEntryContext(DbContextOptions options) : base(options)
		{
		}
	}
}
