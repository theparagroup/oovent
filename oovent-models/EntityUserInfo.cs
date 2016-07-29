using System;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using Oovent.Models.Ef;
using System.Security.Principal;
using System.Collections.Generic;


namespace Oovent.Models
{
	public partial class EntityUserInfo
	{
		public int Id { get; set;}
		public string Email { get; set;}
		public string Password { get; set;}

        public static EfEntityUserInfo GetUser(IPrincipal user)
        {
            return GetUser(user.Identity.Name);
        }

        public static EfEntityUserInfo GetUser(string email)
        {
            using (var db = new DbContext())
            {
                var query = from u in db.EntityUserInfo
                            where u.Email == email
                            select u;

                var efUser = query.FirstOrDefault();
                return efUser;
            }
        }
    }
}
