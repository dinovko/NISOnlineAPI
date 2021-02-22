using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class QuestionTest: BusinessObjectBase
    {
        public string QuestionRU { get; set; }

        public string QuestionKZ { get; set; }        

        public int StudySubjectNameID { get; set; }

        public int TestTypeID { get; set; }

        public List<AnswerTest> AnswerTestData { get; set; }
    }
}
