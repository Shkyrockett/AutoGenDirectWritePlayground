// <copyright file="D2D1_GRADIENT_STOP.cs" company="Shkyrockett" >
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
        public partial struct D2D1_GRADIENT_STOP
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_GRADIENT_STOP"/> class.
            /// </summary>
            /// <param name="position">The position.</param>
            /// <param name="color">The color.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_GRADIENT_STOP(float position, Color color)
                : this(position, (D2D1_COLOR_F)color)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_GRADIENT_STOP"/> class.
            /// </summary>
            /// <param name="position">The position.</param>
            /// <param name="color">The color.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_GRADIENT_STOP(float position, D2D1_COLOR_F color)
            {
                this.position = position;
                this.color = color;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{position}, D2D1_COLOR_F({color})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
