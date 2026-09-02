// <copyright file="DirectWrite.cs" company="Shkyrockett" >
// Copyright © 2020 - 2025 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
        where IDWriteFactoryType : class, IDWriteFactory => PInvoke.DWriteCreateFactory(factoryType, out IDWriteFactoryType factory).Succeeded
        ? factory : throw new Win32Exception(Marshal.GetLastWin32Error(), "CreateFactory faild to initialize.");
}
