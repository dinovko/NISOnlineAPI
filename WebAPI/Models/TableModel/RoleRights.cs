using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class RoleRights : BusinessObjectBase
    {
        public int RoleID { get; set; }

        public int RightID { get; set; }
    }
}
