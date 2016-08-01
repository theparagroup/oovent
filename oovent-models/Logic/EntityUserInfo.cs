using System;
using System.Linq;
using Oovent.Models.Ef;

namespace Oovent.Models
{
	public partial class EntityUserInfo
	{
        public static EfEntityUserInfo GetUser(string email)
        {
            using (var db = new DbContext())
            {
                var query = from u in db.EntityUserInfo
                            where u.Email == email
                            select u;

                var efEntityUserInfo = query.FirstOrDefault();
                return efEntityUserInfo;
            }
        }
	}
}
