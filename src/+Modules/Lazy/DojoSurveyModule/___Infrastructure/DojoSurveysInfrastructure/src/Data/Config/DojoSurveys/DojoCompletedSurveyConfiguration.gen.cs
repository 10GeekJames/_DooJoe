// ag=yes
namespace DojoSurveysCore.Infrastructure.Data.Config;
public partial class DojoCompletedSurveyConfiguration : IEntityTypeConfiguration<DojoCompletedSurvey>
{ 
    public void Configure(EntityTypeBuilder<DojoCompletedSurvey> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
        
    }
} 
        