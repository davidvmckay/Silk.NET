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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("f29f6bc0-5021-11ce-aa15-00006901293f")]
    [NativeName("Name", "IROTData")]
    public unsafe partial struct IROTData : IComVtbl<IROTData>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f29f6bc0-5021-11ce-aa15-00006901293f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IROTData val)
            => Unsafe.As<IROTData, Silk.NET.Core.Native.IUnknown>(ref val);

        public IROTData
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IROTData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComparisonData(byte* pbData, uint cbMax, uint* pcbData)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbData, cbMax, pcbData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComparisonData(byte* pbData, uint cbMax, ref uint pcbData)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbDataPtr = &pcbData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbData, cbMax, pcbDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComparisonData(ref byte pbData, uint cbMax, uint* pcbData)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbDataPtr = &pbData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetComparisonData(ref byte pbData, uint cbMax, ref uint pcbData)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbDataPtr = &pbData)
            {
                fixed (uint* pcbDataPtr = &pcbData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComparisonData([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbData, uint cbMax, uint* pcbData)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbDataPtr = (byte*) SilkMarshal.StringToPtr(pbData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbData);
            SilkMarshal.Free((nint)pbDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetComparisonData([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbData, uint cbMax, ref uint pcbData)
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbDataPtr = (byte*) SilkMarshal.StringToPtr(pbData, NativeStringEncoding.UTF8);
            fixed (uint* pcbDataPtr = &pcbData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IROTData*, byte*, uint, uint*, int>)@this->LpVtbl[3])(@this, pbDataPtr, cbMax, pcbDataPtr);
            }
            SilkMarshal.Free((nint)pbDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IROTData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
