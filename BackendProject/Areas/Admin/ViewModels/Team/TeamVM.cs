using System;
namespace BackendProject.Areas.Admin.ViewModels.Team
{
	public class TeamVM
	{
        public int Id { get; set; }
        public string Image { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

