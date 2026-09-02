// <copyright file="D2D_POINT_2F.cs" company="Shkyrockett" >
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
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D_POINT_2F
            : IEquatable<D2D_POINT_2F>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_POINT_2F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_POINT_2F() : this(default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_POINT_2F" /> class.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_POINT_2F(float x, float y) => (this.x, this.y) = (x, y);

            /// <summary>
            /// Deconstructs the specified point.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly void Deconstruct(out float x, out float y) => (x, y) = (this.x, this.y);

            /// <summary>
            /// Performs an implicit conversion from <see cref="PointF"/> to <see cref="D2D_POINT_2F"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D_POINT_2F(PointF value) => Unsafe.As<PointF, D2D_POINT_2F>(ref value);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Vector2"/> to <see cref="D2D_POINT_2F"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D_POINT_2F(Vector2 value) => Unsafe.As<Vector2, D2D_POINT_2F>(ref value);

            /// <summary>
            /// Performs an implicit conversion from <see cref="D2D_POINT_2F"/> to <see cref="PointF"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator PointF(D2D_POINT_2F value) => Unsafe.As<D2D_POINT_2F, PointF>(ref value);

            /// <summary>
            /// Performs an implicit conversion from <see cref="D2D_POINT_2F"/> to <see cref="Vector2"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator Vector2(D2D_POINT_2F value) => Unsafe.As<D2D_POINT_2F, Vector2>(ref value);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D_POINT_2F left, D2D_POINT_2F right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D_POINT_2F left, D2D_POINT_2F right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly override bool Equals(object? obj) => obj is D2D_POINT_2F f && Equals(f);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D_POINT_2F other) => x == other.x && y == other.y;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(x, y);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type contents.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D_POINT_2F)}({x}, {y})";

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
