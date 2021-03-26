using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.TableModel
{
    public class MaterialDataGlossary : BusinessObjectBase
    {
        public int? MaterialDataID { get; set; }

        public int? GlossaryID { get; set; }
    }
}
