// <copyright file="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.cs" company="Shkyrockett" >
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
using Windows.Win32.Graphics.Direct2D.Common;

namespace Windows.Win32
{
    namespace Graphics.Direct2D
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
            : IEquatable<D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES() : this(new(), new()) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES"/> class.
            /// </summary>
            /// <param name="startPoint">The start point.</param>
            /// <param name="endPoint">The end point.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES(D2D_POINT_2F startPoint, D2D_POINT_2F endPoint) => (this.startPoint, this.endPoint) = (startPoint, endPoint);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES left, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES left, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES pROPERTIES && Equals(pROPERTIES);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES other) => startPoint.Equals(other.startPoint) && endPoint.Equals(other.endPoint);

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(startPoint, endPoint);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES)}({startPoint}, {endPoint})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
