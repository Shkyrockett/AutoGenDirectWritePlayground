// <copyright file="D2D_MATRIX_4X4_F.cs" company="Shkyrockett" >
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
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D_MATRIX_4X4_F
            : IEquatable<D2D_MATRIX_4X4_F>
        {
            /// <summary>
            /// Gets the identity.
            /// </summary>
            /// <value>
            /// The identity.
            /// </value>
            public static D2D_MATRIX_4X4_F Identity
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get => new(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1);
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_MATRIX_4X4_F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_MATRIX_4X4_F() : this(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_MATRIX_4X4_F"/> struct.
            /// </summary>
            /// <param name="m11">The M11.</param>
            /// <param name="m12">The M12.</param>
            /// <param name="m13">The M13.</param>
            /// <param name="m14">The M14.</param>
            /// <param name="m21">The M21.</param>
            /// <param name="m22">The M22.</param>
            /// <param name="m23">The M23.</param>
            /// <param name="m24">The M24.</param>
            /// <param name="m31">The M31.</param>
            /// <param name="m32">The M32.</param>
            /// <param name="m33">The M33.</param>
            /// <param name="m34">The M34.</param>
            /// <param name="m41">The M41.</param>
            /// <param name="m42">The M42.</param>
            /// <param name="m43">The M43.</param>
            /// <param name="m44">The M44.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D_MATRIX_4X4_F(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44) => (this.m11, this.m12, this.m13, this.m14, this.m21, this.m22, this.m23, this.m24, this.m31, this.m32, this.m33, this.m34, this.m41, this.m42, this.m43, this.m44) = (m11, m12, m13, m14, m21, m22, m23, m24, m31, m32, m33, m34, m41, m42, m43, m44);

            /// <summary>
            /// Gets or sets the M11.
            /// </summary>
            /// <value>
            /// The M11.
            /// </value>
            public float m11 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._11; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._11 = value; }

            /// <summary>
            /// Gets or sets the M12.
            /// </summary>
            /// <value>
            /// The M12.
            /// </value>
            public float m12 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._12; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._12 = value; }

            /// <summary>
            /// Gets or sets the M13.
            /// </summary>
            /// <value>
            /// The M13.
            /// </value>
            public float m13 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._13; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._13 = value; }

            /// <summary>
            /// Gets or sets the M14.
            /// </summary>
            /// <value>
            /// The M14.
            /// </value>
            public float m14 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._14; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._14 = value; }

            /// <summary>
            /// Gets or sets the M21.
            /// </summary>
            /// <value>
            /// The M21.
            /// </value>
            public float m21 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._21; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._21 = value; }

            /// <summary>
            /// Gets or sets the M22.
            /// </summary>
            /// <value>
            /// The M22.
            /// </value>
            public float m22 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._22; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._22 = value; }

            /// <summary>
            /// Gets or sets the M23.
            /// </summary>
            /// <value>
            /// The M23.
            /// </value>
            public float m23 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._23; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._23 = value; }

            /// <summary>
            /// Gets or sets the M24.
            /// </summary>
            /// <value>
            /// The M24.
            /// </value>
            public float m24 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._24; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._24 = value; }

            /// <summary>
            /// Gets or sets the M31.
            /// </summary>
            /// <value>
            /// The M31.
            /// </value>
            public float m31 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._31; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._31 = value; }

            /// <summary>
            /// Gets or sets the M32.
            /// </summary>
            /// <value>
            /// The M32.
            /// </value>
            public float m32 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._32; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._32 = value; }

            /// <summary>
            /// Gets or sets the M33.
            /// </summary>
            /// <value>
            /// The M33.
            /// </value>
            public float m33 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._33; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._33 = value; }

            /// <summary>
            /// Gets or sets the M34.
            /// </summary>
            /// <value>
            /// The M34.
            /// </value>
            public float m34 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._34; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._34 = value; }

            /// <summary>
            /// Gets or sets the M41.
            /// </summary>
            /// <value>
            /// The M41.
            /// </value>
            public float m41 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._41; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._41 = value; }

            /// <summary>
            /// Gets or sets the M42.
            /// </summary>
            /// <value>
            /// The M42.
            /// </value>
            public float m42 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._42; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._42 = value; }

            /// <summary>
            /// Gets or sets the M43.
            /// </summary>
            /// <value>
            /// The M43.
            /// </value>
            public float m43 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._43; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._43 = value; }

            /// <summary>
            /// Gets or sets the M44.
            /// </summary>
            /// <value>
            /// The M44.
            /// </value>
            public float m44 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] readonly get => Anonymous.Anonymous._44; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set => Anonymous.Anonymous._44 = value; }

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D_MATRIX_4X4_F left, D2D_MATRIX_4X4_F right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D_MATRIX_4X4_F left, D2D_MATRIX_4X4_F right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is D2D_MATRIX_4X4_F f && Equals(f);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D_MATRIX_4X4_F other) => m11 == other.m11 &&
                       m12 == other.m12 &&
                       m13 == other.m13 &&
                       m14 == other.m14 &&
                       m21 == other.m21 &&
                       m22 == other.m22 &&
                       m23 == other.m23 &&
                       m24 == other.m24 &&
                       m31 == other.m31 &&
                       m32 == other.m32 &&
                       m33 == other.m33 &&
                       m34 == other.m34 &&
                       m41 == other.m41 &&
                       m42 == other.m42 &&
                       m43 == other.m43 &&
                       m44 == other.m44;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode()
            {
                HashCode hash = new();
                hash.Add(m11);
                hash.Add(m12);
                hash.Add(m13);
                hash.Add(m14);
                hash.Add(m21);
                hash.Add(m22);
                hash.Add(m23);
                hash.Add(m24);
                hash.Add(m31);
                hash.Add(m32);
                hash.Add(m33);
                hash.Add(m34);
                hash.Add(m41);
                hash.Add(m42);
                hash.Add(m43);
                hash.Add(m44);
                return hash.ToHashCode();
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D_MATRIX_4X4_F)}({m11}, {m12}, {m13}, {m14}, {m21}, {m22}, {m23}, {m24}, {m31}, {m32}, {m33}, {m34}, {m41}, {m42}, {m43}, {m44})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}