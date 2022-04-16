namespace Teams.Server;
public class TeamConfiguration : BaseSettingsEntityConfiguration<Team>
{
    public override void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.ToTable("Teams");

        builder.HasMany(e => e.Employees).WithOne().HasForeignKey(e => e.Id);

    }
}
