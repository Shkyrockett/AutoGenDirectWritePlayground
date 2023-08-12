// <copyright file="DWRITE_FONT_FEATURE.cs" company="Shkyrockett" >
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
    namespace Graphics.DirectWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct DWRITE_FONT_FEATURE
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_FONT_FEATURE"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public DWRITE_FONT_FEATURE()
                : this(default, default)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_FONT_FEATURE"/> class.
            /// </summary>
            /// <param name="nameTag">The name tag.</param>
            /// <param name="parameter">The parameter.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public DWRITE_FONT_FEATURE(DWRITE_FONT_FEATURE_TAG nameTag, uint parameter)
            {
                this.nameTag = nameTag;
                this.parameter = parameter;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameTag}, {parameter}";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
