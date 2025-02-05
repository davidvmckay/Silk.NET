// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagShutdownType")]
    public enum ShutdownType : int
    {
        [NativeName("Name", "IdleShutdown")]
        IdleShutdown = 0x0,
        [NativeName("Name", "ForcedShutdown")]
        ForcedShutdown = 0x1,
    }
}
