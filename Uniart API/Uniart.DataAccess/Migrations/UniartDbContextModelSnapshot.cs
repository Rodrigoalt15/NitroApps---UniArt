﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Uniart.DataAccess;

namespace Uniart.DataAccess.Migrations
{
    [DbContext(typeof(UniartDbContext))]
    partial class UniartDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Uniart.Entities.Artista", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("Q_valoraciones")
                        .HasColumnType("int");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<string>("Url_foto_portada")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("Uniart.Entities.Caracteristica_Opciones", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("Servicio_Caracteristica_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Servicio_Caracteristica_Id");

                    b.ToTable("Caracteristicas_Opciones");
                });

            modelBuilder.Entity("Uniart.Entities.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Artista_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Usuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Artista_Id");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Uniart.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Pais_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Pais_Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("Uniart.Entities.Comision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha_entrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_inicio")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Monto_pago_final")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Monto_pago_inicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Porc_avance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Review_id_ArtistaId")
                        .HasColumnType("int");

                    b.Property<int?>("Review_id_ClienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Review_id_ArtistaId");

                    b.HasIndex("Review_id_ClienteId");

                    b.ToTable("Comisiones");
                });

            modelBuilder.Entity("Uniart.Entities.Envio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Comision_Id")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url_imagen_enviada")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Comision_Id");

                    b.ToTable("Envios");
                });

            modelBuilder.Entity("Uniart.Entities.Envio_Servicio_Ciudad", b =>
                {
                    b.Property<int>("Servicio_id")
                        .HasColumnType("int");

                    b.Property<int>("Ciudad_id")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo_envio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Servicio_id", "Ciudad_id");

                    b.HasIndex("Ciudad_id");

                    b.ToTable("Envios_Servicios_Ciudades");
                });

            modelBuilder.Entity("Uniart.Entities.Estilo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Estilos");
                });

            modelBuilder.Entity("Uniart.Entities.Formato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Formatos");
                });

            modelBuilder.Entity("Uniart.Entities.Licencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Licencias");
                });

            modelBuilder.Entity("Uniart.Entities.Mensaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Chat_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Hora_mensaje")
                        .HasColumnType("datetime2");

                    b.Property<string>("Texto_mensaje")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.HasKey("Id");

                    b.HasIndex("Chat_Id");

                    b.ToTable("Mensajes");
                });

            modelBuilder.Entity("Uniart.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Uniart.Entities.Propuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Servicio_Variacio_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Usuario_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Servicio_Variacio_Id");

                    b.HasIndex("Usuario_Id");

                    b.ToTable("Propuestas");
                });

            modelBuilder.Entity("Uniart.Entities.Red_Social", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Redes_Sociales");
                });

            modelBuilder.Entity("Uniart.Entities.Red_Social_Artista", b =>
                {
                    b.Property<int>("Red_social_id")
                        .HasColumnType("int");

                    b.Property<int>("Artista_id")
                        .HasColumnType("int");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Red_social_id", "Artista_id");

                    b.HasIndex("Artista_id");

                    b.ToTable("Redes_Sociales_Artistas");
                });

            modelBuilder.Entity("Uniart.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<short>("Rating_cliente")
                        .HasColumnType("smallint");

                    b.Property<int>("Valor_Negativo")
                        .HasColumnType("int");

                    b.Property<int>("Valor_Positivo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acerca_servicio")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int?>("Artista_Id")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duracion_esperada")
                        .HasColumnType("time");

                    b.Property<bool>("Es_virtual")
                        .HasColumnType("bit");

                    b.Property<int?>("Estilo_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Licencia_Id")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Porc_adelanto")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio_base")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Q_reviciones")
                        .HasColumnType("int");

                    b.Property<int>("Q_valoraciones")
                        .HasColumnType("int");

                    b.Property<short>("Rating")
                        .HasColumnType("smallint");

                    b.Property<int?>("Tecnica_Id")
                        .HasColumnType("int");

                    b.Property<bool>("acepta_rembolso")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Artista_Id");

                    b.HasIndex("Estilo_Id");

                    b.HasIndex("Licencia_Id");

                    b.HasIndex("Tecnica_Id");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Caracteristica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Servicios_Caracteristicas");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Formato", b =>
                {
                    b.Property<int>("Formato_id")
                        .HasColumnType("int");

                    b.Property<int>("Servicio_id")
                        .HasColumnType("int");

                    b.HasKey("Formato_id", "Servicio_id");

                    b.HasIndex("Servicio_id");

                    b.ToTable("Servicios_Formatos");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Tema", b =>
                {
                    b.Property<int>("Tema_id")
                        .HasColumnType("int");

                    b.Property<int>("Servicio_id")
                        .HasColumnType("int");

                    b.HasKey("Tema_id", "Servicio_id");

                    b.HasIndex("Servicio_id");

                    b.ToTable("Servicios_Temas");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Variacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Duracion_esperada")
                        .HasColumnType("time");

                    b.Property<bool>("Incluir_editable")
                        .HasColumnType("bit");

                    b.Property<int?>("Licencia_Id")
                        .HasColumnType("int");

                    b.Property<int>("Q_reviciones")
                        .HasColumnType("int");

                    b.Property<int?>("Servicio_Id")
                        .HasColumnType("int");

                    b.Property<string>("Url_imagen_referencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("precio_base")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("Licencia_Id");

                    b.HasIndex("Servicio_Id");

                    b.ToTable("Servicios_Variaciones");
                });

            modelBuilder.Entity("Uniart.Entities.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short>("Cvc")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("Fecha_vencimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre_completo")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Numero_tarjeta")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Tarjetas");
                });

            modelBuilder.Entity("Uniart.Entities.Tecnica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Tecnicas");
                });

            modelBuilder.Entity("Uniart.Entities.Tema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Temas");
                });

            modelBuilder.Entity("Uniart.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int?>("Ciudad_Id")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("Fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Nombre_usuario")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Url_foto_perfil")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Ciudad_Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Uniart.Entities.Usuario_Tarjeta", b =>
                {
                    b.Property<int>("Tarjeta_id")
                        .HasColumnType("int");

                    b.Property<int>("Usuario_id")
                        .HasColumnType("int");

                    b.HasKey("Tarjeta_id", "Usuario_id");

                    b.HasIndex("Usuario_id");

                    b.ToTable("Usuarios_Tarjetas");
                });

            modelBuilder.Entity("Uniart.Entities.Valoracion", b =>
                {
                    b.Property<int>("Usuario_id")
                        .HasColumnType("int");

                    b.Property<int>("Review_id")
                        .HasColumnType("int");

                    b.Property<bool>("Es_like")
                        .HasColumnType("bit");

                    b.HasKey("Usuario_id", "Review_id");

                    b.HasIndex("Review_id");

                    b.ToTable("Valoraciones");
                });

            modelBuilder.Entity("Uniart.Entities.Variacion_Detalle", b =>
                {
                    b.Property<int>("Servicio_Variacion_id")
                        .HasColumnType("int");

                    b.Property<int>("Caracteristica_Opciones_id")
                        .HasColumnType("int");

                    b.HasKey("Servicio_Variacion_id", "Caracteristica_Opciones_id");

                    b.HasIndex("Caracteristica_Opciones_id");

                    b.ToTable("Variacion_Detalles");
                });

            modelBuilder.Entity("Uniart.Entities.Artista", b =>
                {
                    b.HasOne("Uniart.Entities.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Uniart.Entities.Caracteristica_Opciones", b =>
                {
                    b.HasOne("Uniart.Entities.Servicio_Caracteristica", "Servicio_Caracteristica_")
                        .WithMany()
                        .HasForeignKey("Servicio_Caracteristica_Id");

                    b.Navigation("Servicio_Caracteristica_");
                });

            modelBuilder.Entity("Uniart.Entities.Chat", b =>
                {
                    b.HasOne("Uniart.Entities.Artista", "Artista_")
                        .WithMany()
                        .HasForeignKey("Artista_Id");

                    b.HasOne("Uniart.Entities.Usuario", "Usuario_")
                        .WithMany()
                        .HasForeignKey("Usuario_Id");

                    b.Navigation("Artista_");

                    b.Navigation("Usuario_");
                });

            modelBuilder.Entity("Uniart.Entities.Ciudad", b =>
                {
                    b.HasOne("Uniart.Entities.Pais", "Pais_")
                        .WithMany()
                        .HasForeignKey("Pais_Id");

                    b.Navigation("Pais_");
                });

            modelBuilder.Entity("Uniart.Entities.Comision", b =>
                {
                    b.HasOne("Uniart.Entities.Review", "Review_id_Artista")
                        .WithMany()
                        .HasForeignKey("Review_id_ArtistaId");

                    b.HasOne("Uniart.Entities.Review", "Review_id_Cliente")
                        .WithMany()
                        .HasForeignKey("Review_id_ClienteId");

                    b.Navigation("Review_id_Artista");

                    b.Navigation("Review_id_Cliente");
                });

            modelBuilder.Entity("Uniart.Entities.Envio", b =>
                {
                    b.HasOne("Uniart.Entities.Comision", "Comision_")
                        .WithMany()
                        .HasForeignKey("Comision_Id");

                    b.Navigation("Comision_");
                });

            modelBuilder.Entity("Uniart.Entities.Envio_Servicio_Ciudad", b =>
                {
                    b.HasOne("Uniart.Entities.Ciudad", "Ciudad")
                        .WithMany("Envios_Servicios_Ciudades")
                        .HasForeignKey("Ciudad_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uniart.Entities.Servicio", "Servicio")
                        .WithMany("Envios_Servicios_Ciudades")
                        .HasForeignKey("Servicio_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Servicio");
                });

            modelBuilder.Entity("Uniart.Entities.Mensaje", b =>
                {
                    b.HasOne("Uniart.Entities.Chat", "Chat_")
                        .WithMany()
                        .HasForeignKey("Chat_Id");

                    b.Navigation("Chat_");
                });

            modelBuilder.Entity("Uniart.Entities.Propuesta", b =>
                {
                    b.HasOne("Uniart.Entities.Servicio_Variacion", "Servicio_Variacio_")
                        .WithMany()
                        .HasForeignKey("Servicio_Variacio_Id");

                    b.HasOne("Uniart.Entities.Usuario", "Usuario_")
                        .WithMany()
                        .HasForeignKey("Usuario_Id");

                    b.Navigation("Servicio_Variacio_");

                    b.Navigation("Usuario_");
                });

            modelBuilder.Entity("Uniart.Entities.Red_Social_Artista", b =>
                {
                    b.HasOne("Uniart.Entities.Artista", "Artista")
                        .WithMany("Redes_Sociales_Artistas")
                        .HasForeignKey("Artista_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uniart.Entities.Red_Social", "Red_Social")
                        .WithMany("Redes_Sociales_Artistas")
                        .HasForeignKey("Red_social_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artista");

                    b.Navigation("Red_Social");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio", b =>
                {
                    b.HasOne("Uniart.Entities.Artista", "Artista_")
                        .WithMany()
                        .HasForeignKey("Artista_Id");

                    b.HasOne("Uniart.Entities.Estilo", "Estilo_")
                        .WithMany()
                        .HasForeignKey("Estilo_Id");

                    b.HasOne("Uniart.Entities.Licencia", "Licencia_")
                        .WithMany()
                        .HasForeignKey("Licencia_Id");

                    b.HasOne("Uniart.Entities.Tecnica", "Tecnica_")
                        .WithMany()
                        .HasForeignKey("Tecnica_Id");

                    b.Navigation("Artista_");

                    b.Navigation("Estilo_");

                    b.Navigation("Licencia_");

                    b.Navigation("Tecnica_");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Formato", b =>
                {
                    b.HasOne("Uniart.Entities.Formato", "Formato_")
                        .WithMany("Servicios_Formatos")
                        .HasForeignKey("Formato_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uniart.Entities.Servicio", "Servicio_")
                        .WithMany("Servicios_Formatos")
                        .HasForeignKey("Servicio_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Formato_");

                    b.Navigation("Servicio_");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Tema", b =>
                {
                    b.HasOne("Uniart.Entities.Servicio", "Servicio")
                        .WithMany("Servicios_Temas")
                        .HasForeignKey("Servicio_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uniart.Entities.Tema", "Tema")
                        .WithMany("Servicios_Temas")
                        .HasForeignKey("Tema_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servicio");

                    b.Navigation("Tema");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Variacion", b =>
                {
                    b.HasOne("Uniart.Entities.Licencia", "Licencia_")
                        .WithMany()
                        .HasForeignKey("Licencia_Id");

                    b.HasOne("Uniart.Entities.Servicio", "Servicio_")
                        .WithMany()
                        .HasForeignKey("Servicio_Id");

                    b.Navigation("Licencia_");

                    b.Navigation("Servicio_");
                });

            modelBuilder.Entity("Uniart.Entities.Usuario", b =>
                {
                    b.HasOne("Uniart.Entities.Ciudad", "Ciudad_")
                        .WithMany()
                        .HasForeignKey("Ciudad_Id");

                    b.Navigation("Ciudad_");
                });

            modelBuilder.Entity("Uniart.Entities.Usuario_Tarjeta", b =>
                {
                    b.HasOne("Uniart.Entities.Tarjeta", "Tarjeta")
                        .WithMany("Usuarios_Tarjetas")
                        .HasForeignKey("Tarjeta_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uniart.Entities.Usuario", "Usuario")
                        .WithMany("Usuarios_Tarjetas")
                        .HasForeignKey("Usuario_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tarjeta");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Uniart.Entities.Valoracion", b =>
                {
                    b.HasOne("Uniart.Entities.Review", "Review")
                        .WithMany("Valoraciones")
                        .HasForeignKey("Review_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uniart.Entities.Usuario", "Usuario")
                        .WithMany("Valoraciones")
                        .HasForeignKey("Usuario_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Uniart.Entities.Variacion_Detalle", b =>
                {
                    b.HasOne("Uniart.Entities.Caracteristica_Opciones", "Caracteristica_Opciones")
                        .WithMany("Variacion_Detalles")
                        .HasForeignKey("Caracteristica_Opciones_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Uniart.Entities.Servicio_Variacion", "Servicio_Variacion")
                        .WithMany("Variacion_Detalles")
                        .HasForeignKey("Servicio_Variacion_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Caracteristica_Opciones");

                    b.Navigation("Servicio_Variacion");
                });

            modelBuilder.Entity("Uniart.Entities.Artista", b =>
                {
                    b.Navigation("Redes_Sociales_Artistas");
                });

            modelBuilder.Entity("Uniart.Entities.Caracteristica_Opciones", b =>
                {
                    b.Navigation("Variacion_Detalles");
                });

            modelBuilder.Entity("Uniart.Entities.Ciudad", b =>
                {
                    b.Navigation("Envios_Servicios_Ciudades");
                });

            modelBuilder.Entity("Uniart.Entities.Formato", b =>
                {
                    b.Navigation("Servicios_Formatos");
                });

            modelBuilder.Entity("Uniart.Entities.Red_Social", b =>
                {
                    b.Navigation("Redes_Sociales_Artistas");
                });

            modelBuilder.Entity("Uniart.Entities.Review", b =>
                {
                    b.Navigation("Valoraciones");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio", b =>
                {
                    b.Navigation("Envios_Servicios_Ciudades");

                    b.Navigation("Servicios_Formatos");

                    b.Navigation("Servicios_Temas");
                });

            modelBuilder.Entity("Uniart.Entities.Servicio_Variacion", b =>
                {
                    b.Navigation("Variacion_Detalles");
                });

            modelBuilder.Entity("Uniart.Entities.Tarjeta", b =>
                {
                    b.Navigation("Usuarios_Tarjetas");
                });

            modelBuilder.Entity("Uniart.Entities.Tema", b =>
                {
                    b.Navigation("Servicios_Temas");
                });

            modelBuilder.Entity("Uniart.Entities.Usuario", b =>
                {
                    b.Navigation("Usuarios_Tarjetas");

                    b.Navigation("Valoraciones");
                });
#pragma warning restore 612, 618
        }
    }
}
