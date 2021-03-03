using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class UserRoles : BusinessObjectBase
    {
        public int UserID { get; set; }

        public int RoleID { get; set; }
    }
}
