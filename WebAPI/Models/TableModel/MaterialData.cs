using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.TableModel
{
    public class MaterialData : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public string MaterialNameRU { get; set; }

        public string MaterialNameKZ { get; set; }

        public string MaterialNameEN { get; set; }
    }
}
