using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace webapi1.Models
{
    public partial class BlackboardUVEFContext : DbContext
    {
        public BlackboardUVEFContext()
        {
        }

        public BlackboardUVEFContext(DbContextOptions<BlackboardUVEFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentGradeValue> StudentGradeValue { get; set; }
        public virtual DbSet<SubGrade> SubGrade { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStringDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.GradeRecNo)
                    .HasName("PK__Grade__471CA90F65D020F8");

                entity.Property(e => e.GradeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentRecNo)
                    .HasName("PK__Student__178BE51A946064A9");

                entity.Property(e => e.StudentFirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId)
                    .HasColumnName("StudentID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StudentLastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StudentMajor)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StudentGradeValue>(entity =>
            {
                entity.HasKey(e => e.SgvrecNo);

                entity.Property(e => e.SgvrecNo).HasColumnName("SGVRecNo");

                entity.Property(e => e.GradeDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SubGrade>(entity =>
            {
                entity.HasKey(e => e.SubGradeRecNo)
                    .HasName("PK__SubGrade__372158E8A0F9F050");

                entity.Property(e => e.GradeDate).HasColumnType("datetime");

                entity.Property(e => e.SubGradeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => e.SubjectRecNo)
                    .HasName("PK__Subject__195BEDAEC4227D6F");

                entity.Property(e => e.Course)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
