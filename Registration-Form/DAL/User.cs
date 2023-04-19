using System;
using System.Collections.Generic;

namespace Registration_Form.DAL;

public partial class User
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? GendersId { get; set; }

    public string? MobileNumber { get; set; }

    public string? Password { get; set; }

    public string? AdharNumber { get; set; }

    public virtual Gender? Genders { get; set; }
}
