using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Marktkaart.Data;

namespace MarktkaartAPI.Migrations
{
    [DbContext(typeof(MarktkaartDbContext))]
    [Migration("20170617110906_NewModel_06172017")]
    partial class NewModel_06172017
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.3");

            modelBuilder.Entity("Marktkaart.Models.Markt", b =>
                {
                    b.Property<string>("Guid");

                    b.Property<string>("Adres");

                    b.Property<string>("Beschrijving");

                    b.Property<string>("Gemeente");

                    b.Property<string>("Naam");

                    b.Property<string>("Plaats");

                    b.Property<double>("X");

                    b.Property<double>("Y");

                    b.HasKey("Guid");

                    b.ToTable("Markten");
                });
        }
    }
}
