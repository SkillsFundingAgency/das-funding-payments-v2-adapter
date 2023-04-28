﻿using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.DependencyInjection;

namespace SFA.DAS.Funding.PaymentsV2Adapter.Command
{
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCommandServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }

        private static IServiceCollection AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}
