using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Models
{
	public class DiaryEntryModel
	{
		public int Id { get; set; }
		[DisplayName("Tytuł")]
		public string Title { get; set; }
		[DisplayName("Treść")]
		public string Content { get; set; }
		[DisplayName("Dzień")]
		public short Day { get; set; }
	}
}
