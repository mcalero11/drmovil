using drmovil.api.Models;
using Microsoft.EntityFrameworkCore;

namespace drmovil.api.Contexts
{
    public class PostgresContext : DbContext
    {
        #region DbSet
        public DbSet<Device> Devices { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskLog> TaskLogs { get; set; }
        public DbSet<TaskPhotos> TaskPhotos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }

        #endregion

        #region Constructors
        public PostgresContext()
        {

        }
        /// <summary>
        /// Constructor que usa el service providers para configurar el contexto
        /// </summary>
        /// <param name="options"></param>
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
        {

        }
        #endregion

        #region Overrides
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Category>(c => {
                c.Property(c => c.Name).IsRequired().HasMaxLength(100);
            });
            modelBuilder.Entity<Client>(c => {
                c.Property(c => c.FirstName).IsRequired().HasMaxLength(200);
                c.Property(c => c.LastName).HasMaxLength(200);
                c.Property(c => c.Email).HasMaxLength(255);
                c.Property(c => c.PhoneNumber).HasMaxLength(15);
                c.Property(c => c.BirthDay).HasColumnType("date");
            });
            modelBuilder.Entity<CustomPermission>(cp => {
                cp.HasKey(x => new { x.PermissionId, x.UserId });
                cp.HasOne(cp => cp.Permission).WithMany(p => p.CustomPermissions).HasForeignKey(cp => cp.PermissionId);
                cp.HasOne(cp => cp.User).WithMany(p => p.CustomPermissions).HasForeignKey(cp => cp.UserId);
            });
            modelBuilder.Entity<DailyClose>(u => {
                u.Property(u => u.Start).IsRequired();
            });
            modelBuilder.Entity<Device>(d => {
                d.HasKey(x => x.Id);
                d.Property(d => d.DeviceId).IsRequired().HasMaxLength(100);
                d.Property(d => d.DeviceModel).IsRequired().HasMaxLength(100);
                d.Property(d => d.SerialNumber).IsRequired().HasMaxLength(100);
                d.HasIndex(d => d.DeviceId).IsUnique();
            });
            modelBuilder.Entity<Group>(g => {
                g.Property(g => g.Name).IsRequired().HasMaxLength(100);
            });
            modelBuilder.Entity<Menu>(m => {
                m.Property(m => m.Name).IsRequired().HasMaxLength(100);
            });
            modelBuilder.Entity<Order>(o => {
                o.Property(o => o.OpenAt).IsRequired();
                o.Property(o => o.UpdateAt).IsRequired();

                o.HasOne(o => o.Client).WithMany(c => c.Orders).IsRequired(false);

                o.HasIndex(o => new { o.OrderNumber, o.DailyCloseId, o.StoreId }).IsUnique();
            });
            modelBuilder.Entity<OrderDetail>(od => {
                od.Property(od => od.ProductName).IsRequired().HasMaxLength(100);
                od.Property(od => od.Quantity).IsRequired().HasColumnType("decimal(3,2)");
                od.Property(od => od.UnitPrice).IsRequired().HasColumnType("decimal(5,2)");
                od.Property(od => od.DiscountAmount).IsRequired().HasColumnType("decimal(5,2)");
                od.Property(od => od.DiscountValue).IsRequired().HasColumnType("decimal(5,2)");
            });
            modelBuilder.Entity<OrderPayment>(op => {
                op.Property(x => x.AmountTendered).IsRequired().HasColumnType("decimal(6,2)");
                op.Property(x => x.AmountPaid).IsRequired().HasColumnType("decimal(6,2)");
            });
            modelBuilder.Entity<OrdersTable>(ot => {
                ot.HasKey(x => new { x.OrderId, x.TableId });
                ot.HasOne(ot => ot.Order).WithMany(o => o.OrdersTables).HasForeignKey(ot => ot.OrderId);
                ot.HasOne(ot => ot.Table).WithMany(t => t.OrdersTables).HasForeignKey(ot => ot.TableId);
            });
            modelBuilder.Entity<Partner>(p => {
                p.Property(x => x.Username).IsRequired().HasMaxLength(100);
                p.Property(p => p.Password).IsRequired().HasMaxLength(255);
                p.Property(p => p.FirstName).IsRequired().HasMaxLength(200);
                p.Property(p => p.Password).HasMaxLength(200);

                p.HasIndex(p => p.Username).IsUnique();
            });
            modelBuilder.Entity<Permission>(p => {
                p.Property(x => x.Name).IsRequired().HasMaxLength(100);
                p.Property(x => x.Description).IsRequired();
            });
            modelBuilder.Entity<PermissionsProfiles>(pp => {
                pp.HasKey(x => new { x.PermissionId, x.ProfileId });
                pp.HasOne(ot => ot.Permission).WithMany(o => o.PermissionsProfiles).HasForeignKey(ot => ot.PermissionId);
                pp.HasOne(ot => ot.Profile).WithMany(t => t.PermissionsProfiles).HasForeignKey(ot => ot.ProfileId);
            });
            modelBuilder.Entity<Printer>(p => {
                p.Property(p => p.Name).IsRequired().HasMaxLength(100);
                p.Property(p => p.Ip).HasMaxLength(40);
                p.Property(p => p.Port).HasMaxLength(5);
            });
            modelBuilder.Entity<Profile>(p => {
                p.Property(p => p.Name).IsRequired().HasMaxLength(100);
                p.Property(p => p.Name).IsRequired();
            });
            modelBuilder.Entity<Store>(s => {
                s.Property(s => s.Serial).IsRequired().HasMaxLength(255);
                s.Property(s => s.Name).IsRequired().HasMaxLength(255);
                s.Property(s => s.TimeZone).IsRequired().HasMaxLength(255);

                s.HasIndex(s => s.Serial).IsUnique();
            });
            modelBuilder.Entity<Suscription>(s => {
                s.Property(x => x.Name).IsRequired().HasMaxLength(255);
                s.Property(x => x.Description).IsRequired();
            });
            modelBuilder.Entity<Table>(t => {
                t.Property(x => x.Name).IsRequired().HasMaxLength(200);
            });
            modelBuilder.Entity<TableGroup>(tg => {
                tg.Property(tg => tg.Name).IsRequired().HasMaxLength(200);
                tg.Property(tg => tg.Icon).IsRequired();
                tg.Property(tg => tg.Color).IsRequired().HasMaxLength(10);
            });
            modelBuilder.Entity<User>(u => {
                u.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
                u.Property(x => x.LastName).IsRequired().HasMaxLength(200);
                u.Property(x => x.Pin).IsRequired().HasMaxLength(8);

                u.HasIndex(u => new { u.Pin, u.StoreId }).IsUnique();
            });
            

    }
    */
        #endregion

    }
}
