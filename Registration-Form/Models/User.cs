using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Registration_Form.Models;

public partial class User
{
    public int Id { get; set; }
    [Required]
    [EmailAddress]
    [Remote(action:"IsEmailIdValid", controller:"Home")]
    public string? Email { get; set; }
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    public int? GendersId { get; set; }
    [Required]
    [RegularExpression(@"^(\+?\d{1,4}[\s-])?(?!0+\s+,?$)\d{10}\s*,?$")]
    public string? MobileNumber { get; set; }
    public virtual Gender? Genders { get; set; }
}
