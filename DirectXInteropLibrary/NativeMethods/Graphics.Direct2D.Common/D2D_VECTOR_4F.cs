// <copyright file="D2D_VECTOR_4F.cs" company="Shkyrockett" >
// Copyright © 2020 - 2026 Shkyrockett. All rights reserved.
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

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D_VECTOR_4F
            : IEquatable<D2D_VECTOR_4F>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_VECTOR_4F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_VECTOR_4F() : this(default, default, default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_VECTOR_4F" /> class.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            /// <param name="z">The z.</param>
            /// <param name="w">The w.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_VECTOR_4F(float x, float y, float z, float w) => (this.x, this.y, this.z, this.w) = (x, y, z, w);

            /// <summary>
            /// Deconstructs the specified vector.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            /// <param name="z">The z.</param>
            /// <param name="w">The w.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly void Deconstruct(out float x, out float y, out float z, out float w) => (x, y, z, w) = (this.x, this.y, this.z, this.w);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Vector4"/> to <see cref="D2D_VECTOR_4F"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D_VECTOR_4F(Vector4 value) => Unsafe.As<Vector4, D2D_VECTOR_4F>(ref value);

            /// <summary>
            /// Performs an implicit conversion from <see cref="D2D_VECTOR_4F"/> to <see cref="Vector4"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator Vector4(D2D_VECTOR_4F value) => Unsafe.As<D2D_VECTOR_4F, Vector4>(ref value);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is D2D_VECTOR_4F f && Equals(f);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D_VECTOR_4F other) => x == other.x && y == other.y && z == other.z && w == other.w;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(x, y, z, w);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type contents.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D_VECTOR_4F)}({x}, {y}, {z}, {w})";

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
