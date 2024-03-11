using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BeDauThau.Models;

public partial class DauThauContext : DbContext
{
    public DauThauContext()
    {
    }

    public DauThauContext(DbContextOptions<DauThauContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Approvaldecisioninfo> Approvaldecisioninfos { get; set; }

    public virtual DbSet<Bidinfo> Bidinfos { get; set; }

    public virtual DbSet<Expert> Experts { get; set; }

    public virtual DbSet<Khlcntinfo> Khlcntinfos { get; set; }

    public virtual DbSet<Legalinfo> Legalinfos { get; set; }

    public virtual DbSet<Noticeinfo> Noticeinfos { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Tbmst> Tbmsts { get; set; }

    public virtual DbSet<Tbmt> Tbmts { get; set; }

    public virtual DbSet<Thueinfo> Thueinfos { get; set; }

    public virtual DbSet<Userinfo> Userinfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-0BBMM3F\\MSSQLSERVERLOCAL;Initial Catalog=DauThau;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Approvaldecisioninfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("APPROVALDECISIONINFO");

            entity.Property(e => e.Decagency)
                .HasMaxLength(100)
                .HasColumnName("decagency");
            entity.Property(e => e.Khlcntapprdate)
                .HasColumnType("date")
                .HasColumnName("KHLCNTapprdate");
            entity.Property(e => e.Khlcntapprid)
                .HasMaxLength(50)
                .HasColumnName("KHLCNTapprid");
        });

        modelBuilder.Entity<Bidinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BIDINFO");

