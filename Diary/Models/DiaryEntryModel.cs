using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diary.Models
{
	[Table("DiaryEntries")]
	public class DiaryEntryModel
	{
		[Key]
		public int Id { get; set; }
		[DisplayName("Tytuł")]
		[Required(ErrorMessage = "Pole tytuł jest wymagane")]
		[MaxLength(50)]
		public string Title { get; set; }
		[DisplayName("Treść")]
		[MaxLength(2048)]
		public string Content { get; set; }
		[DisplayName("Dzień")]
		[Required(ErrorMessage = "Pole dzień jest wymagane")]
		[Range(1.0, 365.0, ErrorMessage = "Liczba z przedziału od 1 do 365")]
		public short Day { get; set; }
	}
}
