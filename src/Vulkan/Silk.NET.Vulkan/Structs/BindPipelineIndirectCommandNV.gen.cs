// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkBindPipelineIndirectCommandNV")]
    public unsafe partial struct BindPipelineIndirectCommandNV
    {
        public BindPipelineIndirectCommandNV
        (
            ulong? pipelineAddress = null
        ) : this()
        {
            if (pipelineAddress is not null)
            {
                PipelineAddress = pipelineAddress.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "pipelineAddress")]
        public ulong PipelineAddress;
    }
}
