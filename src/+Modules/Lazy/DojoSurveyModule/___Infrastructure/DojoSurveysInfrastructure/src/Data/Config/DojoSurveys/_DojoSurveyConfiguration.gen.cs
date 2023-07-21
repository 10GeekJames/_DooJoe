// ag=yes
namespace DojoSurveysCore.Infrastructure.Data.Config;
public partial class DojoSurveyConfiguration : IEntityTypeConfiguration<DojoSurvey>
{ 
    public void Configure(EntityTypeBuilder<DojoSurvey> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
        
    }
} 
        