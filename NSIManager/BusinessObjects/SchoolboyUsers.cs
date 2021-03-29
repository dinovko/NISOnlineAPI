﻿using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NISManager.BusinessObjects
{
    public class SchoolboyUsers : BusinessObjectBase
    {
        public int UserID { get; set; }

        public int ClassID { get; set; }

        public int? LanguageLearningID { get; set; }

        public int? SchoolID { get; set; }
    }
}
