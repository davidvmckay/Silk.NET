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
    [NativeName("Name", "VkVideoEncodeH264SessionParametersCreateInfoKHR")]
    public unsafe partial struct VideoEncodeH264SessionParametersCreateInfoKHR : IExtendsChain<VideoSessionParametersCreateInfoKHR>
    {
        public VideoEncodeH264SessionParametersCreateInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264SessionParametersCreateInfoKhr,
            void* pNext = null,
            uint? maxStdSpscount = null,
            uint? maxStdPpscount = null,
            VideoEncodeH264SessionParametersAddInfoKHR* pParametersAddInfo = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (maxStdSpscount is not null)
            {
                MaxStdSpscount = maxStdSpscount.Value;
            }

            if (maxStdPpscount is not null)
            {
                MaxStdPpscount = maxStdPpscount.Value;
            }

            if (pParametersAddInfo is not null)
            {
                PParametersAddInfo = pParametersAddInfo;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStdSPSCount")]
        public uint MaxStdSpscount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxStdPPSCount")]
        public uint MaxStdPpscount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264SessionParametersAddInfoKHR*")]
        [NativeName("Type.Name", "VkVideoEncodeH264SessionParametersAddInfoKHR")]
        [NativeName("Name", "pParametersAddInfo")]
        public VideoEncodeH264SessionParametersAddInfoKHR* PParametersAddInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264SessionParametersCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
