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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class EnumFORMATETCVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumFORMATETC> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumFORMATETC> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumFORMATETC> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumFORMATETC> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IEnumFORMATETC> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IEnumFORMATETC> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt, FORMATETC* rgelt, uint* pceltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgelt, pceltFetched);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt, FORMATETC* rgelt, ref uint pceltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* pceltFetchedPtr = &pceltFetched)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgelt, pceltFetchedPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt, ref FORMATETC rgelt, uint* pceltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* rgeltPtr = &rgelt)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltPtr, pceltFetched);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Next(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt, ref FORMATETC rgelt, ref uint pceltFetched)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FORMATETC* rgeltPtr = &rgelt)
        {
            fixed (uint* pceltFetchedPtr = &pceltFetched)
            {
                ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, FORMATETC*, uint*, int>)@this->LpVtbl[3])(@this, celt, rgeltPtr, pceltFetchedPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Skip(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, uint, int>)@this->LpVtbl[4])(@this, celt);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Reset(this ComPtr<IEnumFORMATETC> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, int>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumFORMATETC> thisVtbl, IEnumFORMATETC** ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, IEnumFORMATETC**, int>)@this->LpVtbl[6])(@this, ppenum);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<IEnumFORMATETC> thisVtbl, ref IEnumFORMATETC* ppenum)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IEnumFORMATETC** ppenumPtr = &ppenum)
        {
            ret = ((delegate* unmanaged[Cdecl]<IEnumFORMATETC*, IEnumFORMATETC**, int>)@this->LpVtbl[6])(@this, ppenumPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IEnumFORMATETC> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumFORMATETC> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IEnumFORMATETC> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt, FORMATETC* rgelt, Span<uint> pceltFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, rgelt, ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Next(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt, Span<FORMATETC> rgelt, uint* pceltFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgelt.GetPinnableReference(), pceltFetched);
    }

    /// <summary>To be documented.</summary>
    public static int Next(this ComPtr<IEnumFORMATETC> thisVtbl, uint celt, Span<FORMATETC> rgelt, Span<uint> pceltFetched)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Next(celt, ref rgelt.GetPinnableReference(), ref pceltFetched.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int Clone<TI0>(this ComPtr<IEnumFORMATETC> thisVtbl, ref ComPtr<TI0> ppenum) where TI0 : unmanaged, IComVtbl<IEnumFORMATETC>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Clone((IEnumFORMATETC**) ppenum.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IEnumFORMATETC> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
