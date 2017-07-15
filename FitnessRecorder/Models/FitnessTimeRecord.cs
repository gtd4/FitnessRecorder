using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessRecorder.Models
{
	public class FitnessTimeRecord
	{
		public int ID { get; set; }
		public int PlayerID { get; set; }
		public int ExerciseID { get; set; }
		public IEnumerable<TimeSpan> TimeRecords { get; set; }

		public virtual Player Player { get; set; }
		public virtual Exercise Exercise { get; set; }
	}
}