// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.Framework.DependencyInjection
{
    public class ServiceManifest : IServiceManifest
    {
        public ServiceManifest([NotNull] IEnumerable<Type> services)
        {
            Services = services;
        }

        public IEnumerable<Type> Services { get; private set; }
    }
}