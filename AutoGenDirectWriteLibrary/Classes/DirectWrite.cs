// <copyright file="DirectWrite.cs" company="Shkyrockett" >
// Copyright © 2020 - 2023 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Runtime.CompilerServices;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.DirectWrite;

namespace Windows.Win32;

/// <summary>
/// Class for calling DirectWrite API.
/// </summary>
public static class DirectWrite
{
    /// <summary>
    /// Creates the factory.
    /// </summary>
    /// <param name="factoryType">Type of the factory.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static IDWriteFactoryType? CreateFactory<IDWriteFactoryType>(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED)
        where IDWriteFactoryType : IDWriteFactory
        => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactoryType).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => (IDWriteFactoryType)factory,
            _ => throw new Exception("Unspecified Error")
        };
}
