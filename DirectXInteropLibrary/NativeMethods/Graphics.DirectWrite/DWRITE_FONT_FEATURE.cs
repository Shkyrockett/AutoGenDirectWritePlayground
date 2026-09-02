// <copyright file="DWRITE_FONT_FEATURE.cs" company="Shkyrockett" >
// Copyright © 2020 - 2026 Shkyrockett. All rights reserved.
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
        /// <seealso cref="System.IEquatable&lt;Windows.Win32.Graphics.DirectWrite.DWRITE_FONT_FEATURE&gt;" />
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct DWRITE_FONT_FEATURE
            : IEquatable<DWRITE_FONT_FEATURE>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_FONT_FEATURE"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public DWRITE_FONT_FEATURE() : this(default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_FONT_FEATURE"/> class.
            /// </summary>
            /// <param name="nameTag">The name tag.</param>
            /// <param name="parameter">The parameter.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public DWRITE_FONT_FEATURE(DWRITE_FONT_FEATURE_TAG nameTag, uint parameter) => (this.nameTag, this.parameter) = (nameTag, parameter);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(DWRITE_FONT_FEATURE left, DWRITE_FONT_FEATURE right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(DWRITE_FONT_FEATURE left, DWRITE_FONT_FEATURE right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is DWRITE_FONT_FEATURE fEATURE && Equals(fEATURE);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(DWRITE_FONT_FEATURE other) => nameTag == other.nameTag && parameter == other.parameter;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(nameTag, parameter);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(DWRITE_FONT_FEATURE)}({nameTag}, {parameter})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