            entity.Property(e => e.Bidaddress)
                .HasMaxLength(255)
                .HasColumnName("bidaddress");
            entity.Property(e => e.Biddate)
                .HasColumnType("date")
                .HasColumnName("biddate");
            entity.Property(e => e.Bidname)
                .HasMaxLength(100)
                .HasColumnName("bidname");
            entity.Property(e => e.Bidtime)
                .HasMaxLength(100)
                .HasColumnName("bidtime");
            entity.Property(e => e.Investdetail).HasColumnName("investdetail");
            entity.Property(e => e.Lcntdate)
                .HasColumnType("date")
                .HasColumnName("LCNTdate");
        });

        modelBuilder.Entity<Expert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EXPERT");

            entity.Property(e => e.Expertid)
                .HasMaxLength(50)
                .HasColumnName("expertid");
        });

        modelBuilder.Entity<Khlcntinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("KHLCNTINFO");

            entity.Property(e => e.Approvedstatus)
                .HasMaxLength(100)
                .HasColumnName("approvedstatus");
            entity.Property(e => e.Bidcount).HasColumnName("bidcount");
            entity.Property(e => e.Khlcntid)
                .HasMaxLength(50)
                .HasColumnName("KHLCNTid");
            entity.Property(e => e.Khlcntname)
                .HasMaxLength(100)
                .HasColumnName("KHLCNTname");
            entity.Property(e => e.Khlcnttype)
                .HasMaxLength(100)
                .HasColumnName("KHLCNTtype");
            entity.Property(e => e.Prepunitname)
                .HasMaxLength(100)
                .HasColumnName("prepunitname");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Legalinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LEGALINFO");

            entity.Property(e => e.Legalauthdate)
                .HasColumnType("date")
                .HasColumnName("legalauthdate");
            entity.Property(e => e.Legalauthnumber)
                .HasMaxLength(100)
                .HasColumnName("legalauthnumber");
            entity.Property(e => e.Legalauthtype)
                .HasMaxLength(100)
                .HasColumnName("legalauthtype");
            entity.Property(e => e.Legaldepartment)
                .HasMaxLength(100)
                .HasColumnName("legaldepartment");
            entity.Property(e => e.Legalemail)
                .HasMaxLength(255)
                .HasColumnName("legalemail");
            entity.Property(e => e.Legalid)
                .HasMaxLength(50)
                .HasColumnName("legalid");
            entity.Property(e => e.Legalname)
                .HasMaxLength(100)
                .HasColumnName("legalname");
            entity.Property(e => e.Legalnation)
                .HasMaxLength(100)
                .HasColumnName("legalnation");
            entity.Property(e => e.Legalphonenumber)
                .HasMaxLength(20)
                .HasColumnName("legalphonenumber");
            entity.Property(e => e.Legaltitle)
                .HasMaxLength(100)
                .HasColumnName("legaltitle");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("FK__LEGALINFO__useri__4316F928");
        });

        modelBuilder.Entity<Noticeinfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NOTICEINFO");

            entity.Property(e => e.Billemail)
                .HasMaxLength(255)
                .HasColumnName("billemail");
            entity.Property(e => e.Noticeauthdate)
                .HasColumnType("date")
                .HasColumnName("noticeauthdate");
            entity.Property(e => e.Noticeauthnumber)
                .HasMaxLength(100)
                .HasColumnName("noticeauthnumber");
            entity.Property(e => e.Noticeauthtype)
                .HasMaxLength(100)
                .HasColumnName("noticeauthtype");
            entity.Property(e => e.Noticedate)
                .HasColumnType("date")
                .HasColumnName("noticedate");
            entity.Property(e => e.Noticedepartment)
                .HasMaxLength(100)
                .HasColumnName("noticedepartment");
            entity.Property(e => e.Noticeemail)
                .HasMaxLength(255)
                .HasColumnName("noticeemail");
            entity.Property(e => e.Noticefullname)
                .HasMaxLength(100)
                .HasColumnName("noticefullname");
            entity.Property(e => e.Noticeid)
                .HasMaxLength(50)
                .HasColumnName("noticeid");
            entity.Property(e => e.Noticenation)
                .HasMaxLength(100)
                .HasColumnName("noticenation");
            entity.Property(e => e.Noticephonenumber)
                .HasMaxLength(20)
                .HasColumnName("noticephonenumber");
            entity.Property(e => e.Noticetitle)
                .HasMaxLength(100)
                .HasColumnName("noticetitle");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("FK__NOTICEINF__useri__440B1D61");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Pjid).HasName("PK__PROJECT__5E43A0F1752CCEA4");

            entity.ToTable("PROJECT");

            entity.Property(e => e.Pjid)
                .HasMaxLength(50)
                .HasColumnName("PJid");
            entity.Property(e => e.Competentperson)
                .HasMaxLength(100)
                .HasColumnName("competentperson");
            entity.Property(e => e.Investorname)
                .HasMaxLength(100)
                .HasColumnName("investorname");
            entity.Property(e => e.Investtarget).HasColumnName("investtarget");
            entity.Property(e => e.Khlcntid)
                .HasMaxLength(50)
                .HasColumnName("KHLCNTid");
            entity.Property(e => e.Oda)
                .HasMaxLength(100)
                .HasColumnName("ODA");
            entity.Property(e => e.Pjgroup)
                .HasMaxLength(100)
                .HasColumnName("PJgroup");
            entity.Property(e => e.Pjname)
                .HasMaxLength(100)
                .HasColumnName("PJname");
            entity.Property(e => e.Pjtime)
                .HasMaxLength(100)
                .HasColumnName("PJtime");
        });

        modelBuilder.Entity<Tbmst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBMST");

            entity.Property(e => e.Bidname)
                .HasMaxLength(100)
                .HasColumnName("bidname");
            entity.Property(e => e.Bmtname)
                .HasMaxLength(100)
                .HasColumnName("BMTname");
            entity.Property(e => e.Field)
                .HasMaxLength(100)
                .HasColumnName("field");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .HasColumnName("status");
            entity.Property(e => e.Tbmstid)
                .HasMaxLength(50)
                .HasColumnName("TBMSTid");
            entity.Property(e => e.Version)
                .HasMaxLength(100)
                .HasColumnName("version");
        });

        modelBuilder.Entity<Tbmt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBMT");

            entity.Property(e => e.Bidclosedatetime)
                .HasColumnType("datetime")
                .HasColumnName("bidclosedatetime");
            entity.Property(e => e.Bidopenaddress)
                .HasMaxLength(255)
                .HasColumnName("bidopenaddress");
            entity.Property(e => e.Bidopendatetime)
                .HasColumnType("datetime")
                .HasColumnName("bidopendatetime");
            entity.Property(e => e.Tbmtid)
                .HasMaxLength(50)
                .HasColumnName("TBMTid");
        });

        modelBuilder.Entity<Thueinfo>(entity =>
        {
            entity.HasKey(e => e.Mathue).HasName("PK__THUEINFO__F2F60EEAAC74DC90");

            entity.ToTable("THUEINFO");

            entity.Property(e => e.Mathue)
                .HasMaxLength(50)
                .HasColumnName("mathue");
            entity.Property(e => e.Country)
                .HasMaxLength(100)
                .HasColumnName("country");
            entity.Property(e => e.Datethue)
                .HasColumnType("date")
                .HasColumnName("datethue");
            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Thueinfos)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("FK__THUEINFO__userid__44FF419A");
        });

        modelBuilder.Entity<Userinfo>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__USERINFO__CBA1B2574A44F968");

            entity.ToTable("USERINFO");

            entity.Property(e => e.Userid)
                .HasMaxLength(50)
                .HasColumnName("userid");
            entity.Property(e => e.Englishname)
                .HasMaxLength(100)
                .HasColumnName("englishname");
            entity.Property(e => e.Fullname)
                .HasMaxLength(100)
                .HasColumnName("fullname");
            entity.Property(e => e.Hqaddress)
                .HasMaxLength(255)
                .HasColumnName("hqaddress");
            entity.Property(e => e.Hqphonenumber)
                .HasMaxLength(20)
                .HasColumnName("hqphonenumber");
            entity.Property(e => e.Hqwwebsite)
                .HasMaxLength(255)
                .HasColumnName("hqwwebsite");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .HasColumnName("role");
            entity.Property(e => e.Workplacetype)
                .HasMaxLength(100)
                .HasColumnName("workplacetype");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
