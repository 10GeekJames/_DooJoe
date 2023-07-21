// ag=yes
namespace DojoSurveysCore.Infrastructure.Data.Config;
public partial class DojoSurveyQuestionAnswerConfiguration : IEntityTypeConfiguration<DojoSurveyQuestionAnswer>
{ 
    public void Configure(EntityTypeBuilder<DojoSurveyQuestionAnswer> builder)
    {
        /* builder.Property(p => p.Name)
            .HasMaxLength(100)
            .IsRequired(); */
        
    }
} 
        