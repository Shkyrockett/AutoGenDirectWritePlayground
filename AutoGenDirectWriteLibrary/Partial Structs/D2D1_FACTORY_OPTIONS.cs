// <copyright file="D2D1_FACTORY_OPTIONS.cs" company="Shkyrockett" >
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
    namespace Graphics.Direct2D
    {
        /// <summary>
        /// 
        /// </summary>
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct D2D1_FACTORY_OPTIONS
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_FACTORY_OPTIONS"/> class.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_FACTORY_OPTIONS()
                : this(D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_FACTORY_OPTIONS"/> class.
            /// </summary>
            /// <param name="debugLevel">The debug level.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_FACTORY_OPTIONS(D2D1_DEBUG_LEVEL debugLevel) => this.debugLevel = debugLevel;

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{debugLevel}";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
