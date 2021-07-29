using Autofac;
using WebAppMVC.Common.Utilities;

namespace WebAppMVC.Common
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
             builder.RegisterType<DateTimeUtility>().As<IDateTimeUtility>()
                 .InstancePerLifetimeScope();

             base.Load(builder);
        }
    }
}
