
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class SortTestAnswer : BusinessObjectBase
    {
        public int? SortTestID { get; set; }

        public string AnswerRU { get; set; }

        public string AnswerKZ { get; set; }

        public string AnswerImageRU { get; set; }

        public string AnswerImageKZ { get; set; }

        public bool? IsTrue { get; set; }

        public int? KeyNumber { get; set; }

        public bool? IsAnswerStr { get; set; }

        public bool? IsAnswerImage { get; set; }
    }
}
