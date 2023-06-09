﻿using Autofac;
using SampleProject.Application.Customers.DomainServices;
using SampleProject.Application.Mahasiswa.DomainServices;
using SampleProject.Domain.Customers;
using SampleProject.Domain.ForeignExchange;
using SampleProject.Domain.Mahasiswa;
using SampleProject.Infrastructure.Domain.ForeignExchanges;

namespace SampleProject.Infrastructure.Domain
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerUniquenessChecker>()
                .As<ICustomerUniquenessChecker>()
                .InstancePerLifetimeScope();

            builder.RegisterType<ForeignExchange>()
                .As<IForeignExchange>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MahasiswaUniquenessChecker>()
                .As<IMahasiswaUniquenessChecker>()
                .InstancePerLifetimeScope();
        }
    }
}