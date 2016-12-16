using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace grades.Models
{
    public partial class GFTContext : DbContext
    {
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<Responsavel> Responsavel { get; set; }
        public virtual DbSet<ResponsavelGrade> ResponsavelGrade { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=172.16.99.80,56001;Database=GFT;User Id=appGFT;Password=appGFTdev;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.IdGrade)
                    .HasName("PK__grade__6DB797E44CA06362");

                entity.ToTable("grade");

                entity.Property(e => e.IdGrade).HasColumnName("id_grade");

                entity.Property(e => e.FlCriapedidoauto).HasColumnName("fl_criapedidoauto");

                entity.Property(e => e.FlInativo)
                    .HasColumnName("fl_Inativo")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NmGrade)
                    .IsRequired()
                    .HasColumnName("nm_grade")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.SgGrade)
                    .IsRequired()
                    .HasColumnName("sg_grade")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<Responsavel>(entity =>
            {
                entity.HasKey(e => e.IdResponsavel)
                    .HasName("responsavel_PK");

                entity.ToTable("responsavel");

                entity.Property(e => e.IdResponsavel).HasColumnName("id_responsavel");

                entity.Property(e => e.CsResponsavel)
                    .IsRequired()
                    .HasColumnName("cs_responsavel")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailResponsavel)
                    .IsRequired()
                    .HasColumnName("email_responsavel")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.FlAprovador).HasColumnName("fl_aprovador");

                entity.Property(e => e.FlAprovadorExcedente)
                    .HasColumnName("fl_aprovador_excedente")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FlInativo).HasColumnName("fl_inativo");

                entity.Property(e => e.FlRelatorio).HasColumnName("fl_relatorio");

                entity.Property(e => e.NmResponsavel)
                    .IsRequired()
                    .HasColumnName("nm_responsavel")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.RamalResponsavel)
                    .HasColumnName("ramal_responsavel")
                    .HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<ResponsavelGrade>(entity =>
            {
                entity.HasKey(e => new { e.IdResponsavel, e.IdGrade })
                    .HasName("PK__responsa__6B05382160A75C0F");

                entity.ToTable("responsavel_grade");

                entity.Property(e => e.IdResponsavel).HasColumnName("id_responsavel");

                entity.Property(e => e.IdGrade).HasColumnName("id_grade");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlAtivo)
                    .HasColumnName("fl_ativo")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FlDefault)
                    .HasColumnName("fl_default")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.IdGradeNavigation)
                    .WithMany(p => p.ResponsavelGrade)
                    .HasForeignKey(d => d.IdGrade)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_responsavel_grade_grade");

                entity.HasOne(d => d.IdResponsavelNavigation)
                    .WithMany(p => p.ResponsavelGrade)
                    .HasForeignKey(d => d.IdResponsavel)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_responsavel_grade_responsavel");
            });
        }
    }
}