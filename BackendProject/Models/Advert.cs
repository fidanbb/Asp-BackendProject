using System;
namespace BackendProject.Models
{
	public class Advert:BaseEntity
	{
		public string Image { get; set; }
		public string Description { get; set; }
		public int DirectionId { get; set; }
		public Direction Direction { get; set; }
	}
}

