using System;
using System.Collections.Generic;
using System.Text;

namespace NISLogic.BusinessObjects
{
    public class MaterialAddInfoImage : BusinessObjectBase
    {
        public int? MaterialAddInfoID { get; set; }

        public string ImageBacketRU { get; set; }

        public string ImageRUGUID { get; set; }

        public string ImageBacketKZ { get; set; }

        public string ImageKZGUID { get; set; }

        public string ImageBacketEN { get; set; }

        public string ImageENGUID { get; set; }
    }
}
