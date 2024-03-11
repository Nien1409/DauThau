using System;
using System.Collections.Generic;

namespace BeDauThau.Models;

public partial class Tbmt
{
    public string? Tbmtid { get; set; }

    public DateTime? Bidclosedatetime { get; set; }

    public DateTime? Bidopendatetime { get; set; }

    public string? Bidopenaddress { get; set; }
}
