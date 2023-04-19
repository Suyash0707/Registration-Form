using System;
using System.Collections.Generic;

namespace Registration_Form.DAL;

public partial class Member
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Mobile { get; set; }

    public DateTime? JoiningDate { get; set; }

    public string? Duration { get; set; }
}
