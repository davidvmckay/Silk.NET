// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagPENDINGTYPE")]
    public enum PendingType : int
    {
        [Obsolete("Deprecated in favour of \"Toplevel\"")]
        [NativeName("Name", "PENDINGTYPE_TOPLEVEL")]
        PendingtypeToplevel = 0x1,
        [Obsolete("Deprecated in favour of \"Nested\"")]
        [NativeName("Name", "PENDINGTYPE_NESTED")]
        PendingtypeNested = 0x2,
        [NativeName("Name", "PENDINGTYPE_TOPLEVEL")]
        Toplevel = 0x1,
        [NativeName("Name", "PENDINGTYPE_NESTED")]
        Nested = 0x2,
    }
}
