using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.BusinessObjects
{
    public class BRegistration : BusinessObjectBase
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string IIN { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public string Foto { get; set; }

        /// <summary>Является ли учеником</summary>
        public bool? IsSchoolboy { get; set; }

        /// <summary>Номер класса</summary>
        public int ClassID { get; set; }

        /// <summary>Язык обучения</summary>
        public int LanguageLearningID { get; set; }

        /// <summary>Школа</summary>
        public int SchoolID { get; set; }
    }
}
