// <copyright file="D2D1_BRUSH_PROPERTIES.cs" company="Shkyrockett" >
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
using Windows.Win32.Graphics.Direct2D.Common;

namespace Windows.Win32
{
    namespace Graphics.Direct2D
    {
        /// <summary>
        /// 
        /// </summary>
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct D2D1_BRUSH_PROPERTIES
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_BRUSH_PROPERTIES"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_BRUSH_PROPERTIES()
                : this(default, new())
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_BRUSH_PROPERTIES"/> struct.
            /// </summary>
            /// <param name="opacity">The opacity.</param>
            /// <param name="transform">The transform.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_BRUSH_PROPERTIES(float opacity, Matrix3x2 transform)
                :this(opacity,(D2D_MATRIX_3X2_F)transform)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_BRUSH_PROPERTIES" /> class.
            /// </summary>
            /// <param name="opacity">The opacity.</param>
            /// <param name="transform">The transform.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_BRUSH_PROPERTIES(float opacity, D2D_MATRIX_3X2_F transform)
            {
                this.opacity = opacity;
                this.transform = transform;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{opacity}, D2D_MATRIX_3X2_F({transform})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
