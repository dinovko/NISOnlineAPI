using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class MaterialDataGlossary : BusinessObjectBase
    {
        public int? MaterialDataID { get; set; }

        public int? GlossaryID { get; set; }
    }
}
