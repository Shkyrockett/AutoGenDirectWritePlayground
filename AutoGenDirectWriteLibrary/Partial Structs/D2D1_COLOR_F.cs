// <copyright file="D2D1_COLOR_F.cs" company="Shkyrockett" >
// Copyright © 2020 - 2023 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        /// <summary>
        /// 
        /// </summary>
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct D2D1_COLOR_F
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_COLOR_F()
                : this(default, default, default, default)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F" /> class.
            /// </summary>
            /// <param name="r">The r.</param>
            /// <param name="g">The g.</param>
            /// <param name="b">The b.</param>
            /// <param name="a">The a.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_COLOR_F(float r, float g, float b, float a)
            {
                this.r = r;
                this.g = g;
                this.b = b;
                this.a = a;
            }

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D1_COLOR_F(Color color) => new(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{r}, {g}, {b}, {a}";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
