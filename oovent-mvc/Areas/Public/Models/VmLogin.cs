using com.paralib.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Oovent.Mvc.Areas.Public.Models
{
    public class VmLogin
    {
        [Required(ErrorMessage = "*")]
        [ParaType(ParaTypes.Email)]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        [ParaType(ParaTypes.Password)]
        public string Password { get; set; }
    }
}