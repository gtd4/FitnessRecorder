using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessRecorder.Models
{
	public class Team
	{
		public int ID { get; set; }
		public string TeamName { get; set; }
		public virtual ICollection<Player> Players { get; set; }
	}
}