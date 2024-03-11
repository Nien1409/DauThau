using System;
using System.Collections.Generic;

namespace BeDauThau.Models;

public partial class Legalinfo
{
    public string? Legalid { get; set; }

    public string Legalname { get; set; } = null!;

    public string Legaltitle { get; set; } = null!;

    public string? Legaldepartment { get; set; }

    public string Legalnation { get; set; } = null!;

    public string Legalauthtype { get; set; } = null!;

    public string Legalauthnumber { get; set; } = null!;

    public DateTime Legalauthdate { get; set; }

    public string Legalphonenumber { get; set; } = null!;

    public string Legalemail { get; set; } = null!;

    public string? Userid { get; set; }

    public virtual Userinfo? User { get; set; }
}
