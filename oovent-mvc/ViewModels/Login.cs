using System;
using com.paralib;
using com.paralib.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Oovent.Mvc.ViewModels
{
    public class Login
    {
        [Required]
        [ParaType(ParaTypes.Email)]
        public string Email { get; set; }

        [Required]
        [ParaType(ParaTypes.Password)]
        public string Password { get; set; }
    }
}