using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class MaterialAddInfoImage : BusinessObjectBase
    {
        public int? InfoMaterialID { get; set; }

        public string ImageBacketRU { get; set; }

        public string ImageRUGUID { get; set; }

        public string ImageBacketKZ { get; set; }

        public string ImageKZGUID { get; set; }

        public string ImageBacketEN { get; set; }

        public string ImageENGUID { get; set; }
    }
}
