// <copyright file="DWRITE_TEXT_RANGE.cs" company="Shkyrockett" >
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
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct DWRITE_TEXT_RANGE
            : IEquatable<DWRITE_TEXT_RANGE>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_TEXT_RANGE"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public DWRITE_TEXT_RANGE() : this(default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_TEXT_RANGE"/> struct.
            /// </summary>
            /// <param name="startPosition">The start position.</param>
            /// <param name="length">The length.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public DWRITE_TEXT_RANGE(uint startPosition, uint length) => (this.startPosition, this.length) = (startPosition, length);

            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_TEXT_RANGE"/> struct.
            /// </summary>
            /// <param name="startPosition">The start position.</param>
            public DWRITE_TEXT_RANGE(uint startPosition) => (this.startPosition, length) = (startPosition, uint.MaxValue - startPosition);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(DWRITE_TEXT_RANGE left, DWRITE_TEXT_RANGE right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(DWRITE_TEXT_RANGE left, DWRITE_TEXT_RANGE right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is DWRITE_TEXT_RANGE rANGE && Equals(rANGE);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(DWRITE_TEXT_RANGE other) => startPosition == other.startPosition && length == other.length;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(startPosition, length);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(DWRITE_TEXT_RANGE)}({startPosition}, {length})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
