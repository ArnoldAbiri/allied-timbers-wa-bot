﻿using System.Data.Entity;
using AlliedTimbers.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AlliedTimbers.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext()
        : base("DefaultConnection", false)
    {
        Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<ProductInfo> ProductInfos { get; set; }
    //public DbSet<ProductFile> ProductFiles { get; set; }
    public DbSet<CompanyBranch> CompanyBranches { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Faq> Faqs { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<QuickResponse> QuickResponses { get; set; }
    public DbSet<LoanApplication> LoanApplications { get; set; }
    public DbSet<Audit> Audits { get; set; }

    public static ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }
}