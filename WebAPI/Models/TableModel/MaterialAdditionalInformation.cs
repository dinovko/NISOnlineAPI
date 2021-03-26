using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.TableModel
{
    public class MaterialAdditionalInformation : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public string MaterialNameRU { get; set; }

        public string MaterialNameKZ { get; set; }

        public string MaterialNameEN { get; set; }

        public string Link { get; set; }

        public List<MaterialAddInfoImage> MaterialAddInfoImageList { get; set; }

        public List<MaterialAddInfoVideo> MaterialAddInfoVideoList { get; set; }
    }
}
