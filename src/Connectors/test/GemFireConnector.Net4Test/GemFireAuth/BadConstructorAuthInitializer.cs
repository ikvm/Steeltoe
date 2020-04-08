﻿// Copyright 2017 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Apache.Geode.DotNetCore;
using System.Collections.Generic;

namespace Steeltoe.CloudFoundry.Connector.Test
{
    public class BadConstructorAuthInitializer : IAuthInitialize
    {
        public void Close()
        {
            throw new System.NotImplementedException();
        }

        //public Properties<string, object> GetCredentials(Properties<string, string> props, string server)
        //{
        //    throw new System.NotImplementedException();
        //}

        public Dictionary<string, string> GetCredentials()
        {
            throw new System.NotImplementedException();
        }
    }
}