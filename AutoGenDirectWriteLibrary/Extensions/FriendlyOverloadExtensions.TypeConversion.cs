// <copyright file="FriendlyOverloadExtensions.TypeConversions.cs" company="Shkyrockett" >
// Copyright © 2020 - 2023 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Numerics;
using System.Runtime.CompilerServices;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;

namespace Windows.Win32;

/// <summary>
/// The friendly overload extensions.
/// </summary>
public static partial class FriendlyOverloadExtensions
{
    #region Type Conversion
    /// <summary>
    /// Converts a Vector2 to a D2D_POINT_2F.
    /// </summary>
    /// <param name="vector">The vector.</param>
    /// <returns>
    /// A D2D_POINT_2F.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static D2D_POINT_2F ToD2D_POINT_F(this Vector2 vector) => Unsafe.As<Vector2, D2D_POINT_2F>(ref vector);

    /// <summary>
    /// Converts a D2D_POINT_2F to a Vector2.
    /// </summary>
    /// <param name="vector">The vector.</param>
    /// <returns>
    /// A Vector2.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static Vector2 ToVector2(this D2D_POINT_2F vector) => Unsafe.As<D2D_POINT_2F, Vector2>(ref vector);

    /// <summary>
    /// Converts a PointF to a D2D_POINT_2F.
    /// </summary>
    /// <param name="point">The point.</param>
    /// <returns>
    /// A D2D_POINT_2F.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static D2D_POINT_2F ToD2D_POINT_2F(this PointF point) => Unsafe.As<PointF, D2D_POINT_2F>(ref point);

    /// <summary>
    /// Converts a D2D_POINT_2F to a PointF.
    /// </summary>
    /// <param name="point">The point.</param>
    /// <returns>
    /// A PointF.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static PointF ToPointF(this D2D_POINT_2F point) => Unsafe.As<D2D_POINT_2F, PointF>(ref point);

    /// <summary>
    /// Converts a Point to a D2D_POINT_2U.
    /// </summary>
    /// <param name="point">The point.</param>
    /// <returns>
    /// A D2D_POINT_2U.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static D2D_POINT_2U ToD2D_POINT_2U(this Point point) => Unsafe.As<Point, D2D_POINT_2U>(ref point);

    /// <summary>
    /// Converts a D2D_POINT_2U to a Point.
    /// </summary>
    /// <param name="point">The point.</param>
    /// <returns>
    /// A Point.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static Point ToPoint(this D2D_POINT_2U point) => Unsafe.As<D2D_POINT_2U, Point>(ref point);

    /// <summary>
    /// Converts a SizeF to a D2D_SIZE_F.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns>
    /// A D2D_SIZE_F.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static D2D_SIZE_F ToD2D_SIZE_F(this SizeF size) => new(size.Width, size.Height);

    /// <summary>
    /// Converts a D2D_SIZE_F to a SizeF.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns>
    /// A SizeF.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static SizeF ToSizeF(this D2D_SIZE_F size) => new(size.width, size.height);

    /// <summary>
    /// Converts a Size to a D2D_SIZE_U.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns>
    /// A D2D_SIZE_U.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static D2D_SIZE_U ToD2D_SIZE_U(this Size size) => new((uint)size.Width, (uint)size.Height);

    /// <summary>
    /// Converts a D2D_SIZE_U to a Size.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns>
    /// A Size.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Size ToSize(this D2D_SIZE_U size) => new((int)size.width, (int)size.height);

    /// <summary>
    /// Converts a Color to a D2D1_COLOR_F.
    /// </summary>
    /// <param name="color">The color.</param>
    /// <returns>
    /// A D2D1_COLOR_F.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static D2D1_COLOR_F ToD2D1_COLOR_F(this Color color) => new() { r = color.R / 255.0f, g = color.G / 255.0f, b = color.B / 255.0f, a = color.A / 255.0f };

    /// <summary>
    /// Converts a D2D1_COLOR_F to a Color.
    /// </summary>
    /// <param name="color">The color.</param>
    /// <returns>
    /// A Color.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Color ToColor(this D2D1_COLOR_F color) => Color.FromArgb((int)(color.a * 255), (int)(color.r * 255), (int)(color.g * 255), (int)(color.b * 255));

