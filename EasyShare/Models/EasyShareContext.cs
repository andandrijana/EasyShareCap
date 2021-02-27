using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EasyShare.Models
{
    public partial class EasyShareContext : DbContext
    {
        public EasyShareContext()
        {
        }

        public EasyShareContext(DbContextOptions<EasyShareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyTags> CompanyTags { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<ProjectTags> ProjectTags { get; set; }
        public virtual DbSet<ProjectTeams> ProjectTeams { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<UserSecurity> UserSecurity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS19;Database=EasyShare;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<CompanyTags>(entity =>
            {
                entity.HasKey(e => e.CompanyTagId);

                entity.Property(e => e.CompanyTagId).ValueGeneratedNever();

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasMaxLength(65);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyTags)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyTags_Company");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.CompanyDepartmentId);

                entity.Property(e => e.CompanyDepartmentId).ValueGeneratedNever();

                entity.Property(e => e.Department1)
                    .IsRequired()
                    .HasColumnName("Department")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Department_Company");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeId).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastLoggedIn).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.EmployeesEmployee)
                    .HasForeignKey<Employees>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_UserSecurity");

                entity.HasOne(d => d.Security)
                    .WithMany(p => p.EmployeesSecurity)
                    .HasForeignKey(d => d.SecurityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Company");
            });

            modelBuilder.Entity<ProjectTags>(entity =>
            {
                entity.HasKey(e => e.ProjectTagId);

                entity.Property(e => e.ProjectTagId).ValueGeneratedNever();

                entity.Property(e => e.ProjectTag)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProjectTags)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTags_Company");
            });

            modelBuilder.Entity<ProjectTeams>(entity =>
            {
                entity.HasKey(e => e.ProjectTeamId);

                entity.Property(e => e.ProjectTeamId).ValueGeneratedNever();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProjectTeams)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTeams_Company");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.ProjectTeams)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTeams_Employees");

                entity.HasOne(d => d.ProjectTeam)
                    .WithOne(p => p.ProjectTeams)
                    .HasForeignKey<ProjectTeams>(d => d.ProjectTeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTeams_Projects");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.Property(e => e.ProjectId).ValueGeneratedNever();

                entity.Property(e => e.ProjectDescription)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompanyDepartment)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CompanyDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Department");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projects_Company");
            });

            modelBuilder.Entity<UserSecurity>(entity =>
            {
                entity.HasKey(e => e.SecurityId);

                entity.Property(e => e.SecurityId).ValueGeneratedNever();

                entity.Property(e => e.SecurityLevel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
