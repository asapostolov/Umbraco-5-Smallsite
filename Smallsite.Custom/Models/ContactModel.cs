using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions;

namespace Smallsite.Custom
{
    /// <summary>
    /// The model for Contact form
    /// </summary>
    public class ContactModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [Email]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}