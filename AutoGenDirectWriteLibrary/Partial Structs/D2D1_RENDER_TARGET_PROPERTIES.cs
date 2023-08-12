// <copyright file="D2D1_RENDER_TARGET_PROPERTIES.cs" company="Shkyrockett" >
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
        public partial struct D2D1_RENDER_TARGET_PROPERTIES
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RENDER_TARGET_PROPERTIES"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_RENDER_TARGET_PROPERTIES()
                : this(D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_DEFAULT, new D2D1_PIXEL_FORMAT(), default, default, D2D1_RENDER_TARGET_USAGE.D2D1_RENDER_TARGET_USAGE_NONE, D2D1_FEATURE_LEVEL.D2D1_FEATURE_LEVEL_DEFAULT)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RENDER_TARGET_PROPERTIES"/> class.
            /// </summary>
            /// <param name="type">The type.</param>
            /// <param name="pixelFormat">The pixel format.</param>
            /// <param name="dpiX">The dpi x.</param>
            /// <param name="dpiY">The dpi y.</param>
            /// <param name="usage">The usage.</param>
            /// <param name="minLevel">The min level.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE type, D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY, D2D1_RENDER_TARGET_USAGE usage, D2D1_FEATURE_LEVEL minLevel)
            {
                this.type = type;
                this.pixelFormat = pixelFormat;
                this.dpiX = dpiX;
                this.dpiY = dpiY;
                this.usage = usage;
                this.minLevel = minLevel;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{type}, {pixelFormat}, {dpiX}, {dpiY}, {usage}, {minLevel}";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
