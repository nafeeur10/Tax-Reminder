﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Tax_Reminder.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<TaxInformationModel> TaxInformationModels { get; set; }
        public DbSet<ContactUsModel> ContactUsModels{ get; set;}
        public DbSet<DiscDesignModel> DiscDesignModels { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}