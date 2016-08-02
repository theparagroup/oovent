﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Oovent.Mvc.Areas.Public.Models
{
    public class VmLogin
    {
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
    }
}