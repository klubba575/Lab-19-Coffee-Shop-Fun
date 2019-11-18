using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_18_CoffeeShopFun.Models
{
	public class RegisterUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[Required]
		[StringLength(20, ErrorMessage = "Please shorten your name to 20 characters")]
		public string UserName { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }

		public RegisterUser() { }
	}
}
