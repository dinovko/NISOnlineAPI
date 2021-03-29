using NSIManager.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NISManager.BusinessObjects
{
    public class Person : BusinessObjectBase
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string IIN { get; set; }

        //public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public string Foto { get; set; }

        public Users UsersObj { get; set; }
    }
}
