using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_18_CoffeeShopFun.Models
{
	public class NewUser
	{
		public string UserName { get; set; }
		public string Password { get; set; }

		public NewUser() { }

		public NewUser(string userName, string password)
		{
			UserName = userName;
			Password = password;
		}
	}

}
