﻿// <auto-generated />
using System;
using DojoSurveysInfrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DojoSurveysApplication.Data.Migrations
{
    [DbContext(typeof(DojoSurveysDbContext))]
    partial class DojoSurveysDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoCompletedSurvey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CompletedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DojoCompletedSurveys");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoCompletedSurveyQuestionAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DojoCompletedSurveyId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DojoSurveyQuestionAnswerId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DojoSurveyQuestionId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DojoCompletedSurveyId");

                    b.HasIndex("DojoSurveyQuestionAnswerId");

                    b.HasIndex("DojoSurveyQuestionId");

                    b.ToTable("DojoCompletedSurveyQuestionAnswers");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoSurvey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DojoSurveys");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoSurveyQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AllowedAnswerCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("DojoQuestionType")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("DojoSurveyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Section")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DojoSurveyId");

                    b.ToTable("DojoSurveyQuestions");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoSurveyQuestionAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("DojoSurveyQuestionId")
                        .HasColumnType("TEXT");

                    b.Property<int>("SortOrder")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Value")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DojoSurveyQuestionId");

                    b.ToTable("DojoSurveyQuestionAnswers");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoCompletedSurveyQuestionAnswer", b =>
                {
                    b.HasOne("DojoSurveysCore.Entities.DojoCompletedSurvey", null)
                        .WithMany("DojoCompletedSurveyQuestionAnswers")
                        .HasForeignKey("DojoCompletedSurveyId");

                    b.HasOne("DojoSurveysCore.Entities.DojoSurveyQuestionAnswer", "DojoSurveyQuestionAnswer")
                        .WithMany()
                        .HasForeignKey("DojoSurveyQuestionAnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DojoSurveysCore.Entities.DojoSurveyQuestion", "DojoSurveyQuestion")
                        .WithMany()
                        .HasForeignKey("DojoSurveyQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DojoSurveyQuestion");

                    b.Navigation("DojoSurveyQuestionAnswer");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoSurveyQuestion", b =>
                {
                    b.HasOne("DojoSurveysCore.Entities.DojoSurvey", null)
                        .WithMany("DojoSurveyQuestions")
                        .HasForeignKey("DojoSurveyId");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoSurveyQuestionAnswer", b =>
                {
                    b.HasOne("DojoSurveysCore.Entities.DojoSurveyQuestion", null)
                        .WithMany("DojoSurveyQuestionAnswers")
                        .HasForeignKey("DojoSurveyQuestionId");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoCompletedSurvey", b =>
                {
                    b.Navigation("DojoCompletedSurveyQuestionAnswers");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoSurvey", b =>
                {
                    b.Navigation("DojoSurveyQuestions");
                });

            modelBuilder.Entity("DojoSurveysCore.Entities.DojoSurveyQuestion", b =>
                {
                    b.Navigation("DojoSurveyQuestionAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
