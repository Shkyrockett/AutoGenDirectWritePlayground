// <copyright file="Direct2d.cs" company="Shkyrockett" >
// Copyright © 2020 - 2023 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Numerics;
using System.Runtime.CompilerServices;
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
    public static unsafe ID2D1FactoryType? CreateFactory<ID2D1FactoryType>(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE)
        where ID2D1FactoryType : ID2D1Factory
        => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1FactoryType).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => (ID2D1FactoryType)factory,
            _ => throw new Exception("Unspecified Error")
        };

    /// <summary>
    /// Makes a rotation matrix.
    /// </summary>
    /// <param name="angle">The angle.</param>
    /// <param name="center">The center.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Matrix3x2 MakeRotateMatrix(float angle, PointF center)
    {
        PInvoke.D2D1MakeRotateMatrix(angle, center, out var matrix);
        return matrix.ToMatrix3x2();
    }

    /// <summary>
    /// Makes the skew matrix.
    /// </summary>
    /// <param name="angleX">The angle x.</param>
    /// <param name="angleY">The angle y.</param>
    /// <param name="center">The center.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Matrix3x2 MakeSkewMatrix(float angleX, float angleY, PointF center)
    {
        var center1 = center;
        PInvoke.D2D1MakeSkewMatrix(angleX, angleY, center1, out var matrix);
        return matrix.ToMatrix3x2();
    }
}
