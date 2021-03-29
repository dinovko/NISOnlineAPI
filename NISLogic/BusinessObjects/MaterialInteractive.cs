using System;
using System.Collections.Generic;
using System.Text;

namespace NISLogic.BusinessObjects
{
    public class MaterialInteractive : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public string NameRU { get; set; }

        public string NameKZ { get; set; }

        public string NameEN { get; set; }

        public string Link { get; set; }
    }
}
