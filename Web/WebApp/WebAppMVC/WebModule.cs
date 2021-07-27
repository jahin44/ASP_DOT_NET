using Autofac;
using Autofac.Core.Registration;
using WebAppMVC.Areas.Admin.Models;
using WebAppMVC.Services;

namespace WebAppMVC
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SimpleDatabaseService>().As<IDatabaseService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseListModel>().AsSelf();

            base.Load(builder);
        }
    }
}