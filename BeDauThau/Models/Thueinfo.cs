using System;
using System.Collections.Generic;

namespace BeDauThau.Models;

public partial class Thueinfo
{
    public string Mathue { get; set; } = null!;

    public DateTime Datethue { get; set; }

    public string Country { get; set; } = null!;

    public string? Userid { get; set; }

    public virtual Userinfo? User { get; set; }
}
