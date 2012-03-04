using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// The model for Contact form
/// </summary>
public class ContactModel
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    [Required]
    public string Email { get; set; }

    public string Message { get; set; }
}