// <copyright file="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES.cs" company="Shkyrockett" >
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
using Windows.Win32.Graphics.Direct2D.Common;

namespace Windows.Win32
{
    namespace Graphics.Direct2D
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES
            : IEquatable<D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES() : this(new D2D_POINT_2F(), new D2D_POINT_2F(), default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES"/> class.
            /// </summary>
            /// <param name="center">The center.</param>
            /// <param name="gradientOriginOffset">The gradient origin offset.</param>
            /// <param name="radiusX">The radius x.</param>
            /// <param name="radiusY">The radius y.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES(PointF center, PointF gradientOriginOffset, float radiusX, float radiusY) => (this.center, this.gradientOriginOffset, this.radiusX, this.radiusY) = (center, gradientOriginOffset, radiusX, radiusY);

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES"/> class.
            /// </summary>
            /// <param name="center">The center.</param>
            /// <param name="gradientOriginOffset">The gradient origin offset.</param>
            /// <param name="radiusX">The radius x.</param>
            /// <param name="radiusY">The radius y.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES(D2D_POINT_2F center, D2D_POINT_2F gradientOriginOffset, float radiusX, float radiusY) => (this.center, this.gradientOriginOffset, this.radiusX, this.radiusY) = (center, gradientOriginOffset, radiusX, radiusY);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES left, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES left, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES pROPERTIES && Equals(pROPERTIES);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES other) => center.Equals(other.center) && gradientOriginOffset.Equals(other.gradientOriginOffset) && radiusX == other.radiusX && radiusY == other.radiusY;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(center, gradientOriginOffset, radiusX, radiusY);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES)}({center}, {gradientOriginOffset}, {radiusX}, {radiusY})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}