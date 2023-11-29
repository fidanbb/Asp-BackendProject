using System;
namespace BackendProject.Models
{
	public class Direction
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public List<Advert> Adverts { get; set; }
	}
}

