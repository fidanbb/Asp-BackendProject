using System;
using BackendProject.Areas.Admin.ViewModels.Contact;
using BackendProject.Areas.Admin.ViewModels.Social;

namespace BackendProject.ViewModels
{
	public class ContactPageVM
	{
		public ContactVM Contact { get; set; }
		public List<SocialVM> Socials { get; set; }
		
	}
}


