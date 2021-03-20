﻿// <auto-generated />
using System;
using Commander.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Commander.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210318071213_18-March")]
    partial class _18March
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Commander.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeActivateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("VARCHAR(250)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Commander.Models.Batch", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BatchName")
                        .IsRequired()
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Batch");
                });

            modelBuilder.Entity("Commander.Models.Conference", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BatchId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasJoinedByHost")
                        .HasColumnType("bit");

                    b.Property<bool>("HasJoinedByParticipant")
                        .HasColumnType("bit");

                    b.Property<string>("HostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoomId")
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("HostId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("Conference");
                });

            modelBuilder.Entity("Commander.Models.ConferenceHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ConferenceId")
                        .HasColumnType("bigint");

                    b.Property<string>("ConnectionId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("HostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("JoineDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LeaveDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoomId")
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("ConferenceHistory");
                });

            modelBuilder.Entity("Commander.Models.ProjectBatch", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BatchId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("ProjectId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectBatch");
                });

            modelBuilder.Entity("Commander.Models.ProjectBatchHost", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("HostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("ProjectBatchId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("HostId");

                    b.HasIndex("ProjectBatchId");

                    b.ToTable("ProjectBatchHost");
                });

            modelBuilder.Entity("Commander.Models.ProjectBatchHostParticipant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("ProjectBatchHostId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("ProjectBatchHostId");

                    b.ToTable("ProjectBatchHostParticipant");
                });

            modelBuilder.Entity("Commander.Models.VClass", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan?>("ActualCallDuration")
                        .HasColumnType("time");

                    b.Property<long>("BatchId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan?>("EmptySlotDuration")
                        .HasColumnType("time");

                    b.Property<TimeSpan?>("HostCallDuration")
                        .HasColumnType("time");

                    b.Property<string>("HostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ParticipantJoined")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("ParticipantsCallDuration")
                        .HasColumnType("time");

                    b.Property<string>("RoomId")
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.Property<DateTime?>("ScheduleDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UniqueParticipantCounts")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("HostId");

                    b.ToTable("VClass");
                });

            modelBuilder.Entity("Commander.Models.VClassDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BatchId")
                        .HasColumnType("bigint");

                    b.Property<string>("ConnectionId")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("HostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("JoinTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LeaveTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoomId")
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.Property<long>("VClassId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("HostId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("VClassDetail");
                });

            modelBuilder.Entity("Commander.Models.VClassInvitation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("BatchId")
                        .HasColumnType("bigint");

                    b.Property<string>("HostId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("InvitationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParticipantId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoomId")
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("VClassId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("HostId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("VClassInvitation");
                });

            modelBuilder.Entity("Commander.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Commander.Models.Conference", b =>
                {
                    b.HasOne("Commander.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Commander.Models.ApplicationUser", "Host")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Commander.Models.ApplicationUser", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Batch");

                    b.Navigation("Host");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Commander.Models.ConferenceHistory", b =>
                {
                    b.HasOne("Commander.Models.ApplicationUser", "Host")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Commander.Models.ApplicationUser", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Host");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Commander.Models.ProjectBatch", b =>
                {
                    b.HasOne("Commander.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Commander.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Batch");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Commander.Models.ProjectBatchHost", b =>
                {
                    b.HasOne("Commander.Models.ApplicationUser", "Host")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Commander.Models.ProjectBatch", "ProjectBatch")
                        .WithMany()
                        .HasForeignKey("ProjectBatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Host");

                    b.Navigation("ProjectBatch");
                });

            modelBuilder.Entity("Commander.Models.ProjectBatchHostParticipant", b =>
                {
                    b.HasOne("Commander.Models.ApplicationUser", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Commander.Models.ProjectBatchHost", "ProjectBatchHost")
                        .WithMany()
                        .HasForeignKey("ProjectBatchHostId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("ProjectBatchHost");
                });

            modelBuilder.Entity("Commander.Models.VClass", b =>
                {
                    b.HasOne("Commander.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Commander.Models.ApplicationUser", "Host")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Batch");

                    b.Navigation("Host");
                });

            modelBuilder.Entity("Commander.Models.VClassDetail", b =>
                {
                    b.HasOne("Commander.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Commander.Models.ApplicationUser", "Host")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Commander.Models.ApplicationUser", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Batch");

                    b.Navigation("Host");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Commander.Models.VClassInvitation", b =>
                {
                    b.HasOne("Commander.Models.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Commander.Models.ApplicationUser", "Host")
                        .WithMany()
                        .HasForeignKey("HostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Commander.Models.ApplicationUser", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Batch");

                    b.Navigation("Host");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Commander.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Commander.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Commander.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Commander.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
