using Autofac;
using Autofac.Core.Registration;
using WebAppMVC.DependencyAuto;

namespace WebAppMVC
{
    internal class WebModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<SimpleDatabase>().As<IDatabaseUse>()
                          .InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}