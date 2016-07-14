using com.paralib.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Oovent.Mvc.Models.Register
{
    public class VmRegister
    {
        [Required(ErrorMessage = "*")]
        [ParaType(ParaTypes.Email)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [ParaType(ParaTypes.Password)]
        public string Password { get; set; }
    }
}