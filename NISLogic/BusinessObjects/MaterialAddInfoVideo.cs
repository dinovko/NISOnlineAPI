using System;
using System.Collections.Generic;
using System.Text;

namespace NISLogic.BusinessObjects
{
    public class MaterialAddInfoVideo : BusinessObjectBase
    {
        public int? MaterialAddInfoID { get; set; }

        public string VideoBacketRU { get; set; }

        public string VideoRUGUID { get; set; }

        public string VideoBacketKZ { get; set; }

        public string VideoKZGUID { get; set; }

        public string VideoBacketEN { get; set; }

        public string VideoENGUID { get; set; }
    }
}
