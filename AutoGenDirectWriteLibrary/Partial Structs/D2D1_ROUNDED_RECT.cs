// <copyright file="D2D1_ROUNDED_RECT.cs" company="Shkyrockett" >
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
using Windows.Win32.Graphics.Direct2D.Common;

namespace Windows.Win32
{
    namespace Graphics.Direct2D
    {
        /// <summary>
        /// 
        /// </summary>
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct D2D1_ROUNDED_RECT
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_ROUNDED_RECT"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_ROUNDED_RECT()
                : this(new(), default, default)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_ROUNDED_RECT" /> struct.
            /// </summary>
            /// <param name="rect">The rect.</param>
            /// <param name="radiusX">The radius x.</param>
            /// <param name="radiusY">The radius y.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_ROUNDED_RECT(RectangleF rect, float radiusX, float radiusY)
                : this((D2D_RECT_F)rect, radiusX, radiusY)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_ROUNDED_RECT"/> class.
            /// </summary>
            /// <param name="rect">The rect.</param>
            /// <param name="radiusX">The radius x.</param>
            /// <param name="radiusY">The radius y.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_ROUNDED_RECT(D2D_RECT_F rect, float radiusX, float radiusY)
            {
                this.rect = rect;
                this.radiusX = radiusX;
                this.radiusY = radiusY;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"D2D_RECT_F({rect}), {radiusX}, {radiusY}";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
