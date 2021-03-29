using System;
using System.Collections.Generic;
using System.Text;

namespace NISLogic.BusinessObjects
{
    public class BaseTheme : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public int? ClassID { get; set; }

        public int? UserID { get; set; }

        public int? SectionNameID { get; set; }

        public int? ThemeNameID { get; set; }
    }
}
