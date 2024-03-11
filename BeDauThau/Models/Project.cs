using System;
using System.Collections.Generic;

namespace BeDauThau.Models;

public partial class Project
{
    public string Pjid { get; set; } = null!;

    public string? Pjname { get; set; }

    public string? Oda { get; set; }

    public string? Investtarget { get; set; }

    public string? Investorname { get; set; }

    public string? Competentperson { get; set; }

    public string? Pjtime { get; set; }

    public string? Pjgroup { get; set; }

    public string? Khlcntid { get; set; }
}
