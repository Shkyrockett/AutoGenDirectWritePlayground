// <copyright file="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.cs" company="Shkyrockett" >
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
        public partial struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES()
                : this(new(), new())
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES"/> class.
            /// </summary>
            /// <param name="startPoint">The start point.</param>
            /// <param name="endPoint">The end point.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES(D2D_POINT_2F startPoint, D2D_POINT_2F endPoint)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"D2D_POINT_2F({startPoint}), D2D_POINT_2F({endPoint})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
