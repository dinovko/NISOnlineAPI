using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class StandartTest: BusinessObjectBase
    {

        public string QuestionRU { get; set; }

        public string QuestionKZ { get; set; }

        public string Answer_1 { get; set; }

        public string Answer_2 { get; set; }

        public string Answer_3 { get; set; }

        public string Answer_4 { get; set; }

        public int StudySubjectNameID { get; set; }
    }
}
