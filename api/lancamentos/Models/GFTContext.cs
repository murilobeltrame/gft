using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace lancamentos.Models
{
    public partial class GFTContext : DbContext
    {
        public virtual DbSet<Apontamento> Apontamento { get; set; }
        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Consultoria> Consultoria { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Lancamento> Lancamento { get; set; }
        public virtual DbSet<Terceiro> Terceiro { get; set; }
        public virtual DbSet<TipoLancamento> TipoLancamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=172.16.99.80,56001;Database=GFT;User Id=appGFT;Password=appGFTdev;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apontamento>(entity =>
            {
                entity.HasKey(e => e.IdApontamento)
                    .HasName("apontamento_PK");

                entity.ToTable("apontamento");

                entity.Property(e => e.IdApontamento).HasColumnName("id_apontamento");

                entity.Property(e => e.AnexoDespesaApontamento).HasColumnName("anexo_despesa_apontamento");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.HorasTotalApontamento)
                    .HasColumnName("horas_total_apontamento")
                    .HasColumnType("decimal");

                entity.Property(e => e.IdStatusApontamento).HasColumnName("id_status_apontamento");

                entity.Property(e => e.IdTerceiro).HasColumnName("id_terceiro");

                entity.Property(e => e.MesAnoApontamento)
                    .IsRequired()
                    .HasColumnName("mes_ano_apontamento")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.NmAnexoDespesaApontamento)
                    .HasColumnName("nm_anexo_despesa_apontamento")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.ObsDespesaApontamento)
                    .HasColumnName("obs_despesa_apontamento")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.TpAnexoDespesaApontamento)
                    .HasColumnName("tp_anexo_despesa_apontamento")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.VlDespesaApontamento)
                    .HasColumnName("vl_despesa_apontamento")
                    .HasColumnType("decimal");

                entity.Property(e => e.VlTotalApontamento)
                    .HasColumnName("vl_total_apontamento")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.IdTerceiroNavigation)
                    .WithMany(p => p.Apontamento)
                    .HasForeignKey(d => d.IdTerceiro)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("terceiro_apontamento_FK1");
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasKey(e => e.IdArea)
                    .HasName("area_PK");

                entity.ToTable("area");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.CnpjArea)
                    .IsRequired()
                    .HasColumnName("cnpj_area")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CodSapArea)
                    .IsRequired()
                    .HasColumnName("cod_sap_area")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlCriapedidoauto)
                    .HasColumnName("fl_criapedidoauto")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FlFaturarEmpresa).HasColumnName("fl_faturar_empresa");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.NmArea)
                    .IsRequired()
                    .HasColumnName("nm_area")
                    .HasColumnType("varchar(200)");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("empresa_area_FK1");
            });

            modelBuilder.Entity<Consultoria>(entity =>
            {
                entity.HasKey(e => e.IdConsultoria)
                    .HasName("consultoria_PK");

                entity.ToTable("consultoria");

                entity.Property(e => e.IdConsultoria).HasColumnName("id_consultoria");

                entity.Property(e => e.CdConsultoria)
                    .HasColumnName("cd_consultoria")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmConsultoria)
                    .IsRequired()
                    .HasColumnName("nm_consultoria")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa)
                    .HasName("empresa_PK");

                entity.ToTable("empresa");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.CdSap)
                    .IsRequired()
                    .HasColumnName("cd_sap")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Cnpj)
                    .HasColumnName("cnpj")
                    .HasColumnType("varchar(14)");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlInativo)
                    .HasColumnName("fl_inativo")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IdAmbienteSap).HasColumnName("id_AmbienteSAP");

                entity.Property(e => e.NmEmpresa)
                    .IsRequired()
                    .HasColumnName("nm_empresa")
                    .HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Lancamento>(entity =>
            {
                entity.HasKey(e => e.IdLancamento)
                    .HasName("lancamento_PK");

                entity.ToTable("lancamento");

                entity.Property(e => e.IdLancamento).HasColumnName("id_lancamento");

                entity.Property(e => e.DsLancamento)
                    .IsRequired()
                    .HasColumnName("ds_lancamento")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtLancamento)
                    .HasColumnName("dt_lancamento")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoraLancamento).HasColumnName("hora_lancamento");

                entity.Property(e => e.IdApontamento).HasColumnName("id_apontamento");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.IdGrade).HasColumnName("id_grade");

                entity.Property(e => e.IdInformacaoNotaFiscal).HasColumnName("id_informacao_nota_fiscal");

                entity.Property(e => e.IdLancamentoFoot).HasColumnName("id_lancamento_foot");

                entity.Property(e => e.IdResponsavel).HasColumnName("id_responsavel");

                entity.Property(e => e.IdStatusLancamento).HasColumnName("id_status_lancamento");

                entity.Property(e => e.IdTipoLancamento).HasColumnName("id_tipo_lancamento");

                entity.Property(e => e.MinutoLancamento).HasColumnName("minuto_lancamento");

                entity.Property(e => e.NrProjetoLancamento)
                    .HasColumnName("nr_projeto_lancamento")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.NrRequisicao)
                    .IsRequired()
                    .HasColumnName("nr_requisicao")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ObsLancamento)
                    .HasColumnName("obs_lancamento")
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.IdApontamentoNavigation)
                    .WithMany(p => p.Lancamento)
                    .HasForeignKey(d => d.IdApontamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("apontamento_lancamento_FK1");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.Lancamento)
                    .HasForeignKey(d => d.IdArea)
                    .HasConstraintName("area_lancamento_FK1");

                entity.HasOne(d => d.IdTipoLancamentoNavigation)
                    .WithMany(p => p.Lancamento)
                    .HasForeignKey(d => d.IdTipoLancamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("tipo_lancamento_lancamento_FK1");
            });

            modelBuilder.Entity<Terceiro>(entity =>
            {
                entity.HasKey(e => e.IdTerceiro)
                    .HasName("terceiro_PK");

                entity.ToTable("terceiro");

                entity.Property(e => e.IdTerceiro).HasColumnName("id_terceiro");

                entity.Property(e => e.CodPerfilTerceiro)
                    .IsRequired()
                    .HasColumnName("cod_perfil_terceiro")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ContratoTerceiro)
                    .IsRequired()
                    .HasColumnName("contrato_terceiro")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmailTerceiro)
                    .IsRequired()
                    .HasColumnName("email_terceiro")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.FlFootprints).HasColumnName("fl_footprints");

                entity.Property(e => e.FlForponto).HasColumnName("fl_forponto");

                entity.Property(e => e.FlInativo).HasColumnName("fl_inativo");

                entity.Property(e => e.IdConsultoria).HasColumnName("id_consultoria");

                entity.Property(e => e.IdTerceiroGestorResponsavel).HasColumnName("id_terceiro_gestor_responsavel");

                entity.Property(e => e.ImAnexoTerceiro).HasColumnName("im_anexo_terceiro");

                entity.Property(e => e.NmAnexoTerceiro)
                    .HasColumnName("nm_anexo_terceiro")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.NmTerceiro)
                    .IsRequired()
                    .HasColumnName("nm_terceiro")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.TpAnexoTerceiro)
                    .HasColumnName("tp_anexo_terceiro")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TrTerceiro)
                    .IsRequired()
                    .HasColumnName("tr_terceiro")
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.IdConsultoriaNavigation)
                    .WithMany(p => p.Terceiro)
                    .HasForeignKey(d => d.IdConsultoria)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("consultoria_terceiro_FK1");
            });

            modelBuilder.Entity<TipoLancamento>(entity =>
            {
                entity.HasKey(e => e.IdTipoLancamento)
                    .HasName("tipo_lancamento_PK");

                entity.ToTable("tipo_lancamento");

                entity.Property(e => e.IdTipoLancamento)
                    .HasColumnName("id_tipo_lancamento")
                    .ValueGeneratedNever();

                entity.Property(e => e.DsTipoLancamento)
                    .IsRequired()
                    .HasColumnName("ds_tipo_lancamento")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.DtAlt)
                    .HasColumnName("dt_alt")
                    .HasColumnType("datetime");

                entity.Property(e => e.NmTipoLancamento)
                    .IsRequired()
                    .HasColumnName("nm_tipo_lancamento")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}