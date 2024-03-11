using System;
using System.Collections.Generic;

namespace BeDauThau.Models;

public partial class Noticeinfo
{
    public string? Noticeid { get; set; }

    public string Noticefullname { get; set; } = null!;

    public string Noticetitle { get; set; } = null!;

    public string Noticedepartment { get; set; } = null!;

    public string Noticenation { get; set; } = null!;

    public string Noticeauthtype { get; set; } = null!;

    public string Noticeauthnumber { get; set; } = null!;

    public DateTime Noticeauthdate { get; set; }

    public DateTime Noticedate { get; set; }

    public string Noticephonenumber { get; set; } = null!;

    public string Noticeemail { get; set; } = null!;

    public string Billemail { get; set; } = null!;

    public string? Userid { get; set; }

    public virtual Userinfo? User { get; set; }
}
