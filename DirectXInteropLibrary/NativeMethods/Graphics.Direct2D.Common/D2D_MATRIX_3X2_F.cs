// <copyright file="D2D_MATRIX_3X2_F.cs" company="Shkyrockett" >
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
using Windows.Win32.Foundation;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D_MATRIX_3X2_F
            : IEquatable<D2D_MATRIX_3X2_F>
        {
            /// <summary>
            /// Gets the identity.
            /// </summary>
            /// <value>
            /// The identity.
            /// </value>
            public static D2D_MATRIX_3X2_F Identity
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get => new(Matrix3x2.Identity);
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_MATRIX_3X2_F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_MATRIX_3X2_F() : this(Matrix3x2.Identity) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_MATRIX_3X2_F"/> struct.
            /// </summary>
            /// <param name="value">The value.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_MATRIX_3X2_F(Matrix3x2 value) => this = value;

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_MATRIX_3X2_F"/> struct.
            /// </summary>
            /// <param name="m11">The M11.</param>
            /// <param name="m12">The M12.</param>
            /// <param name="m21">The M21.</param>
            /// <param name="m22">The M22.</param>
            /// <param name="dx">The Dx.</param>
            /// <param name="dy">The DY.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_MATRIX_3X2_F(float m11, float m12, float m21, float m22, float dx, float dy) : this() => (this.m11, this.m12, this.m21, this.m22, this.dx, this.dy) = (m11, m12, m21, m22, dx, dy);

            /// <summary>
            /// Gets the is matrix invertible.
            /// </summary>
            /// <value>
            /// The is matrix invertible.
            /// </value>
            public readonly BOOL IsMatrixInvertible
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get => PInvoke.D2D1IsMatrixInvertible(this);
            }

            /// <summary>
            /// Implements the operator *.
            /// </summary>
            /// <param name="a">a.</param>
            /// <param name="b">The b.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [OverloadResolutionPriority(0)]
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F operator *(D2D_MATRIX_3X2_F a, D2D_MATRIX_3X2_F b)
            {
                Matrix3x2 ma = a;
                Matrix3x2 mb = b;
                return new(ma * mb);
            }

            /// <summary>
            /// Performs an implicit conversion from <see cref="Matrix3x2"/> to <see cref="D2D_MATRIX_3X2_F"/>.
            /// </summary>
            /// <param name="value">The value.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D_MATRIX_3X2_F(Matrix3x2 value) => Unsafe.As<Matrix3x2, D2D_MATRIX_3X2_F>(ref value);

            /// <summary>
            /// Performs an implicit conversion from <see cref="D2D_MATRIX_3X2_F"/> to <see cref="Matrix3x2"/>.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator Matrix3x2(D2D_MATRIX_3X2_F value) => Unsafe.As<D2D_MATRIX_3X2_F, Matrix3x2>(ref value);

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D_MATRIX_3X2_F left, D2D_MATRIX_3X2_F right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D_MATRIX_3X2_F left, D2D_MATRIX_3X2_F right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override bool Equals(object? obj) => obj is D2D_MATRIX_3X2_F f && Equals(f);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Equals(D2D_MATRIX_3X2_F other) => m11 == other.m11 &&
                       m12 == other.m12 &&
                       m21 == other.m21 &&
                       m22 == other.m22 &&
                       dx == other.dx &&
                       dy == other.dy;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override int GetHashCode() => HashCode.Combine(m11, m12, m21, m22, dx, dy, Anonymous);

            /// <summary>
            /// Sets the product.
            /// </summary>
            /// <param name="a">a.</param>
            /// <param name="b">The b.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void SetProduct(in D2D_MATRIX_3X2_F a, in D2D_MATRIX_3X2_F b)
            {
                // Direct2D 3x2 matrix multiplication:
                //
                // [ a11 a12 a31 ]   [ b11 b12 b31 ]
                // [ a21 a22 a32 ] * [ b21 b22 b32 ]
                //
                // Result is also 3x2.

                m11 = (a.m11 * b.m11) + (a.m12 * b.m21);
                m12 = (a.m11 * b.m12) + (a.m12 * b.m22);

                m21 = (a.m21 * b.m11) + (a.m22 * b.m21);
                m22 = (a.m21 * b.m12) + (a.m22 * b.m22);

                dx = (a.dx * b.m11) + (a.dy * b.m21) + b.dx;
                dy = (a.dx * b.m12) + (a.dy * b.m22) + b.dy;
            }

            /// <summary>
            /// Creates the translation.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateTranslation(float x, float y) => new(Matrix3x2.CreateTranslation(x, y));

            /// <summary>
            /// Creates the translation.
            /// </summary>
            /// <param name="v">The v.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateTranslation(Vector2 v) => new(Matrix3x2.CreateTranslation(v));

            /// <summary>
            /// Creates the scale.
            /// </summary>
            /// <param name="scale">The scale.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateScale(float scale) => new(Matrix3x2.CreateScale(scale));

            /// <summary>
            /// Creates the scale.
            /// </summary>
            /// <param name="sx">The sx.</param>
            /// <param name="sy">The sy.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateScale(float sx, float sy) => new(Matrix3x2.CreateScale(sx, sy));

            /// <summary>
            /// Creates the scale.
            /// </summary>
            /// <param name="sx">The sx.</param>
            /// <param name="sy">The sy.</param>
            /// <param name="center">The center.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateScale(float sx, float sy, D2D_POINT_2F center) => new(Matrix3x2.CreateScale(sx, sy, new Vector2(center.x, center.y)));

            /// <summary>
            /// Creates the scale.
            /// </summary>
            /// <param name="scale">The scale.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateScale(Vector2 scale) => new(Matrix3x2.CreateScale(scale));

            /// <summary>
            /// Creates the rotation.
            /// </summary>
            /// <param name="angle">The angle in radians.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateRotation(float angle)
            {
                PInvoke.D2D1MakeRotateMatrix(angle, default, out D2D_MATRIX_3X2_F matrix);
                return matrix;
            }

            /// <summary>
            /// Creates the rotation.
            /// </summary>
            /// <param name="angle">The angle in radians.</param>
            /// <param name="center">The center point.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateRotation(float angle, Vector2 center)
            {
                PInvoke.D2D1MakeRotateMatrix(angle, (D2D_POINT_2F)center, out D2D_MATRIX_3X2_F matrix);
                return matrix;
            }

            /// <summary>
            /// Creates the rotation matrix for an angle.
            /// </summary>
            /// <param name="angle">The angle in radians.</param>
            /// <param name="center">The center point.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateRotation(float angle, D2D_POINT_2F center)
            {
                PInvoke.D2D1MakeRotateMatrix(angle, center, out D2D_MATRIX_3X2_F matrix);
                return matrix;
            }

            /// <summary>
            /// Creates the skew.
            /// </summary>
            /// <param name="angleX">The radians x.</param>
            /// <param name="angleY">The radians y.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateSkew(float angleX, float angleY)
            {
                PInvoke.D2D1MakeSkewMatrix(angleX, angleY, default, out D2D_MATRIX_3X2_F matrix);
                return new(Matrix3x2.CreateSkew(angleX, angleY));
            }

            /// <summary>
            /// Creates the skew.
            /// </summary>
            /// <param name="angleX">The radians x.</param>
            /// <param name="angleY">The radians y.</param>
            /// <param name="center">The center.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static D2D_MATRIX_3X2_F CreateSkew(float angleX, float angleY, D2D_POINT_2F center)
            {
                PInvoke.D2D1MakeSkewMatrix(angleX, angleY, center, out D2D_MATRIX_3X2_F matrix);
                return matrix;
            }

            /// <summary>
            /// Transforms the point.
            /// </summary>
            /// <param name="point">The point.</param>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly Vector2 TransformPoint(Vector2 point)
            {
                Matrix3x2 m = this;
                return Vector2.Transform(point, m);
            }

            /// <summary>
            /// Inverts the matrix.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public BOOL Invert() => PInvoke.D2D1InvertMatrix(ref this);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override string? ToString() => $"{nameof(D2D_MATRIX_3X2_F)}({m11}, {m12}, {m21}, {m22}, {dx}, {dy})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private string? GetDebuggerDisplay() => ToString();
        }
    }
}