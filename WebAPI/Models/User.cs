using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
    }
}
