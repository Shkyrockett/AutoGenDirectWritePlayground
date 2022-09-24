// <copyright file="Direct2d.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Numerics;
using System.Runtime.CompilerServices;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;

namespace Windows.Win32
{
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
        public static unsafe ID2D1Factory? CreateFactory(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <param name="debugLevel">The debug level.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Factory1? CreateFactory1(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory1).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory1,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <param name="debugLevel">The debug level.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Factory2? CreateFactory2(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory2).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory2,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <param name="debugLevel">The debug level.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Factory3? CreateFactory3(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory3).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory3,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <param name="debugLevel">The debug level.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Factory4? CreateFactory4(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory4).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory4,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <param name="debugLevel">The debug level.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Factory5? CreateFactory5(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory5).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory5,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <param name="debugLevel">The debug level.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Factory6? CreateFactory6(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory6).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory6,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <param name="debugLevel">The debug level.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Factory7? CreateFactory7(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE) => PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory7).GUID, new D2D1_FACTORY_OPTIONS(debugLevel), out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as ID2D1Factory7,
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
            PInvoke.D2D1MakeRotateMatrix(angle, center.ToD2D_POINT_2F(), out var matrix);
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
            var center1 = center.ToD2D_POINT_2F();
            PInvoke.D2D1MakeSkewMatrix(angleX, angleY, center1, out var matrix);
            return matrix.ToMatrix3x2();
        }
    }
}
