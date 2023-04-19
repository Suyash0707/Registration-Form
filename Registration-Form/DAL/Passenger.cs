using System;
using System.Collections.Generic;

namespace Registration_Form.DAL;

public partial class Passenger
{
    public int Seat { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? City { get; set; }
}
