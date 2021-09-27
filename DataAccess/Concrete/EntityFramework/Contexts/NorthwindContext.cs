using Core.Entities;
using Core.Entities.Concrete;

//using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UstasiYapsinAPI.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //    .AddJsonFile("appsetting.json")
            //    .Build();
            optionsBuilder.UseSqlServer
                (@"Server=LAPTOP-GLNUG4P0\MSSQLSERVER2;Database=UstasiYapsin;Trusted_Connection=true");
            //configuration.GetConnectionString("DefaultConnection"));
        }

      
        public DbSet<OperationClaim> OperationClaim { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaim { get; set; }

        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }

        public DbSet<Address> Address { get; set; }
        public DbSet<AnswerForOrderQuestion> AnswerForOrderQuestions { get; set; }
        public DbSet<BusinessUser> BusinessUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FavoriteProvider> FavoriteProviders { get; set; }
        public DbSet<FrequentlyQuestionAnswer> FrequentlyQuestionAnswers { get; set; }
        public DbSet<Ilceler> Ilcelers { get; set; }
        public DbSet<Iller> Illers { get; set; }
        public DbSet<MobileImage> MobileImages { get; set; }
        public DbSet<OfferFromCustomer> OfferFromCustomers  { get; set; }
        public DbSet<OfferFromServiceProvider> OfferFromServiceProviders { get; set; }
        public DbSet<OfferStatusFromProvider> OfferStatusFromProviders { get; set; }
        public DbSet<OrderFromCustomer> OrderFromCustomers { get; set; }
        public DbSet<OrderFromCustomerStatus> OrderFromCustomerStatus { get; set; }
        public DbSet<PhotosForOrder> PhotosForOrders { get; set; }
        public DbSet<QuestionMain> QuestionMains { get; set; }
        public DbSet<Referance> Referances { get; set; }
        public DbSet<ReferancePhoto> ReferancePhotos { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<ServiceProviderComment> ServiceProviderComments { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Wallet> Wallets { get; set; }


        public DbSet<SysLog> SysLogs { get; set; }
    }
}
