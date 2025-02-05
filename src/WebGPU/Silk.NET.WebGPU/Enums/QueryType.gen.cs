// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUQueryType")]
    public enum QueryType : int
    {
        [NativeName("Name", "WGPUQueryType_Occlusion")]
        Occlusion = 0x0,
        [NativeName("Name", "WGPUQueryType_Timestamp")]
        Timestamp = 0x1,
        [NativeName("Name", "WGPUQueryType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
