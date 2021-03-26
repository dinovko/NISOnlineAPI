using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.TableModel
{
    public class MaterialAddInfoVideo : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public string VideoBacketRU { get; set; }

        public string VideoRUGUID { get; set; }

        public string VideoBacketKZ { get; set; }

        public string VideoKZGUID { get; set; }

        public string VideoBacketEN { get; set; }

        public string VideoENGUID { get; set; }
    }
}
