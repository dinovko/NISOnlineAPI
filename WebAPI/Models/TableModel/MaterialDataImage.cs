using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.TableModel
{
    public class MaterialDataImage : BusinessObjectBase
    {
        public int? MaterialDataID { get; set; }

        public string ImageBacketRU { get; set; }

        public string ImageRUGUID { get; set; }

        public string ImageBacketKZ { get; set; }

        public string ImageKZGUID { get; set; }

        public string ImageBacketEN { get; set; }

        public string ImageENGUID { get; set; }
    }
}
