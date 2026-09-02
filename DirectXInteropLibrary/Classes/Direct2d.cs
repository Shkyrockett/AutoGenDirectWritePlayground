// <copyright file="Direct2d.cs" company="Shkyrockett" >
// Copyright © 2020 - 2025 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;

namespace Windows.Win32;

/// <summary>
/// Class for calling Direct2D API.
/// </summary>
public static class Direct2d
{
    /// <summary>
    /// Creates the factory.
    /// </summary>
    /// <param name="factoryType">Type of the factory.</param>
    /// <param name="debugLevel">The debug level.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static ID2D1FactoryType? CreateFactory<ID2D1FactoryType>(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE)
        where ID2D1FactoryType : class, ID2D1Factory => PInvoke.D2D1CreateFactory(factoryType, new D2D1_FACTORY_OPTIONS(debugLevel), out ID2D1FactoryType factory).Succeeded
        ? factory : throw new Win32Exception(Marshal.GetLastWin32Error(), "CreateFactory failed to initialize.");
}
