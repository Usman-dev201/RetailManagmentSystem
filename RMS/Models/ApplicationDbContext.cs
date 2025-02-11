using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using RMS.Models.Entities;

namespace RMS.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SalesCommissionAgent> SalesCommissionAgents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PurchaseRecord> PurchaseRecords { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductPurchaseRecord> ProductPurchaseRecords { get; set; }

        public DbSet<Rack> Racks { get; set; }
        public DbSet<RackProductRecord> RackProductRecords { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<PurchaseReturn> PurchaseReturns { get; set; }

        public DbSet<StockTransfer> StockTransfers { get; set; }
       
        public DbSet <StockAdjustment> StockAdjustments { get; set; }
        
        //////////////////////////////////////////
        //////////////////////////////////////////

        public DbSet<Customer> Customers { get; set; }
        public DbSet<MarketingCampaign> MarketingCampaigns { get; set; }

        public DbSet<LoyaltyProgram> LoyaltyPrograms { get; set; }
        public DbSet<CustomerLoyaltyRecord> CustomerLoyaltyRecords { get; set; }
        public DbSet<SalesTransaction> SalesTransactions { get; set; }
        public DbSet<SalesTransactionDetail> SalesTransactionDetails { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DraftOrder> DraftOrders { get; set; }
        public DbSet<DraftOrderDetail> DraftOrderDetails { get; set; }
        public DbSet<CustomerFeedback> CustomerFeedbacks    { get; set; }
        public DbSet<ReturnandExchange> ReturnandExchanges { get; set; }
        public DbSet<ShippingDetail> ShippingDetails { get; set; }
        //public DbSet<ShippingTracking> ShippingTrackings { get; set; }
        public DbSet<ExpenseTracking> ExpenseTrackings { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => u.UserID);
            modelBuilder.Entity<User>()
                .Property(u => u.UserID)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
                .HasOne(r => r.Role)
                .WithMany(u => u.Users)
                .HasForeignKey(r => r.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            ///////////////////////////////////////////
            /////////////////////////////////////////
            
            modelBuilder.Entity<Role>()
                .HasKey(r=>r.RoleId);
            modelBuilder.Entity<Role>()
                .Property(r=>r.RoleId)
                .ValueGeneratedOnAdd();
            ///////////////////////////////////////////
            ////////////////////////////////////////
            modelBuilder.Entity<SalesCommissionAgent>()
                .HasKey(sca => sca.AgentId);
            modelBuilder.Entity<SalesCommissionAgent>()
                .Property(sca => sca.AgentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SalesCommissionAgent>()
             .HasOne(u => u.User)
             .WithMany(sca => sca.SalesCommissionAgents)
             .HasForeignKey(u => u.UserId);
            modelBuilder.Entity<SalesCommissionAgent>()
                .HasOne(st => st.SalesTransaction)
                .WithMany(sca => sca.SalesCommissionAgents)
                .HasForeignKey(st => st.TransactionId);
            ////////////////////////////////////////
            //////////////////////////////////////
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);
                
            modelBuilder.Entity<Product>()
                .Property(p => p.ProductId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Product>()
                .HasOne(c => c.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

           modelBuilder.Entity<Product>()
                .HasOne(b => b.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(p => p.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .HasOne(t => t.Tax) 
                .WithMany(t => t.Products)
                
                .HasForeignKey(t => t.TaxId)
             .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Product>()
                .HasOne(d => d.Discount)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.DiscountId)
                .OnDelete(DeleteBehavior.Restrict);

            ////////////////////////////////////////////
            ///////////////////////////////////////////

            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);

            modelBuilder.Entity<Category>()
                .Property(c => c.CategoryId)
                .ValueGeneratedOnAdd();
            //////////////////
            ////////////////////////
            modelBuilder.Entity<Brand>()
                .HasKey(b => b.BrandId);

            modelBuilder.Entity<Brand>()
                .Property(b => b.BrandId)
                .ValueGeneratedOnAdd();
            /////////////////////////////////////////
            //////////////////////////////////////

            modelBuilder.Entity<Tax>()
                .HasKey(t => t.TaxId);

            modelBuilder.Entity<Tax>()
                .Property(t => t.TaxId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Tax>()
                .HasOne(l => l.Location)
                .WithMany(t => t.Taxes)
                .HasForeignKey(t => t.LocationId)
               .OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////////////////////
            //////////////////////////////////////////////
            modelBuilder.Entity<Location>()
                .HasKey(l => l.LocationId);

            modelBuilder.Entity<Location>()
                .Property(l => l.LocationId)
                .ValueGeneratedOnAdd();

            /////////////////////////////////
            ///////////////////////////////

            modelBuilder.Entity<PurchaseRecord>()
               .HasKey(p => p.PurchaseId);
            modelBuilder.Entity<PurchaseRecord>()
                .Property(p => p.PurchaseId)
                .ValueGeneratedOnAdd();
            //////////////////////////////////////
            ///////////////////////////////////
            modelBuilder.Entity<Supplier>()
               .HasKey(p => p.SupplierId);

            modelBuilder.Entity<Supplier>()
                .Property(p => p.SupplierId)
                .ValueGeneratedOnAdd();

        ///////////////////////////////////////////////
        ////////////////////////////////////////////////
            modelBuilder.Entity<ProductPurchaseRecord>()
                .HasKey(p => p.LotId);

        modelBuilder.Entity<ProductPurchaseRecord>()
                .Property (p => p.LotId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<ProductPurchaseRecord>()
                 .HasOne(p => p.Product)
                 .WithMany(ppr => ppr.ProductPurchaseRecords)
                 .HasForeignKey(p => p.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductPurchaseRecord>()
                .HasOne(pr => pr.PurchaseRecord)
                .WithMany(ppr =>ppr.ProductPurchaseRecords)
                .HasForeignKey(pr => pr.PurchaseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductPurchaseRecord>()
            .HasOne(s => s.Supplier)
            .WithMany(ppr => ppr.ProductPurchaseRecords)
            .HasForeignKey(s => s.SupplierId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductPurchaseRecord>()
            .HasOne(l => l.Location)
            .WithMany(ppr => ppr.ProductPurchaseRecords)
            .HasForeignKey(l => l.LocationId)
            .OnDelete(DeleteBehavior.Restrict);

            //////////////////////////////////////////////
            //////////////////////////////////////////////

            modelBuilder.Entity<Rack>()
                .HasKey(r => r.RackId);

            modelBuilder.Entity<Rack>()
                .Property(r => r.RackId)
                .ValueGeneratedOnAdd();

            /////////////////////////////
            //////////////////////////////
            modelBuilder.Entity<RackProductRecord>()
                .HasKey(rp => rp.RackProductId);

            modelBuilder.Entity<RackProductRecord>()
                .Property(rp => rp.RackProductId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<RackProductRecord>()
                .HasOne(r =>r.Rack)
                .WithMany(rp =>rp.RacksProductRecords)
                .HasForeignKey(r => r.RackId)
                .OnDelete(DeleteBehavior.Restrict);

            ////////////////////////////////
            //////////////////////////////

            modelBuilder.Entity<Stock>()
                .HasKey(s => s.StockId);
            modelBuilder.Entity<Stock>()
                .Property(s => s.StockId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Stock>()
                .HasOne(ppr => ppr.ProductPurchaseRecord)
                .WithMany(s => s.Stocks)
                .HasForeignKey(ppr => ppr.LotId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Stock>()
               .HasMany(sa => sa.StockAdjustments)
               .WithMany(s => s.Stocks)
               .UsingEntity<Dictionary<string, object>>(
               "StockAdjustmentDetail",
               sa => sa.HasOne<StockAdjustment>()
               .WithMany()
               .HasForeignKey("AdjustmentId")
               .HasPrincipalKey(nameof(StockAdjustment.AdjustmentId)),
               s => s.HasOne<Stock>()
               .WithMany()
               .HasForeignKey("StockId")
               .HasPrincipalKey(nameof(Stock.StockId)),
               sad => sad.HasKey("StockId", "AdjustmentId")

               );
            modelBuilder.Entity<Stock>()
                .HasMany(st => st.StockTransfers)
                .WithMany(s => s.Stocks)
                .UsingEntity<Dictionary<string, object>>(
                "StockTransferDetail",
                st => st.HasOne<StockTransfer>()
                .WithMany()
                .HasForeignKey("TransferId")
                .HasPrincipalKey(nameof(StockTransfer.TransferId)),
                s => s.HasOne<Stock>()
                .WithMany()
                .HasForeignKey("StockId")
                .HasPrincipalKey(nameof(Stock.StockId)),
                std => std.HasKey("StockId", "TransferId")
                );
            //////////////////////////////
            /////////////////////////////

            modelBuilder.Entity<PurchaseReturn>()
                .HasKey(pr => pr.PurchaseReturnId);

            modelBuilder.Entity<PurchaseReturn>()
                .Property(pr => pr.PurchaseReturnId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<PurchaseReturn>()
                .HasOne(ppr =>ppr.ProductPurchaseRecord)
                .WithMany(pr =>pr.PurchaseReturns)
                .HasForeignKey(ppr => ppr.LotId)
                .OnDelete(DeleteBehavior.Restrict);

            //////////////////////////////////////////
            //////////////////////////////////////////
            modelBuilder.Entity<StockTransfer>()
                .HasKey(st =>st.TransferId);
            modelBuilder.Entity<StockTransfer>()
                .Property(st => st.TransferId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<StockTransfer>()
                .HasOne(l => l.FromLocation)
                .WithMany(st => st.FromStockTransfers)
                .HasForeignKey(l => l.FromLocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StockTransfer>()
                .HasOne(l =>l.ToLocation)
                .WithMany(st => st.ToStockTransfers)
                .HasForeignKey(l =>l.ToLocationId) 
                .OnDelete(DeleteBehavior.Restrict);

            

            /////////////////////////////////////////////
            ///////////////////////////////////////////

            modelBuilder.Entity<StockAdjustment>()
                 .HasKey(sa => sa.AdjustmentId);
            modelBuilder.Entity<StockAdjustment>()
                .Property(sa => sa.AdjustmentId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<StockAdjustment>()
                .HasOne(l => l.Location)
                .WithMany(sa => sa.StockAdjustments)
                .HasForeignKey(l => l.LocationId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<StockAdjustment>()
                .HasOne(pr => pr.PurchaseReturn)
                .WithOne(sa =>sa.StockAdjustment)
                .HasForeignKey<StockAdjustment>(sa => sa.PurchaseReturnId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<StockAdjustment>()
                .HasOne(sr => sr.ReturnandExchange)
                .WithOne(sa => sa.StockAdjustment)
                .HasForeignKey<StockAdjustment>(sa => sa.SalesReturnId)
                .OnDelete(DeleteBehavior.Restrict);
         
            ////////////////////////////////////////
            ///////////////////////////////////////
            modelBuilder.Entity<Customer>()
                .HasKey(c=>c.CustomerId);
            modelBuilder.Entity<Customer>()
                .Property(c => c.CustomerId)
                .ValueGeneratedOnAdd();
            //////////////////////////////////////////
            //////////////////////////////////////////
            modelBuilder.Entity<MarketingCampaign>()
                .HasKey(mc=>mc.CampaignId);
            modelBuilder.Entity<MarketingCampaign>()
                .Property(mc => mc.CampaignId)
                .ValueGeneratedOnAdd();
            ////////////////////////////////////////////
            ///////////////////////////////////////////
            modelBuilder.Entity<MarketingCampaign>()
            .HasMany(mc => mc.SalesTransactionDetails)
            .WithMany(std => std.MarketingCampaigns)
             .UsingEntity<Dictionary<string, object>>(
                "SaleCampaignRecords",
                std => std.HasOne<SalesTransactionDetail>()
                .WithMany()
                .HasForeignKey("TransactionDetailId")
                .HasPrincipalKey(nameof(SalesTransactionDetail.TransactionDetailId)),
                 mc => mc.HasOne<MarketingCampaign>()
             .WithMany()
             .HasForeignKey("CampaignId")
             .HasPrincipalKey(nameof(MarketingCampaign.CampaignId)),
              scr => scr.HasKey("TransactionDetailId", "CampaignId")
     );

            //////////////////////////////////////
            ////////////////////////////////////
            //modelBuilder.Entity<CampaignTargetRecord>()
            //    .HasKey(ctr => ctr.CampaignTargetId);
            //modelBuilder.Entity<CampaignTargetRecord>()
            //    .Property(ctr => ctr.CampaignTargetId)
            //    .ValueGeneratedOnAdd();
            //modelBuilder.Entity<CampaignTargetRecord>()
            //    .HasOne(std => std.SalesTransactionDetail)
            //    .WithMany(ctr => ctr.CampaignTargetRecords)
            //    .HasForeignKey(std => std.TransactionDetailId)
            //    .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<CampaignTargetRecord>()
            //     .HasOne(mc=>mc.MarketingCampaign)
            //     .WithMany(ctr => ctr.CampaignTargetRecords)
            //     .HasForeignKey(mc=>mc.CampaignId)
            //     .OnDelete(DeleteBehavior.Restrict);
            ////////////////////////////////////////
            /////////////////////////////////////////
            modelBuilder.Entity<LoyaltyProgram>()
                .HasKey(lp => lp.ProgramID);
             modelBuilder.Entity<LoyaltyProgram>()
                .Property(lp => lp.ProgramID)
                .ValueGeneratedOnAdd();
            /////////////////////////////////////
            ///////////////////////////////////
            modelBuilder.Entity<CustomerLoyaltyRecord>()
                .HasKey(clr=>clr.CustomerLoyaltyRecordId);
            modelBuilder.Entity<CustomerLoyaltyRecord>()
                .Property(clr => clr.CustomerLoyaltyRecordId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<CustomerLoyaltyRecord>()
                .HasOne(td => td.SalesTransactionDetail)
                .WithMany(clr => clr.CustomerLoyaltyRecords)
                .HasForeignKey(td => td.TransactionDetailId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CustomerLoyaltyRecord>()
               .HasOne(lp=>lp.LoyaltyProgram)
               .WithMany(clr => clr.CustomerLoyaltyRecords)
               .HasForeignKey(lp=>lp.LoyaltyProgramId)
               .OnDelete(DeleteBehavior.Restrict);
           

            /////////////////////////////////////////
            /////////////////////////////////////////
            modelBuilder.Entity<SalesTransaction>()
                .HasKey(st=>st.TransactionId);
            modelBuilder.Entity<SalesTransaction>()
                .Property(st => st.TransactionId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SalesTransaction>()
                .HasOne(c =>c.Customer)
                .WithMany(st =>st.SalesTransactions)
                .HasForeignKey (c => c.CustomerId)
                .OnDelete (DeleteBehavior.Restrict);
            modelBuilder.Entity<SalesTransaction>()
                .HasOne(u=>u.User)
                .WithMany(st=>st.SalesTransactions)
                .HasForeignKey (u => u.UserId)
                .OnDelete (DeleteBehavior.Restrict);

            ///////////////////////////////////////////
            //////////////////////////////////////////
            modelBuilder.Entity<SalesTransactionDetail>()
                .HasKey(std => std.TransactionDetailId);
            modelBuilder.Entity<SalesTransactionDetail>()
                .Property(std=>std.TransactionDetailId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<SalesTransactionDetail>()
                .HasOne(st =>st.SalesTransaction)
                .WithMany(std =>std.SalesTransactionDetails)
                .HasForeignKey(st =>st.TransactionId)
                .OnDelete(DeleteBehavior.Restrict);
          
            modelBuilder.Entity<SalesTransactionDetail>()
              .HasOne(s=>s.Stock)
              .WithMany(std => std.SalesTransactionDetails)
              .HasForeignKey(s=>s.StockId)
              .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<SalesTransactionDetail>()
                .HasOne(d=>d.Discount)
                .WithMany(std =>std.SalesTransactionDetails)
                .HasForeignKey(d=>d.DiscountId) 
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SalesTransactionDetail>()
               .HasOne(d=>d.DraftOrderDetail)
               .WithOne(std =>std.SalesTransactionDetail)
               .HasForeignKey<SalesTransactionDetail>(d=>d.DraftOrderDetailId)
               .OnDelete(DeleteBehavior.Restrict);
            //////////////////////////////////////////////
            //////////////////////////////////////////////
            modelBuilder.Entity<Discount>()
                .HasKey(d => d.DiscountId);
            modelBuilder.Entity<Discount>()
                .Property(d => d.DiscountId)
                .ValueGeneratedOnAdd();

            /////////////////////////////////////////
            /////////////////////////////////////////
            modelBuilder.Entity<DraftOrder>()
                .HasKey(d => d.DraftOrderId);
            modelBuilder.Entity<DraftOrder>()
                .Property(d=> d.DraftOrderId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<DraftOrder>()
                .HasOne(c =>c.Customer)
                .WithMany(d =>d.DraftOrders)
                .HasForeignKey(c =>c.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            //////////////////////////////////////////
            //////////////////////////////////////////
            modelBuilder.Entity<DraftOrderDetail>()
                .HasKey(d => d.DraftOrderDetailId);
            modelBuilder.Entity<DraftOrderDetail>()
                .Property(d=>d.DraftOrderDetailId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<DraftOrderDetail>()
                .HasOne(d => d.DraftOrder)
                .WithMany(d => d.DraftOrderDetails)
                .HasForeignKey(d => d.DraftOrderId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DraftOrderDetail>()
                .HasOne(p=>p.Product)
                .WithMany(d => d.DraftOrderDetails)
                .HasForeignKey(p=>p.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<DraftOrderDetail>()
                .HasOne(d=>d.Discount)
                .WithMany(d => d.DraftOrderDetails)
                .HasForeignKey(d=>d.DiscountId)
                .OnDelete(DeleteBehavior.Restrict);
            ////////////////////////////////////////
            //////////////////////////////////////////
            modelBuilder.Entity<CustomerFeedback>()
                .HasKey(cf=>cf.FeedbackId);
            modelBuilder.Entity<CustomerFeedback>()
                .Property(cf => cf.FeedbackId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<CustomerFeedback>()
                .HasOne(cf => cf.SalesTransactionDetail)
                .WithMany(std => std.CustomerFeedbacks)
                .HasForeignKey(cf => cf.TransactionDetailId)
                .OnDelete(DeleteBehavior.Restrict);
            ///////////////////////////////////////////////
            ////////////////////////////////////////////////
            modelBuilder.Entity<ReturnandExchange>()
                .HasKey(re => re.SalesReturnId);
            modelBuilder.Entity<ReturnandExchange>()
                .Property(re=>re.SalesReturnId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ReturnandExchange>()
                .HasOne(cf => cf.SalesTransactionDetail)
                .WithMany(re=>re.ReturnandExchanges)
                .HasForeignKey(cf => cf.TransactionDetailId)
                .OnDelete(DeleteBehavior.Restrict);
            //////////////////////////////////////////////////
            ///////////////////////////////////////////////////
            modelBuilder.Entity<ShippingDetail>()
                .HasKey(sd=>sd.ShippingId);
            modelBuilder.Entity<ShippingDetail>()
                .Property(sd => sd.ShippingId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ShippingDetail>()
                .HasOne(std => std.SalesTransactionDetail)
                .WithMany(sd => sd.ShippingDetails)
                .HasForeignKey(std => std.TransactionDetailId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ShippingDetail>()
                .HasOne(st => st.StockTransfer)
                .WithMany(sd => sd.ShippingDetails)
                .HasForeignKey(st => st.TransferId)
                .OnDelete(DeleteBehavior.Restrict);
            /////////////////////////////////////////////////
            ////////////////////////////////////////////////
            modelBuilder.Entity<ExpenseCategory>()
                .HasKey(ec => ec.ExpenseCatergoryId);
            modelBuilder.Entity<ExpenseCategory>()
                .Property(ec => ec.ExpenseCatergoryId)
                .ValueGeneratedOnAdd();
            /////////////////////////////////////////////
            //////////////////////////////////////////////
            modelBuilder.Entity<ExpenseTracking>()
                .HasKey(et => et.ExpenseId);
            modelBuilder.Entity<ExpenseTracking>()
                .Property(et => et.ExpenseId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ExpenseTracking>()
                .HasOne(ec => ec.ExpenseCategory)
                .WithMany(et => et.ExpenseTrackings)
                .HasForeignKey(ec => ec.ExpenseCategoryId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ExpenseTracking>()
               .HasOne(ppr=>ppr.ProductPurchaseRecord)
               .WithMany(et => et.ExpenseTrackings)
               .HasForeignKey(ec => ec.ExpenseCategoryId)
               .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
