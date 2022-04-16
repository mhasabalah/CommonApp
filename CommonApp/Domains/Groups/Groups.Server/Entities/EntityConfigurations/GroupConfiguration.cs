namespace Groups.Server;
public class GroupConfiguration : BaseSettingsEntityConfiguration<Group>
{
    public override void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.ToTable("Groups");
    }
}
