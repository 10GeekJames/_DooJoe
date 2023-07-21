using System.Reflection;
using Module = Autofac.Module;

namespace DojoSurveysCore;
public class DojoSurveysCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {

        /* foreach (var dojoSurveysTestData in Assembly
                    .GetExecutingAssembly()
                    .GetTypes()
                    .Where(x => x.IsAssignableTo(typeof(IDojoSurveysTestData)) && x.IsClass)
                    .OrderBy(rs => rs.Name))
        {
            builder.RegisterType(dojoSurveysTestData);
        } */        
    }
}
