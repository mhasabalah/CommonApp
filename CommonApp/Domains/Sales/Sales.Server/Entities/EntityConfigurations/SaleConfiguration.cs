namespace Sales.Server;
public class SaleConfiguration : BaseSettingsEntityConfiguration<Sale>
{
    public override void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

    }
}
