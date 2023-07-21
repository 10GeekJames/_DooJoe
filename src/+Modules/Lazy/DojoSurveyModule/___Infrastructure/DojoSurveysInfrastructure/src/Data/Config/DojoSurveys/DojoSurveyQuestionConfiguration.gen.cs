// ag=yes
namespace DojoSurveysCore.Infrastructure.Data.Config;
public partial class DojoSurveyQuestionConfiguration : IEntityTypeConfiguration<DojoSurveyQuestion>
{ 
    public void Configure(EntityTypeBuilder<DojoSurveyQuestion> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
        
    }
} 
        