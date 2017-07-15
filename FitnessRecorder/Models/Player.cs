using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessRecorder.Models
{
	public class Player
	{
		public int ID { get; set; }
		public int TeamID { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }

		public virtual Team Team { get; set; }
		public virtual ICollection<FitnessTimeRecord> FitnessTimeRecord { get; set; }
	}
}