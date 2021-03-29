using System;
using System.Collections.Generic;
using System.Text;

namespace NISLogic.BusinessObjects
{
    public class InfoMaterialAdd : BusinessObjectBase
    {
        public int? ClassID { get; set; }

        public int? SubjectNameID { get; set; }

        public int? UserID { get; set; }

        public int? SectionNameID { get; set; }

        public int? ThemeNameID { get; set; }

        public InterdisciplinaryRelationship InterdisciplinaryRelationshipObj { get; set; }

        public BaseTheme BaseThemeObj { get; set; }

        public MaterialData MaterialDataObj { get; set; }

        public List<MaterialDigEduResources> MaterialDigEduResourcesList { get; set; }

        public List<MaterialInteractive> MaterialInteractiveList { get; set; }

        public MaterialAdditionalInformation MaterialAdditionalInformationObj { get; set; }
    }
}
