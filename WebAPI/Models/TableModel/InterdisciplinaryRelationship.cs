using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class InterdisciplinaryRelationship : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public int? ClassID { get; set; }

        public int? SubjectNameID { get; set; }

        public int? UserID { get; set; }

        public int? SectionNameID { get; set; }

        public int? ThemeNameID { get; set; }
    }
}
