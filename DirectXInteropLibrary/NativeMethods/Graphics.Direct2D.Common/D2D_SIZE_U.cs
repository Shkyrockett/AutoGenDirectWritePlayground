// <copyright file="D2D_SIZE_U.cs" company="Shkyrockett" >
// Copyright © 2020 - 2026 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D_SIZE_U
            : IEquatable<D2D_SIZE_U>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_SIZE_U"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_SIZE_U() : this(default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_SIZE_U" /> class.
            /// </summary>
            /// <param name="width">The width.</param>
            /// <param name="height">The height.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_SIZE_U(uint width, uint height) => (this.width, this.height) = (width, height);

            /// <summary>
            /// Deconstructs the specified size.
            /// </summary>
            /// <param name="width">The width.</param>
            /// <param name="height">The height.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly void Deconstruct(out uint width, out uint height) => (width, height) = (this.width, this.height);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Size" /> to <see cref="D2D_SIZE_U" />.
            /// </summary>
            /// <param name="size">The size.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator D2D_SIZE_U(Size size) => new((uint)size.Width, (uint)size.Height);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Size" /> to <see cref="D2D_SIZE_U" />.
            /// </summary>
            /// <param name="size">The size.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator Size(D2D_SIZE_U size) => new((int)size.width, (int)size.height);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D_SIZE_U left, D2D_SIZE_U right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D_SIZE_U left, D2D_SIZE_U right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is D2D_SIZE_U u && Equals(u);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D_SIZE_U other) => width == other.width && height == other.height;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(width, height);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D_SIZE_U)}({width}, {height})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns>
            /// A string? .
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
