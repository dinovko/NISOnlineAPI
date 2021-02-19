using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.Base
{
    public class BaseDictionary: BusinessObjectBase
    {
        /// <summary>Наименование на русском</summary>
        public string NameRU { get; set; }

        /// <summary>Наименование на казахском</summary>
        public string NameKZ { get; set; }

        public string PublicCode { get; set; }

        public DateTime BeginDate { get; set; }

        public DateTime? EndDate { get; set; }

        ///// <summary>Локализованное наименование</summary>
        //public string Name
        //{
        //    get { return GetLocalizedName(NameRU, NameKZ); }
        //}
    }
}
