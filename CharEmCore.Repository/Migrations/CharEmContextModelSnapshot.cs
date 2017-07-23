using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CharEmCore.Repository;

namespace CharEmCore.Repository.Migrations
{
    [DbContext(typeof(CharEmContext))]
    partial class CharEmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharEmCore.API.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<int>("CityId");

                    b.Property<int>("CountyId");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountyId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CountyId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountyId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<int?>("ServiceId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.County", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Counties");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<int>("CountyId");

                    b.Property<string>("Description");

                    b.Property<bool?>("IsSchool");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountyId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<string>("Details")
                        .HasMaxLength(5000);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Details");

                    b.Property<int>("LeadContactId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OrganizationId");

                    b.Property<int>("ServiceTypeId");

                    b.HasKey("Id");

                    b.HasIndex("LeadContactId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("CharEmCore.Repository.Entities.OrganizationLocations", b =>
                {
                    b.Property<int>("OrganizationId");

                    b.Property<int>("LocationId");

                    b.HasKey("OrganizationId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("OrganizationLocations");
                });

            modelBuilder.Entity("CharEmCore.Repository.Entities.ServiceLocations", b =>
                {
                    b.Property<int>("ServiceId");

                    b.Property<int>("LocationId");

                    b.HasKey("ServiceId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("ServiceLocations");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Address", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmCore.API.Entities.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmCore.API.Entities.City", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.County", "County")
                        .WithMany("Cities")
                        .HasForeignKey("CountyId");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Contact", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.Address", "Address")
                        .WithMany("Contacts")
                        .HasForeignKey("AddressId");

                    b.HasOne("CharEmCore.API.Entities.Service")
                        .WithMany("OtherContacts")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Location", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.City", "City")
                        .WithMany("Locations")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmCore.API.Entities.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Organization", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.Address", "Address")
                        .WithMany("Organizations")
                        .HasForeignKey("AddressId");
                });

            modelBuilder.Entity("CharEmCore.API.Entities.Service", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.Contact", "LeadContact")
                        .WithMany()
                        .HasForeignKey("LeadContactId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmCore.API.Entities.Organization", "Organization")
                        .WithMany("Services")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmCore.API.Entities.ServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmCore.Repository.Entities.OrganizationLocations", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.Location", "Location")
                        .WithMany("OrganizationLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmCore.API.Entities.Organization", "Organization")
                        .WithMany("OrganizationLocations")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmCore.Repository.Entities.ServiceLocations", b =>
                {
                    b.HasOne("CharEmCore.API.Entities.Location", "Location")
                        .WithMany("ServiceLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmCore.API.Entities.Service", "Service")
                        .WithMany("ServiceLocations")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
