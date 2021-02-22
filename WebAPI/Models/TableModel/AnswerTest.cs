using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class AnswerTest : BusinessObjectBase
    {
        public string AnswerRU { get; set; }

        public string AnswerKZ { get; set; }

        public int QuestionTestID { get; set; }

        public bool IsTrue { get; set; }
    }
}
