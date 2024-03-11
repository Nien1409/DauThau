using System;
using System.Collections.Generic;

namespace BeDauThau.Models;

public partial class Userinfo
{
    public string Userid { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string? Englishname { get; set; }

    public string? Workplacetype { get; set; }

    public string Hqaddress { get; set; } = null!;

    public string Hqphonenumber { get; set; } = null!;

    public string? Hqwwebsite { get; set; }

    public virtual ICollection<Thueinfo> Thueinfos { get; set; } = new List<Thueinfo>();
}
