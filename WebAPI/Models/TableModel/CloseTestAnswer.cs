using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.TableModel
{
    public class CloseTestAnswer : BusinessObjectBase
    {
        public int? CloseTestID { get; set; }

        public string AnswerRU { get; set; }

        public string AnswerKZ { get; set; }

        public string AnswerImageRU { get; set; }

        public string AnswerImageKZ { get; set; }

        public bool? IsTrue { get; set; }

        public bool? IsAnswerStr { get; set; }

        public bool? IsAnswerImage { get; set; }
    }
}
