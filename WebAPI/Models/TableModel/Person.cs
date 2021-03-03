using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.Base;

namespace WebAPI.Models.TableModel
{
    public class Person : BusinessObjectBase
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string IIN { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Email { get; set; }

        public string Foto { get; set; }
    }
}
