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
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;

namespace AutoGenDirectWriteLibrary
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
        public unsafe static ID2D1Factory? CreateFactory(D2D1_FACTORY_TYPE factoryType = D2D1_FACTORY_TYPE.D2D1_FACTORY_TYPE_SINGLE_THREADED, D2D1_DEBUG_LEVEL debugLevel = D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE)
        {
            return PInvoke.D2D1CreateFactory(factoryType, typeof(ID2D1Factory).GUID, new D2D1_FACTORY_OPTIONS() { debugLevel = debugLevel }, out var factory) switch
            {
                HRESULT h when h == HRESULT.S_OK => Marshal.GetObjectForIUnknown(new IntPtr(factory)) as ID2D1Factory,
                _ => throw new Exception("Unspecified Error")
            };
        }

        /// <summary>
        /// Inverts the matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns></returns>
        public static bool InvertMatrix(ref Matrix3x2 matrix)
        {
            var m = matrix.ToD2D_MATRIX_3X2_F();
            var t = PInvoke.D2D1InvertMatrix(ref m);
            matrix = m.ToMatrix3x2();
            return t;
        }

        /// <summary>
        /// Determines whether [is matrix invertible] [the specified matrix].
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>
        ///   <see langword="true" /> if [is matrix invertible] [the specified matrix]; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsMatrixInvertible(ref Matrix3x2 matrix)
        {
            var m = matrix.ToD2D_MATRIX_3X2_F();
            return PInvoke.D2D1IsMatrixInvertible(m);
        }

        /// <summary>
        /// Makes a rotation matrix.
        /// </summary>
        /// <param name="angle">The angle.</param>
        /// <param name="center">The center.</param>
        /// <returns></returns>
        public static Matrix3x2 MakeRotateMatrix(float angle, PointF center)
        {
            PInvoke.D2D1MakeRotateMatrix(angle, new D2D_POINT_2F() { x = center.X, y = center.Y }, out var matrix);
            return matrix.ToMatrix3x2();
        }

        /// <summary>
        /// Makes the skew matrix.
        /// </summary>
        /// <param name="angleX">The angle x.</param>
        /// <param name="angleY">The angle y.</param>
        /// <param name="center">The center.</param>
        /// <returns></returns>
        public static Matrix3x2 MakeSkewMatrix(float angleX, float angleY, PointF center)
        {
            var center1 = center.ToD2D_POINT_2F();
            PInvoke.D2D1MakeSkewMatrix(angleX, angleY, center1, out var matrix);
            return matrix.ToMatrix3x2();
        }
    }
}
