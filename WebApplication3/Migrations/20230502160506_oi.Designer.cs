﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.DBContext;

#nullable disable

namespace WebApplication3.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230502160506_oi")]
    partial class oi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication3.DBContext.CV_upload", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("type");

                    b.HasKey("id");

                    b.ToTable("CV_uploads");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Job_postId")
                        .HasColumnType("int");

                    b.Property<int>("User_idComment")
                        .HasColumnType("int");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("text");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Company", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Name");

                    b.Property<string>("about")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("about");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("services_about")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("services_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Cv_Creat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("AboutMe");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceYear")
                        .HasColumnType("int");

                    b.Property<int>("Gpa")
                        .HasColumnType("int");

                    b.Property<string>("Languages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("Skills");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_idCv_Creat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cv_Creats");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("FileData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ResumeFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Resume");
                });

            modelBuilder.Entity("WebApplication3.DBContext.TblSalesHeader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifyUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("NetTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TblSalesHeaders");
                });

            modelBuilder.Entity("WebApplication3.DBContext.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Universitys");
                });

            modelBuilder.Entity("WebApplication3.DBContext.UserAccount", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("Gpa")
                        .HasColumnType("int");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cv_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("WebApplication3.DBContext.applyJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Full_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GPA")
                        .HasColumnType("int");

                    b.Property<int>("Phone_Number")
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pushJobid")
                        .HasColumnType("int");

                    b.Property<int?>("userUId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("pushJobid");

                    b.HasIndex("userUId");

                    b.ToTable("applyJobs");
                });

            modelBuilder.Entity("WebApplication3.DBContext.cv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceYear")
                        .HasColumnType("int");

                    b.Property<int>("Gpa")
                        .HasColumnType("int");

                    b.Property<string>("Languages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone_number")
                        .HasColumnType("int");

                    b.Property<int?>("useruid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("useruid");

                    b.ToTable("cvs");
                });

            modelBuilder.Entity("WebApplication3.DBContext.image_post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("image_file")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("image_file");

                    b.Property<string>("image_name")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("image_name");

                    b.Property<string>("image_type")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("image_type");

                    b.HasKey("id");

                    b.ToTable("image_posts");
                });

            modelBuilder.Entity("WebApplication3.DBContext.notifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("User_idnotifications")
                        .HasColumnType("int");

                    b.Property<string>("notificat_text")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("notificat_text");

                    b.HasKey("Id");

                    b.ToTable("notificationss");
                });

            modelBuilder.Entity("WebApplication3.DBContext.pushJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Job_Deadline")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pre_title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requrment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("companyid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("companyid");

                    b.ToTable("pushJobs");
                });

            modelBuilder.Entity("WebApplication3.DBContext.student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ages")
                        .HasColumnType("int");

                    b.Property<int?>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("UniversityId");

                    b.ToTable("students");
                });

            modelBuilder.Entity("WebApplication3.DBContext.userU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("Varchar(Max)")
                        .HasColumnName("First_Name");

                    b.Property<int?>("GPA")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Last_Name");

                    b.Property<string>("ResetPasswordToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("userUs");
                });

            modelBuilder.Entity("WebApplication3.DBContext.applyJob", b =>
                {
                    b.HasOne("WebApplication3.DBContext.pushJob", "pushJob")
                        .WithMany("applyJobs")
                        .HasForeignKey("pushJobid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication3.DBContext.userU", null)
                        .WithMany("applyJobs")
                        .HasForeignKey("userUId");

                    b.Navigation("pushJob");
                });

            modelBuilder.Entity("WebApplication3.DBContext.cv", b =>
                {
                    b.HasOne("WebApplication3.DBContext.userU", "useru")
                        .WithMany("cvs")
                        .HasForeignKey("useruid");

                    b.Navigation("useru");
                });

            modelBuilder.Entity("WebApplication3.DBContext.pushJob", b =>
                {
                    b.HasOne("WebApplication3.DBContext.Company", "company")
                        .WithMany("pushJobs")
                        .HasForeignKey("companyid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("company");
                });

            modelBuilder.Entity("WebApplication3.DBContext.student", b =>
                {
                    b.HasOne("WebApplication3.DBContext.Gender", "Gender")
                        .WithMany("students")
                        .HasForeignKey("GenderId");

                    b.HasOne("WebApplication3.DBContext.University", "University")
                        .WithMany("students")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("University");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Company", b =>
                {
                    b.Navigation("pushJobs");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Gender", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("WebApplication3.DBContext.University", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("WebApplication3.DBContext.pushJob", b =>
                {
                    b.Navigation("applyJobs");
                });

            modelBuilder.Entity("WebApplication3.DBContext.userU", b =>
                {
                    b.Navigation("applyJobs");

                    b.Navigation("cvs");
                });
#pragma warning restore 612, 618
        }
    }
}
