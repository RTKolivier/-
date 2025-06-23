using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace курчас.Models;

public partial class User3Context : DbContext
{
    public User3Context()
    {
    }

    public User3Context(DbContextOptions<User3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AcrylicSize> AcrylicSizes { get; set; }

    public virtual DbSet<AddHardware> AddHardwares { get; set; }

    public virtual DbSet<AddHardwareSize> AddHardwareSizes { get; set; }

    public virtual DbSet<Cao> Caos { get; set; }

    public virtual DbSet<Caononame> Caononames { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<EightEight> EightEights { get; set; }

    public virtual DbSet<EightFour> EightFours { get; set; }

    public virtual DbSet<EightOnehalf> EightOnehalves { get; set; }

    public virtual DbSet<EightThree> EightThrees { get; set; }

    public virtual DbSet<EightTwo> EightTwos { get; set; }

    public virtual DbSet<FiveEight> FiveEights { get; set; }

    public virtual DbSet<FiveFour> FiveFours { get; set; }

    public virtual DbSet<FiveOnehalf> FiveOnehalves { get; set; }

    public virtual DbSet<FiveThree> FiveThrees { get; set; }

    public virtual DbSet<FiveTwo> FiveTwos { get; set; }

    public virtual DbSet<Hardware> Hardwares { get; set; }

    public virtual DbSet<HardwareColor> HardwareColors { get; set; }

    public virtual DbSet<HardwarePrice> HardwarePrices { get; set; }

    public virtual DbSet<NonameClient> NonameClients { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<SixEight> SixEights { get; set; }

    public virtual DbSet<SixFour> SixFours { get; set; }

    public virtual DbSet<SixOnehalf> SixOnehalves { get; set; }

    public virtual DbSet<SixThree> SixThrees { get; set; }

    public virtual DbSet<SixTwo> SixTwos { get; set; }

    public virtual DbSet<TenEight> TenEights { get; set; }

    public virtual DbSet<TenFour> TenFours { get; set; }

    public virtual DbSet<TenOnehalf> TenOnehalves { get; set; }

    public virtual DbSet<TenThree> TenThrees { get; set; }

    public virtual DbSet<TenTwo> TenTwos { get; set; }

    public virtual DbSet<ThreeEight> ThreeEights { get; set; }

    public virtual DbSet<ThreeFour> ThreeFours { get; set; }

    public virtual DbSet<ThreeOnehalf> ThreeOnehalves { get; set; }

    public virtual DbSet<ThreeThree> ThreeThrees { get; set; }

    public virtual DbSet<ThreeTwo> ThreeTwos { get; set; }

    public virtual DbSet<TypeOfAcrylic> TypeOfAcrylics { get; set; }

    public virtual DbSet<TypeOfHardware> TypeOfHardwares { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=45.67.56.214;Port=5421;Database=user3;Username=user3;Password=VOTfZ8PQ");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcrylicSize>(entity =>
        {
            entity.HasKey(e => e.AcrylicsizeId).HasName("acrylic_size_pkey");

            entity.ToTable("acrylic_size", "KYRSACH");

            entity.Property(e => e.AcrylicsizeId)
                .ValueGeneratedNever()
                .HasColumnName("acrylicsize_id");
            entity.Property(e => e.AcrylicsizeSize).HasColumnName("acrylicsize_size");
        });

        modelBuilder.Entity<AddHardware>(entity =>
        {
            entity.HasKey(e => e.AddhardwareId).HasName("add_hardware_pkey");

            entity.ToTable("add_hardware", "KYRSACH");

            entity.Property(e => e.AddhardwareId)
                .ValueGeneratedNever()
                .HasColumnName("addhardware_id");
            entity.Property(e => e.AddhardwareColorid).HasColumnName("addhardware_colorid");
            entity.Property(e => e.AddhardwarePriceid).HasColumnName("addhardware_priceid");
            entity.Property(e => e.AddhardwareSizeid).HasColumnName("addhardware_sizeid");

            entity.HasOne(d => d.AddhardwareColor).WithMany(p => p.AddHardwares)
                .HasForeignKey(d => d.AddhardwareColorid)
                .HasConstraintName("add_hardware_addhardware_colorid_fkey");

            entity.HasOne(d => d.AddhardwarePrice).WithMany(p => p.AddHardwares)
                .HasForeignKey(d => d.AddhardwarePriceid)
                .HasConstraintName("add_hardware_addhardware_priceid_fkey");

            entity.HasOne(d => d.AddhardwareSize).WithMany(p => p.AddHardwares)
                .HasForeignKey(d => d.AddhardwareSizeid)
                .HasConstraintName("add_hardware_addhardware_sizeid_fkey");
        });

        modelBuilder.Entity<AddHardwareSize>(entity =>
        {
            entity.HasKey(e => e.AddhardwaresizeId).HasName("add_hardware_size_pkey");

            entity.ToTable("add_hardware_size", "KYRSACH");

            entity.Property(e => e.AddhardwaresizeId)
                .ValueGeneratedNever()
                .HasColumnName("addhardwaresize_id");
            entity.Property(e => e.AddhardwaresizeSize).HasColumnName("addhardwaresize_size");
        });

        modelBuilder.Entity<Cao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cao", "KYRSACH");

            entity.Property(e => e.CaoClientsid).HasColumnName("cao_clientsid");
            entity.Property(e => e.CaoOrdersid).HasColumnName("cao_ordersid");

            entity.HasOne(d => d.CaoClients).WithMany()
                .HasForeignKey(d => d.CaoClientsid)
                .HasConstraintName("cao_cao_clientsid_fkey");

            entity.HasOne(d => d.CaoOrders).WithMany()
                .HasForeignKey(d => d.CaoOrdersid)
                .HasConstraintName("cao_cao_ordersid_fkey");
        });

        modelBuilder.Entity<Caononame>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("caononame", "KYRSACH");

            entity.Property(e => e.CaononameNonameid).HasColumnName("caononame_nonameid");
            entity.Property(e => e.CaononameOrderid).HasColumnName("caononame_orderid");

            entity.HasOne(d => d.CaononameNoname).WithMany()
                .HasForeignKey(d => d.CaononameNonameid)
                .HasConstraintName("caononame_caononame_nonameid_fkey");

            entity.HasOne(d => d.CaononameOrder).WithMany()
                .HasForeignKey(d => d.CaononameOrderid)
                .HasConstraintName("caononame_caononame_orderid_fkey");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientsId).HasName("clients_pkey");

