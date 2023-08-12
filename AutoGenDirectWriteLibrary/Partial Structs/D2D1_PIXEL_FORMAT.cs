// <copyright file="D2D1_PIXEL_FORMAT.cs" company="Shkyrockett" >
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
using Windows.Win32.Graphics.Dxgi.Common;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        /// <summary>
        /// 
        /// </summary>
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct D2D1_PIXEL_FORMAT
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_PIXEL_FORMAT"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_PIXEL_FORMAT()
                : this(DXGI_FORMAT.DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE.D2D1_ALPHA_MODE_UNKNOWN)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_PIXEL_FORMAT"/> class.
            /// </summary>
            /// <param name="format">The format.</param>
            /// <param name="alphaMode">The alpha mode.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_PIXEL_FORMAT(DXGI_FORMAT format, D2D1_ALPHA_MODE alphaMode)
            {
                this.format = format;
                this.alphaMode = alphaMode;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{format}, {alphaMode}";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
