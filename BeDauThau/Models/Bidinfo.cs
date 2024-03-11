using System;
using System.Collections.Generic;

namespace BeDauThau.Models;

public partial class Bidinfo
{
    public string? Bidname { get; set; }

    public string? Investdetail { get; set; }

    public string? Bidtime { get; set; }

    public DateTime? Lcntdate { get; set; }

    public DateTime? Biddate { get; set; }

    public string? Bidaddress { get; set; }
}
