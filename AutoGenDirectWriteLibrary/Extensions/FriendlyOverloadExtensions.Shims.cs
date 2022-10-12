// <copyright file="FriendlyOverloadExtensions.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;
using Windows.Win32.Graphics.Gdi;

namespace Windows.Win32
{
    /// <summary>
    /// The friendly overload extensions.
    /// </summary>
    public static partial class FriendlyOverloadExtensions
    {
        #region API Shims
        /// <summary>
        /// Inverts a matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool InvertMatrix(this ref Matrix3x2 matrix)
        {
            var m = matrix.ToD2D_MATRIX_3X2_F();
            var t = PInvoke.D2D1InvertMatrix(ref m);
            matrix = m.ToMatrix3x2();
            return t;
        }

        /// <summary>
        /// Inverts a matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool InvertMatrix(this ref D2D_MATRIX_3X2_F matrix)
        {
            var t = PInvoke.D2D1InvertMatrix(ref matrix);
            return t;
        }

        /// <summary>
        /// Determines whether the specified matrix is invertible.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified matrix is invertible; otherwise, <see langword="false" />.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsMatrixInvertible(this ref Matrix3x2 matrix)
        {
            var m = matrix.ToD2D_MATRIX_3X2_F();
            return PInvoke.D2D1IsMatrixInvertible(m);
        }

        /// <summary>
        /// Determines whether the specified matrix is invertible.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified matrix is invertible; otherwise, <see langword="false" />.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsMatrixInvertible(this ref D2D_MATRIX_3X2_F matrix) => PInvoke.D2D1IsMatrixInvertible(matrix);

        /// <summary>
        /// Sets the maximum size of a text layout.
        /// </summary>
        /// <param name="textLayout">The text layout.</param>
        /// <param name="maxSize">The max size.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static void SetMaxSize(this IDWriteTextLayout textLayout, SizeF maxSize)
        {
            textLayout.SetMaxHeight(maxSize.Height);
            textLayout.SetMaxWidth(maxSize.Width);
        }
        #endregion
    }
}
