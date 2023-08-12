// <copyright file="D2D_MATRIX_3X2_F.cs" company="Shkyrockett" >
// Copyright © 2020 - 2023 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        /// <summary>
        /// 
        /// </summary>
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct D2D_MATRIX_3X2_F
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_MATRIX_3X2_F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_MATRIX_3X2_F()
                : this(Matrix3x2.Identity)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_MATRIX_3X2_F"/> struct.
            /// </summary>
            /// <param name="value">The value.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_MATRIX_3X2_F(Matrix3x2 value)
            {
                this = value;
            }

            /// <summary>
            /// Gets or sets the M11.
            /// </summary>
            /// <value>
            /// The M11.
            /// </value>
            public float M11 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous1.m11;  [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous1.m11 = value; }

            /// <summary>
            /// Gets or sets the M12.
            /// </summary>
            /// <value>
            /// The M12.
            /// </value>
            public float M12 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous1.m12; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous1.m12 = value; }

            /// <summary>
            /// Gets or sets the M21.
            /// </summary>
            /// <value>
            /// The M21.
            /// </value>
            public float M21 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous1.m21; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous1.m21 = value; }

            /// <summary>
            /// Gets or sets the M22.
            /// </summary>
            /// <value>
            /// The M22.
            /// </value>
            public float M22 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous1.m22; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous1.m22 = value; }

            /// <summary>
            /// Gets or sets the dx.
            /// </summary>
            /// <value>
            /// The dx.
            /// </value>
            public float Dx { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous1.dx; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous1.dx = value; }

            /// <summary>
            /// Gets or sets the dy.
            /// </summary>
            /// <value>
            /// The dy.
            /// </value>
            public float Dy { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous1.dy; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous1.dy = value; }

            /// <summary>
            /// Performs an implicit conversion from <see cref="Matrix3x2"/> to <see cref="D2D_MATRIX_3X2_F"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D_MATRIX_3X2_F(Matrix3x2 value) => Unsafe.As<Matrix3x2, D2D_MATRIX_3X2_F>(ref value);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{M11}, {M12}, {M21}, {M22}, {Dx}, {Dy}";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}