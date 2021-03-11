using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.HelperModel
{
    public class ADUser
    {
        public string Password { get; set; }

        public string Login { get; set; }

        public bool? IsValid { get; set; }
    }
}
