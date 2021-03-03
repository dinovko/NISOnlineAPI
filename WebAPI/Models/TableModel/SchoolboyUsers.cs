using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class SchoolboyUsers : BusinessObjectBase
    {
        public int UserID { get; set; }

        public int ClassID { get; set; }

        public int? LanguageLearningID { get; set; }

        public int? SchoolID { get; set; }
    }
}
