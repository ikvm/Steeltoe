﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.Configuration;
using Owin;
using Steeltoe.Common.HealthChecks;
using Steeltoe.Management.Endpoint.Health;
using Steeltoe.Management.Endpoint.Health.Test;
using Steeltoe.Management.EndpointOwin.Test;
using System.Collections.Generic;

namespace Steeltoe.Management.EndpointOwin.Health.Test
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ConfigurationBuilder();
            builder.AddInMemoryCollection(OwinTestHelpers.Appsettings);
            var config = builder.Build();

            app.UseHealthActuator(config);
            app.UseHealthActuator(new HealthEndpointOptions { Id = "down" }, new DefaultHealthAggregator(), new List<IHealthContributor> { new DownContributor() });
            app.UseHealthActuator(new HealthEndpointOptions { Id = "out" }, new DefaultHealthAggregator(), new List<IHealthContributor> { new OutOfSserviceContributor() });
            app.UseHealthActuator(new HealthEndpointOptions { Id = "unknown" }, new DefaultHealthAggregator(), new List<IHealthContributor> { new UnknownContributor() });
        }
    }
}