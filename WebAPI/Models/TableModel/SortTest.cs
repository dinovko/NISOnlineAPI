using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class SortTest : BusinessObjectBase
    {
        public int? TestDataTypeID { get; set; }

        public int? SortTypeID { get; set; }

        public string QuestionRU { get; set; }

        public string QuestionKZ { get; set; }

        public bool? IsQuestionStr { get; set; }

        public string QuestionImageRU { get; set; }

        public string QuestionImageKZ { get; set; }

        public bool? IsQuestionImage { get; set; }

        public string QuestionVideoRU { get; set; }

        public string QuestionVideoKZ { get; set; }

        public bool? IsQuestionVideo { get; set; }

        public int? SkillsNameID { get; set; }

        public int? FeedbackTestID { get; set; }

        public List<SortTestAnswer> SortTestAnswerObj { get; set; }
    }
}
