﻿using System;
namespace BackendProject.Models
{
	public class ContactMessage:BaseEntity
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Message { get; set; }
	}
}

