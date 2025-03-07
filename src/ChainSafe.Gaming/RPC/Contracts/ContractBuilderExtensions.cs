﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChainSafe.Gaming.Web3.Build;
using Microsoft.Extensions.DependencyInjection;

namespace ChainSafe.Gaming.Evm.Contracts
{
    public static class ContractBuilderExtensions
    {
        public static IWeb3ServiceCollection ConfigureRegisteredContracts(this IWeb3ServiceCollection services, Action<ContractBuilderConfig> configure)
        {
            ContractBuilderConfig config =
                services.FirstOrDefault(s => s.ServiceType == typeof(ContractBuilderConfig))
                    ?.ImplementationInstance as ContractBuilderConfig;

            if (config == null)
            {
                config = new();
                services.AddSingleton(config);
            }

            configure(config);

            return services;
        }
    }
}
