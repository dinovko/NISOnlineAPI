using NISLogic.BusinessObjects;
using NISLogic.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace NISLogic.Manager
{
    public class MaterialDataManager : ManagerBase
    {
        public long SaveMaterialData(InfoMaterialAdd material, string conn)
        {

            return material.ID;
        }
    }
}
