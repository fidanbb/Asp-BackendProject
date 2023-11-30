using BackendProject.Models;

namespace BackendProject.Areas.Admin.ViewModels.Blog
{
	public class BlogDetailVM
	{
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public List<BlogImage> Images { get; set; }
        public List<Models.Tag> Tags { get; set; }
    }
}

