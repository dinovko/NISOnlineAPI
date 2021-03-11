using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;
using WebAPI.Models.TableModel;

namespace WebAPI.Models
{
    public class Users : BusinessObjectBase
    {
        public string Password { get; set; }

        public int UserTypeID { get; set; }

        public int? PersonID { get; set; }

        /// <summary>Является ли учеником</summary>
        public bool? IsSchoolboy { get; set; }

        public SchoolboyUsers SchoolboyUsersObj { get; set; }

    }
}
