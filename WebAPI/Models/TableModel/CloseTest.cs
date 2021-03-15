using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.TableModel
{
    public class CloseTest : BusinessObjectBase
    {
        public int? TestDataTypeID { get; set; }

        public string QuestionRU { get; set; }

        public string QuestionKZ { get; set; }

        public bool? IsQuestionStr { get; set; }

        public string QuestionImage { get; set; }

        public bool? IsQuestionImage { get; set; }

        public int? SkillsNameID { get; set; }

        public int? FeedbackTestID { get; set; }

        public List<CloseTestAnswer> CloseTestAnswerObj { get; set; }
    }
}