    /// <summary>
    /// Converts a RectangleF to a D2D_RECT_F.
    /// </summary>
    /// <param name="rect">The rect.</param>
    /// <returns>
    /// A D2D_RECT_F.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static D2D_RECT_F ToD2D_RECT_F(this RectangleF rect) => new() { left = rect.Left, top = rect.Top, right = rect.Right, bottom = rect.Bottom };

    /// <summary>
    /// Converts a D2D_RECT_F to a RectangleF.
    /// </summary>
    /// <param name="rect">The rect.</param>
    /// <returns>
    /// A RectangleF.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static RectangleF ToD2D_RECT_F(this D2D_RECT_F rect) => RectangleF.FromLTRB(rect.left, rect.top, rect.right, rect.bottom);

    /// <summary>
    /// Converts a Rectangle to a D2D_RECT_U.
    /// </summary>
    /// <param name="rect">The rect.</param>
    /// <returns>
    /// A D2D_RECT_U.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static D2D_RECT_U ToD2D_RECT_F(this Rectangle rect) => new() { left = (uint)rect.Left, top = (uint)rect.Top, right = (uint)rect.Right, bottom = (uint)rect.Bottom };

    /// <summary>
    /// Converts a D2D_RECT_U to a Rectangle.
    /// </summary>
    /// <param name="rect">The rect.</param>
    /// <returns>
    /// A Rectangle.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Rectangle ToD2D_RECT_U(this D2D_RECT_U rect) => Rectangle.FromLTRB((int)rect.left, (int)rect.top, (int)rect.right, (int)rect.bottom);

    /// <summary>
    /// Converts a Rectangle to a RECT.
    /// </summary>
    /// <param name="rect">The rect.</param>
    /// <returns>
    /// A Windows.Win32.Foundation.RECT.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Foundation.RECT ToD2D_RECT(this Rectangle rect) => new() { left = rect.Left, top = rect.Top, right = rect.Right, bottom = rect.Bottom };

    /// <summary>
    /// Converts a D2D_MATRIX_3X2_F to a Matrix3x2.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <returns>
    /// A Matrix3x2.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static Matrix3x2 ToMatrix3x2(this D2D_MATRIX_3X2_F matrix) => Unsafe.As<D2D_MATRIX_3X2_F, Matrix3x2>(ref matrix);

    /// <summary>
    /// Converts a Matrix3x2 to a D2D_MATRIX_3X2_F.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <returns>
    /// A D2D_MATRIX_3X2_F.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static D2D_MATRIX_3X2_F ToD2D_MATRIX_3X2_F(this Matrix3x2 matrix) => Unsafe.As<Matrix3x2, D2D_MATRIX_3X2_F>(ref matrix);

    /// <summary>
    /// Converts a DWRITE_MATRIX to a Matrix3x2.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <returns>
    /// A Matrix3x2.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static Matrix3x2 ToMatrix3x2(this DWRITE_MATRIX matrix) => Unsafe.As<DWRITE_MATRIX, Matrix3x2>(ref matrix);

    /// <summary>
    /// Converts a Matrix3x2 to a DWRITE_MATRIX.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <returns>
    /// A DWRITE_MATRIX.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static DWRITE_MATRIX ToDWRITE_MATRIX(this Matrix3x2 matrix) => Unsafe.As<Matrix3x2, DWRITE_MATRIX>(ref matrix);

    /// <summary>
    /// Converts a D2D_MATRIX_3X2_F to a DWRITE_MATRIX.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <returns>
    /// A DWRITE_MATRIX.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static DWRITE_MATRIX ToDWRITE_MATRIX(this D2D_MATRIX_3X2_F matrix) => Unsafe.As<D2D_MATRIX_3X2_F, DWRITE_MATRIX>(ref matrix);

    /// <summary>
    /// Converts a DWRITE_MATRIX to a D2D_MATRIX_3X2_F.
    /// </summary>
    /// <param name="matrix">The matrix.</param>
    /// <returns>
    /// A D2D_MATRIX_3X2_F.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    // Using TTo As<TFrom, TTo>(ref TFrom source) to do the direct cast because the structures are the same shape and can be blited interchangeably.
    public static D2D_MATRIX_3X2_F ToD2D_MATRIX_3X2_F(this DWRITE_MATRIX matrix) => Unsafe.As<DWRITE_MATRIX, D2D_MATRIX_3X2_F>(ref matrix);
    #endregion
}
