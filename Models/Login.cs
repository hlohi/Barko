using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barko.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        public int Password { get; set; }
        public string EmailAdrress { get; set; }
       


    }
}
