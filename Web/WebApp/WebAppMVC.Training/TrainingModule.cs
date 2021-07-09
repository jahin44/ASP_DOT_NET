﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Training.Context;
using WebAppMVC.Training.Services;

namespace WebApp.Training
{
     
    public class TrainingModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        public TrainingModule(string connectionString, string migrationAssemblyName)
        {
             _connectionString = connectionString;
             _migrationAssemblyName = migrationAssemblyName;

        }

        protected override void Load(ContainerBuilder builder)
        {
 
             builder.RegisterType<TrainingContext>().AsSelf()
                  .WithParameter("connectionString",_connectionString)
                  .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                  .InstancePerLifetimeScope();
             builder.RegisterType<CourseService>().As<ICourseService>()
                  .InstancePerLifetimeScope();
             base.Load(builder);
        }
    }
}
