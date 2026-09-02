// <copyright file="D2D_RECT_F.cs" company="Shkyrockett" >
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
        partial struct D2D_RECT_F
            : IEquatable<D2D_RECT_F>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_RECT_F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_RECT_F() : this(default, default, default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_RECT_F" /> class.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="top">The top.</param>
            /// <param name="right">The right.</param>
            /// <param name="bottom">The bottom.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_RECT_F(float left, float top, float right, float bottom) => (this.left, this.top, this.right, this.bottom) = (left, top, right, bottom);

            /// <summary>
            /// Deconstructs the specified rectangle.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="top">The top.</param>
            /// <param name="right">The right.</param>
            /// <param name="bottom">The bottom.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly void Deconstruct(out float left, out float top, out float right, out float bottom) => (left, top, right, bottom) = (this.left, this.top, this.right, this.bottom);

            /// <summary>
            /// Gets or sets the width of the rectangle.
            /// </summary>
            public float width
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                readonly get => right - left;
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set => right = left + value;
            }

            /// <summary>
            /// Gets or sets the height of the rectangle.
            /// </summary>
            public float height
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                readonly get => bottom - top;
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set => bottom = top + value;
            }

            /// <summary>
            /// Gets or sets the top-left corner of the rectangle.
            /// </summary>
            public D2D_POINT_2F location
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                readonly get => new(left, top);
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    float w = width;
                    float h = height;
                    left = value.x;
                    top = value.y;
                    right = value.x + w;
                    bottom = value.y + h;
                }
            }

            /// <summary>
            /// Gets or sets the center point of the rectangle.
            /// </summary>
            /// <remarks>
            /// When setting the center, the rectangle's dimensions (Width and Height) are preserved.
            /// </remarks>
            public D2D_POINT_2F center
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                readonly get => new((left + right) / 2f, (top + bottom) / 2f);
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    float hWidth = width / 2f;
                    float hHeight = height / 2f;
                    left = value.x - hWidth;
                    right = value.x + hWidth;
                    top = value.y - hHeight;
                    bottom = value.y + hHeight;
                }
            }

            /// <summary>
            /// Gets or sets the size of the rectangle.
            /// </summary>
            public D2D_SIZE_F size
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                readonly get => new(width, height);
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    right = left + value.width;
                    bottom = top + value.height;
                }
            }

            /// <summary>
            /// Gets a value indicating whether the rectangle has an area of 0 or less.
            /// </summary>
            public readonly bool IsEmpty
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get => left >= right || top >= bottom;
            }

            /// <summary>
            /// Performs an implicit conversion from <see cref="RectangleF"/> to <see cref="D2D_RECT_F"/>.
            /// </summary>
            /// <param name="rect">The rect.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D_RECT_F(RectangleF rect) => new(rect.Left, rect.Top, rect.Right, rect.Bottom);

            /// <summary>
            /// Performs an implicit conversion from <see cref="D2D_RECT_F"/> to <see cref="RectangleF"/>.
            /// </summary>
            /// <param name="rect">The rect.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator RectangleF(D2D_RECT_F rect) => RectangleF.FromLTRB(rect.left, rect.top, rect.right, rect.bottom);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D_RECT_F left, D2D_RECT_F right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D_RECT_F left, D2D_RECT_F right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is D2D_RECT_F f && Equals(f);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D_RECT_F other) => left == other.left && top == other.top && right == other.right && bottom == other.bottom;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(left, top, right, bottom);

            /// <summary>
            /// Determines whether the specified point is contained within the rectangle.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Contains(D2D_POINT_2F point) => point.x >= left && point.x <= right && point.y >= top && point.y <= bottom;

            /// <summary>
            /// Moves the rectangle by a specific offset.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void Offset(float dx, float dy)
            {
                left += dx;
                right += dx;
                top += dy;
                bottom += dy;
            }

            /// <summary>
            /// Expands or shrinks the rectangle by the specified amount.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void Inflate(float horizontalAmount, float verticalAmount)
            {
                left -= horizontalAmount;
                right += horizontalAmount;
                top -= verticalAmount;
                bottom += verticalAmount;
            }

            /// <summary>
            /// Creates a new rectangle that is the result of overlapping this rectangle with another.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_RECT_F Intersect(D2D_RECT_F a, D2D_RECT_F b)
            {
                float x1 = MathF.Max(a.left, b.left);
                float x2 = MathF.Min(a.right, b.right);
                float y1 = MathF.Max(a.top, b.top);
                float y2 = MathF.Min(a.bottom, b.bottom);

                if (x2 >= x1 && y2 >= y1)
                    return new D2D_RECT_F(x1, y1, x2, y2);

                return default;
            }

            /// <summary>
            /// Determines if this rectangle intersects with another rectangle.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool IntersectsWith(D2D_RECT_F rect) => rect.left < right && left < rect.right && rect.top < bottom && top < rect.bottom;

            /// <summary>
            /// Creates a rectangle that represents the union of two rectangles (the smallest rectangle that contains both).
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_RECT_F Union(D2D_RECT_F a, D2D_RECT_F b) => new(MathF.Min(a.left, b.left), MathF.Min(a.top, b.top), MathF.Max(a.right, b.right), MathF.Max(a.bottom, b.bottom));

            /// <summary>
            /// Adjusts the rectangle coordinates so that left <= right and top <= bottom.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void Normalize()
            {
                if (left > right) (left, right) = (right, left);
                if (top > bottom) (top, bottom) = (bottom, top);
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D_RECT_F)}({left}, {top}, {right}, {bottom})";

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