            entity.ToTable("clients", "KYRSACH");

            entity.Property(e => e.ClientsId)
                .ValueGeneratedNever()
                .HasColumnName("clients_id");
            entity.Property(e => e.ClientsAddress).HasColumnName("clients_address");
            entity.Property(e => e.ClientsCity).HasColumnName("clients_city");
            entity.Property(e => e.ClientsFio).HasColumnName("clients_fio");
            entity.Property(e => e.ClientsNick).HasColumnName("clients_nick");
            entity.Property(e => e.ClientsOpp).HasColumnName("clients_opp");
            entity.Property(e => e.ClientsPassword).HasColumnName("clients_password");
            entity.Property(e => e.ClientsPhone).HasColumnName("clients_phone");
            entity.Property(e => e.ClientsUsername).HasColumnName("clients_username");
        });

        modelBuilder.Entity<EightEight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("eight_eight", "KYRSACH");

            entity.Property(e => e.EighteightPrice).HasColumnName("eighteight_price");
            entity.Property(e => e.EighteightQuantity).HasColumnName("eighteight_quantity");
        });

        modelBuilder.Entity<EightFour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("eight_four", "KYRSACH");

            entity.Property(e => e.EightfourPrice).HasColumnName("eightfour_price");
            entity.Property(e => e.EightfourQuantity).HasColumnName("eightfour_quantity");
        });

        modelBuilder.Entity<EightOnehalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("eight_onehalf", "KYRSACH");

            entity.Property(e => e.EightonehalfPrice).HasColumnName("eightonehalf_price");
            entity.Property(e => e.EightonehalfQuantity).HasColumnName("eightonehalf_quantity");
        });

        modelBuilder.Entity<EightThree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("eight_three", "KYRSACH");

            entity.Property(e => e.EightthreePrice).HasColumnName("eightthree_price");
            entity.Property(e => e.EightthreeQuantity).HasColumnName("eightthree_quantity");
        });

        modelBuilder.Entity<EightTwo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("eight_two", "KYRSACH");

            entity.Property(e => e.EighttwoPrice).HasColumnName("eighttwo_price");
            entity.Property(e => e.EighttwoQuantity).HasColumnName("eighttwo_quantity");
        });

        modelBuilder.Entity<FiveEight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("five_eight", "KYRSACH");

            entity.Property(e => e.FiveeightPrice).HasColumnName("fiveeight_price");
            entity.Property(e => e.FiveeightQuantity).HasColumnName("fiveeight_quantity");
        });

        modelBuilder.Entity<FiveFour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("five_four", "KYRSACH");

            entity.Property(e => e.FivefourPrice).HasColumnName("fivefour_price");
            entity.Property(e => e.FivefourQuantity).HasColumnName("fivefour_quantity");
        });

        modelBuilder.Entity<FiveOnehalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("five_onehalf", "KYRSACH");

            entity.Property(e => e.FiveonehalfPrice).HasColumnName("fiveonehalf_price");
            entity.Property(e => e.FiveonehalfQuantity).HasColumnName("fiveonehalf_quantity");
        });

        modelBuilder.Entity<FiveThree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("five_three", "KYRSACH");

            entity.Property(e => e.FivethreePrice).HasColumnName("fivethree_price");
            entity.Property(e => e.FivethreeQuantity).HasColumnName("fivethree_quantity");
        });

        modelBuilder.Entity<FiveTwo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("five_two", "KYRSACH");

            entity.Property(e => e.FivetwoPrice).HasColumnName("fivetwo_price");
            entity.Property(e => e.FivetwoQuantity).HasColumnName("fivetwo_quantity");
        });

        modelBuilder.Entity<Hardware>(entity =>
        {
            entity.HasKey(e => e.HardwareId).HasName("hardware_pkey");

            entity.ToTable("hardware", "KYRSACH");

            entity.Property(e => e.HardwareId)
                .ValueGeneratedNever()
                .HasColumnName("hardware_id");
            entity.Property(e => e.HardwareColorid).HasColumnName("hardware_colorid");
            entity.Property(e => e.HardwarePriceid).HasColumnName("hardware_priceid");
            entity.Property(e => e.HardwareQuantity).HasColumnName("hardware_quantity");
            entity.Property(e => e.HardwareTypeid).HasColumnName("hardware_typeid");

            entity.HasOne(d => d.HardwareColor).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.HardwareColorid)
                .HasConstraintName("hardware_hardware_colorid_fkey");

            entity.HasOne(d => d.HardwarePrice).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.HardwarePriceid)
                .HasConstraintName("hardware_hardware_priceid_fkey");

            entity.HasOne(d => d.HardwareType).WithMany(p => p.Hardwares)
                .HasForeignKey(d => d.HardwareTypeid)
                .HasConstraintName("hardware_hardware_typeid_fkey");
        });

        modelBuilder.Entity<HardwareColor>(entity =>
        {
            entity.HasKey(e => e.HardwarecolorId).HasName("hardware_color_pkey");

            entity.ToTable("hardware_color", "KYRSACH");

            entity.Property(e => e.HardwarecolorId)
                .ValueGeneratedNever()
                .HasColumnName("hardwarecolor_id");
            entity.Property(e => e.HardwarecolorColor).HasColumnName("hardwarecolor_color");
        });

        modelBuilder.Entity<HardwarePrice>(entity =>
        {
            entity.HasKey(e => e.HardwarepriceId).HasName("hardware_price_pkey");

            entity.ToTable("hardware_price", "KYRSACH");

            entity.Property(e => e.HardwarepriceId)
                .ValueGeneratedNever()
                .HasColumnName("hardwareprice_id");
            entity.Property(e => e.HardwarepricePrice).HasColumnName("hardwareprice_price");
        });

        modelBuilder.Entity<NonameClient>(entity =>
        {
            entity.HasKey(e => e.NonameclientsId).HasName("noname_clients_pkey");

            entity.ToTable("noname_clients", "KYRSACH");

            entity.Property(e => e.NonameclientsId)
                .ValueGeneratedNever()
                .HasColumnName("nonameclients_id");
            entity.Property(e => e.NonameclientsNick).HasColumnName("nonameclients_nick");
            entity.Property(e => e.NonameclientsUsername).HasColumnName("nonameclients_username");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrdersId).HasName("orders_pkey");

            entity.ToTable("orders", "KYRSACH");

            entity.Property(e => e.OrdersId)
                .ValueGeneratedNever()
                .HasColumnName("orders_id");
            entity.Property(e => e.AcrylicSize).HasColumnName("acrylic_size");
            entity.Property(e => e.OrdersAddhardware).HasColumnName("orders_addhardware");
            entity.Property(e => e.OrdersDate).HasColumnName("orders_date");
            entity.Property(e => e.OrdersFilesname).HasColumnName("orders_filesname");
            entity.Property(e => e.OrdersHardwareid).HasColumnName("orders_hardwareid");
            entity.Property(e => e.OrdersPrice).HasColumnName("orders_price");
            entity.Property(e => e.OrdersQuantity).HasColumnName("orders_quantity");
            entity.Property(e => e.OrdersQuantityaddhardware).HasColumnName("orders_quantityaddhardware");
            entity.Property(e => e.OrdersQuantityhardware).HasColumnName("orders_quantityhardware");
            entity.Property(e => e.OrdersTypeacrylicid).HasColumnName("orders_typeacrylicid");

            entity.HasOne(d => d.AcrylicSizeNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.AcrylicSize)
                .HasConstraintName("orders_acrylic_size_fk");

            entity.HasOne(d => d.OrdersAddhardwareNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrdersAddhardware)
                .HasConstraintName("orders_orders_addhardware_fkey");

            entity.HasOne(d => d.OrdersHardware).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrdersHardwareid)
                .HasConstraintName("orders_orders_hardwareid_fkey");

            entity.HasOne(d => d.OrdersTypeacrylic).WithMany(p => p.Orders)
                .HasForeignKey(d => d.OrdersTypeacrylicid)
                .HasConstraintName("orders_orders_typeacrylicid_fkey");
        });

        modelBuilder.Entity<SixEight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("six_eight", "KYRSACH");

            entity.Property(e => e.SixeightPrice).HasColumnName("sixeight_price");
            entity.Property(e => e.SixeightQuantity).HasColumnName("sixeight_quantity");
        });

        modelBuilder.Entity<SixFour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("six_four", "KYRSACH");

            entity.Property(e => e.SixfourPrice).HasColumnName("sixfour_price");
            entity.Property(e => e.SixfourQuantity).HasColumnName("sixfour_quantity");
        });

        modelBuilder.Entity<SixOnehalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("six_onehalf", "KYRSACH");

            entity.Property(e => e.SixonehalfPrice).HasColumnName("sixonehalf_price");
            entity.Property(e => e.SixonehalfQuantity).HasColumnName("sixonehalf_quantity");
        });

        modelBuilder.Entity<SixThree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("six_three", "KYRSACH");

            entity.Property(e => e.SixthreePrice).HasColumnName("sixthree_price");
            entity.Property(e => e.SixthreeQuantity).HasColumnName("sixthree_quantity");
        });

        modelBuilder.Entity<SixTwo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("six_two", "KYRSACH");

            entity.Property(e => e.SixtwoPrice).HasColumnName("sixtwo_price");
            entity.Property(e => e.SixtwoQuantity).HasColumnName("sixtwo_quantity");
        });

        modelBuilder.Entity<TenEight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ten_eight", "KYRSACH");

            entity.Property(e => e.TeneightPrice).HasColumnName("teneight_price");
            entity.Property(e => e.TeneightQuantity).HasColumnName("teneight_quantity");
        });

        modelBuilder.Entity<TenFour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ten_four", "KYRSACH");

            entity.Property(e => e.TenfourPrice).HasColumnName("tenfour_price");
            entity.Property(e => e.TenfourQuantity).HasColumnName("tenfour_quantity");
        });

        modelBuilder.Entity<TenOnehalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ten_onehalf", "KYRSACH");

            entity.Property(e => e.TenonehalfPrice).HasColumnName("tenonehalf_price");
            entity.Property(e => e.TenonehalfQuantity).HasColumnName("tenonehalf_quantity");
        });

        modelBuilder.Entity<TenThree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ten_three", "KYRSACH");

            entity.Property(e => e.TenthreePrice).HasColumnName("tenthree_price");
            entity.Property(e => e.TenthreeQuantity).HasColumnName("tenthree_quantity");
        });

        modelBuilder.Entity<TenTwo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ten_two", "KYRSACH");

            entity.Property(e => e.TentwoPrice).HasColumnName("tentwo_price");
            entity.Property(e => e.TentwoQuantity).HasColumnName("tentwo_quantity");
        });

        modelBuilder.Entity<ThreeEight>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("three_eight", "KYRSACH");

            entity.Property(e => e.TeneightPrice).HasColumnName("teneight_price");
            entity.Property(e => e.TeneightQuantity).HasColumnName("teneight_quantity");
        });

        modelBuilder.Entity<ThreeFour>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("three_four", "KYRSACH");

            entity.Property(e => e.ThreefourPrice).HasColumnName("threefour_price");
            entity.Property(e => e.ThreefourQuantity).HasColumnName("threefour_quantity");
        });

        modelBuilder.Entity<ThreeOnehalf>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("three_onehalf", "KYRSACH");

            entity.Property(e => e.ThreeonehalfPrice).HasColumnName("threeonehalf_price");
            entity.Property(e => e.ThreeonehalfQuantity).HasColumnName("threeonehalf_quantity");
        });

        modelBuilder.Entity<ThreeThree>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("three_three", "KYRSACH");

            entity.Property(e => e.ThreethreePrice).HasColumnName("threethree_price");
            entity.Property(e => e.ThreethreeQuantity).HasColumnName("threethree_quantity");
        });

        modelBuilder.Entity<ThreeTwo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("three_two", "KYRSACH");

            entity.Property(e => e.ThreetwoPrice).HasColumnName("threetwo_price");
            entity.Property(e => e.ThreetwoQuantity).HasColumnName("threetwo_quantity");
        });

        modelBuilder.Entity<TypeOfAcrylic>(entity =>
        {
            entity.HasKey(e => e.TypeofacrylicId).HasName("type_of_acrylic_pkey");

            entity.ToTable("type_of_acrylic", "KYRSACH");

            entity.Property(e => e.TypeofacrylicId)
                .ValueGeneratedNever()
                .HasColumnName("typeofacrylic_id");
            entity.Property(e => e.TypeofacrylicThickness).HasColumnName("typeofacrylic_thickness");
        });

        modelBuilder.Entity<TypeOfHardware>(entity =>
        {
            entity.HasKey(e => e.TypeofhardwareId).HasName("type_of_hardware_pkey");

            entity.ToTable("type_of_hardware", "KYRSACH");

            entity.Property(e => e.TypeofhardwareId)
                .ValueGeneratedNever()
                .HasColumnName("typeofhardware_id");
            entity.Property(e => e.TypeofhardwareType).HasColumnName("typeofhardware_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
