using System;
using System.Collections.Generic;
using System.Text;

namespace NISLogic.BusinessObjects
{
    public class MaterialData : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public string MaterialNameRU { get; set; }

        public string MaterialNameKZ { get; set; }

        public string MaterialNameEN { get; set; }

        public List<MaterialDataImage> MaterialDataImageList { get; set; }

        public List<MaterialDataVideo> MaterialDataVideoList { get; set; }

        public List<MaterialDataGlossary> MaterialDataGlossaryList { get; set; }
    }
}
