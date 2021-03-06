﻿// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.
namespace Microsoft.Hadoop.Client.ClientLayer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Provides a factor for creating Hadoop Clients.
    /// </summary>
    /// <typeparam name="T">
    /// The type of connection credential supported by this factor.
    /// </typeparam>
    internal interface IHadoopClientFactory<in T> where T : IJobSubmissionClientCredential
    {
        /// <summary>
        /// Creates a new Hadoop client capable of connecting to Hadoop using the supplied credential.
        /// </summary>
        /// <param name="credential">
        /// The credential to use.
        /// </param>
        /// <returns>
        /// A new HadoopClient that can be used to communicate with Hadoop.
        /// </returns>
        IJobSubmissionClient Create(T credential);
    }
}
