using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class QuestionInputTest : BusinessObjectBase
    {
        public string QuestionBeginRU { get; set; }

        public string QuestionEndRU { get; set; }

        public string QuestionBeginKZ { get; set; }

        public string QuestionEndKZ { get; set; }

        public string AnswerInputRU { get; set; }

        public string AnswerInputKZ { get; set; }

        public int StudySubjectNameID { get; set; }

        public int TestTypeID { get; set; }
    }
}
