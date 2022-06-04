// <copyright file="Extensions.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;

namespace AutoGenDirectWriteLibrary
{
    /// <summary>
    /// The extensions.
    /// </summary>
    public static partial class Extensions
    {
        /// <summary>
        /// Binds the d c.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="graphics">The graphics.</param>
        /// <param name="rectangle">The rectangle.</param>
        public unsafe static void BindDC(this ID2D1DCRenderTarget renderTarget, Graphics graphics, Rectangle rectangle) => BindDC(renderTarget, graphics, rectangle.ToD2D_RECT());

        /// <summary>
        /// Binds the d c.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="graphics">The graphics.</param>
        /// <param name="rectangle">The rectangle.</param>
        public unsafe static void BindDC(this ID2D1DCRenderTarget renderTarget, Graphics graphics, Windows.Win32.Foundation.RECT rectangle)
        {
            var t = new Windows.Win32.Graphics.Gdi.HDC(graphics.GetHdc());
            renderTarget.BindDC(t, &rectangle);
        }

        /// <summary>
        /// Creates the stroke style.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="strokeStyleProperties">The stroke style properties.</param>
        /// <returns></returns>
        public unsafe static ID2D1StrokeStyle CreateStrokeStyle(this ID2D1Factory factory, in D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties)
        {
            fixed (D2D1_STROKE_STYLE_PROPERTIES* s = &strokeStyleProperties)
            {
                factory.CreateStrokeStyle(s, null, 0, out var strokeStyle);
                return strokeStyle;
            }
        }

        /// <summary>
        /// Creates the d c render target.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="renderTargetProperties">The render target properties.</param>
        /// <returns>An ID2D1DCRenderTarget.</returns>
        public unsafe static ID2D1DCRenderTarget CreateDCRenderTarget(this ID2D1Factory factory, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
        {
            fixed (D2D1_RENDER_TARGET_PROPERTIES* p = &renderTargetProperties)
            {
                factory.CreateDCRenderTarget(p, out var hwndRenderTarget);
                return hwndRenderTarget;
            }
        }

        /// <summary>
        /// Creates the hwnd render target.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="renderTargetProperties">The render target properties.</param>
        /// <param name="hwndRenderTargetProperties">The hwnd render target properties.</param>
        /// <returns>An ID2D1HwndRenderTarget.</returns>
        public unsafe static ID2D1HwndRenderTarget CreateHwndRenderTarget(this ID2D1Factory factory, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties)
        {
            fixed (D2D1_RENDER_TARGET_PROPERTIES* p = &renderTargetProperties)
            fixed (D2D1_HWND_RENDER_TARGET_PROPERTIES* h = &hwndRenderTargetProperties)
            {
                factory.CreateHwndRenderTarget(p, h, out var hwndRenderTarget);
                return hwndRenderTarget;
            }
        }

        /// <summary>
        /// Creates the text layout.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="text">The text.</param>
        /// <param name="textFormat">The text format.</param>
        /// <param name="maxSize">The max size.</param>
        /// <returns>An IDWriteTextLayout.</returns>
        public unsafe static IDWriteTextLayout CreateTextLayout(this IDWriteFactory factory, ReadOnlySpan<char> text, IDWriteTextFormat? textFormat, SizeF? maxSize)
        {
            fixed (char* c = &MemoryMarshal.GetReference(text))
            {
                factory.CreateTextLayout(c, (uint)text.Length, textFormat, maxSize?.Width ?? default, maxSize?.Height ?? default, out var textLayout);
                return textLayout;
            }
        }

        /// <summary>
        /// Creates the text layout.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="text">The text.</param>
        /// <param name="textFormat">The text format.</param>
        /// <param name="maxSize">The max size.</param>
        /// <returns>An IDWriteTextLayout.</returns>
        public unsafe static IDWriteTextLayout CreateTextLayout(this IDWriteFactory factory, ReadOnlySpan<char> text, IDWriteTextFormat? textFormat, D2D_SIZE_F? maxSize)
        {
            fixed (char* c = &MemoryMarshal.GetReference(text))
            {
                factory.CreateTextLayout(c, (uint)text.Length, textFormat, maxSize?.width ?? default, maxSize?.height ?? default, out var textLayout);
                return textLayout;
            }
        }

        /// <summary>
        /// Creates the text format.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="fontFamilyName">The font family name.</param>
        /// <param name="fontWeight">The font weight.</param>
        /// <param name="fontStyle">The font style.</param>
        /// <param name="fontStretch">The font stretch.</param>
        /// <param name="fontSize">The font size.</param>
        /// <param name="localeName">The locale name.</param>
        /// <returns>An IDWriteTextFormat.</returns>
        public unsafe static IDWriteTextFormat CreateTextFormat(this IDWriteFactory factory, string fontFamilyName, DWRITE_FONT_WEIGHT fontWeight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL, DWRITE_FONT_STYLE fontStyle = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL, DWRITE_FONT_STRETCH fontStretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL, float fontSize = 12.0f, string? localeName = null)
        {
            factory.CreateTextFormat(fontFamilyName, fontCollection: null, fontWeight, fontStyle, fontStretch, fontSize, localeName ?? CultureInfo.CurrentCulture.Name, out var textLayout);
            return textLayout;
        }

        /// <summary>
        /// Creates the typography.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <returns>An IDWriteTypography.</returns>
        public unsafe static IDWriteTypography CreateTypography(this IDWriteFactory factory)
        {
            factory.CreateTypography(out IDWriteTypography typography);
            return typography;
        }

        /// <summary>
        /// Tos the d2 d_ p o i n t_ f.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>A D2D_POINT_2F.</returns>
        public static D2D_POINT_2F ToD2D_POINT_F(this Vector2 vector) => Unsafe.As<Vector2, D2D_POINT_2F>(ref vector);

        /// <summary>
        /// Tos the vector2.
        /// </summary>
        /// <param name="vector">The vector.</param>
        /// <returns>A Vector2.</returns>
        public static Vector2 ToVector2(this D2D_POINT_2F vector) => Unsafe.As<D2D_POINT_2F, Vector2>(ref vector);

        /// <summary>
        /// Tos the d2 d_ p o i n t_2 f.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>A D2D_POINT_2F.</returns>
        public static D2D_POINT_2F ToD2D_POINT_2F(this PointF point) => Unsafe.As<PointF, D2D_POINT_2F>(ref point);

        /// <summary>
        /// Tos the point f.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>A PointF.</returns>
        public static PointF ToPointF(this D2D_POINT_2F point) => Unsafe.As<D2D_POINT_2F, PointF>(ref point);

        /// <summary>
        /// Tos the d2 d_ p o i n t_2 u.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>A D2D_POINT_2U.</returns>
        public static D2D_POINT_2U ToD2D_POINT_2U(this Point point) => Unsafe.As<Point, D2D_POINT_2U>(ref point);

        /// <summary>
        /// Tos the point.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns>A Point.</returns>
        public static Point ToPoint(this D2D_POINT_2U point) => Unsafe.As<D2D_POINT_2U, Point>(ref point);

        /// <summary>
        /// Tos the d2 d_ s i z e_ f.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns>A D2D_SIZE_F.</returns>
        public static D2D_SIZE_F ToD2D_SIZE_F(this SizeF size) => Unsafe.As<SizeF, D2D_SIZE_F>(ref size);

        /// <summary>
        /// Tos the size f.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns>A SizeF.</returns>
        public static SizeF ToSizeF(this D2D_SIZE_F size) => Unsafe.As<D2D_SIZE_F, SizeF>(ref size);

        /// <summary>
        /// Tos the d2 d_ s i z e_ u.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns>A D2D_SIZE_U.</returns>
        public static D2D_SIZE_U ToD2D_SIZE_U(this Size size) => Unsafe.As<Size, D2D_SIZE_U>(ref size);

        /// <summary>
        /// Tos the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns>A Size.</returns>
        public static Size ToSize(this D2D_SIZE_U size) => Unsafe.As<D2D_SIZE_U, Size>(ref size);

        /// <summary>
        /// Tos the d2 d1_ c o l o r_ f.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>A D2D1_COLOR_F.</returns>
        public static D2D1_COLOR_F ToD2D1_COLOR_F(this Color color) => new() { r = color.R / 255.0f, g = color.G / 255.0f, b = color.B / 255.0f, a = color.A / 255.0f };

        /// <summary>
        /// Tos the color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns>A Color.</returns>
        public static Color ToColor(this D2D1_COLOR_F color) => Color.FromArgb((int)(color.a * 255), (int)(color.r * 255), (int)(color.g * 255), (int)(color.b * 255));

        /// <summary>
        /// Tos the d2 d_ r e c t_ f.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>A D2D_RECT_F.</returns>
        public static D2D_RECT_F ToD2D_RECT_F(this RectangleF rect) => new() { left = rect.Left, top = rect.Top, right = rect.Right, bottom = rect.Bottom };

        /// <summary>
        /// Tos the d2 d_ r e c t_ f.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>A RectangleF.</returns>
        public static RectangleF ToD2D_RECT_F(this D2D_RECT_F rect) => RectangleF.FromLTRB(rect.left, rect.top, rect.right, rect.bottom);

        /// <summary>
        /// Tos the d2 d_ r e c t_ f.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>A D2D_RECT_U.</returns>
        public static D2D_RECT_U ToD2D_RECT_F(this Rectangle rect) => new() { left = (uint)rect.Left, top = (uint)rect.Top, right = (uint)rect.Right, bottom = (uint)rect.Bottom };

        /// <summary>
        /// Tos the d2 d_ r e c t_ u.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>A Rectangle.</returns>
        public static Rectangle ToD2D_RECT_U(this D2D_RECT_U rect) => Rectangle.FromLTRB((int)rect.left, (int)rect.top, (int)rect.right, (int)rect.bottom);

        /// <summary>
        /// Tos the d2 d_ r e c t.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>A Windows.Win32.Foundation.RECT.</returns>
        public static Windows.Win32.Foundation.RECT ToD2D_RECT(this Rectangle rect) => new() { left = rect.Left, top = rect.Top, right = rect.Right, bottom = rect.Bottom };

        /// <summary>
        /// Tos the matrix3x2.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>A Matrix3x2.</returns>
        public static Matrix3x2 ToMatrix3x2(this D2D_MATRIX_3X2_F matrix) => Unsafe.As<D2D_MATRIX_3X2_F, Matrix3x2>(ref matrix);

        /// <summary>
        /// Tos the d2 d_ m a t r i x_3 x2_ f.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>A D2D_MATRIX_3X2_F.</returns>
        public static D2D_MATRIX_3X2_F ToD2D_MATRIX_3X2_F(this Matrix3x2 matrix) => Unsafe.As<Matrix3x2, D2D_MATRIX_3X2_F>(ref matrix);

        /// <summary>
        /// Tos the matrix3x2.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>A Matrix3x2.</returns>
        public static Matrix3x2 ToMatrix3x2(this DWRITE_MATRIX matrix) => Unsafe.As<DWRITE_MATRIX, Matrix3x2>(ref matrix);

        /// <summary>
        /// Tos the d w r i t e_ m a t r i x.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>A DWRITE_MATRIX.</returns>
        public static DWRITE_MATRIX ToDWRITE_MATRIX(this Matrix3x2 matrix) => Unsafe.As<Matrix3x2, DWRITE_MATRIX>(ref matrix);

        /// <summary>
        /// Tos the d w r i t e_ m a t r i x.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>A DWRITE_MATRIX.</returns>
        public static DWRITE_MATRIX ToDWRITE_MATRIX(this D2D_MATRIX_3X2_F matrix) => Unsafe.As<D2D_MATRIX_3X2_F, DWRITE_MATRIX>(ref matrix);

        /// <summary>
        /// Tos the d2 d_ m a t r i x_3 x2_ f.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <returns>A D2D_MATRIX_3X2_F.</returns>
        public static D2D_MATRIX_3X2_F ToD2D_MATRIX_3X2_F(this DWRITE_MATRIX matrix) => Unsafe.As<DWRITE_MATRIX, D2D_MATRIX_3X2_F>(ref matrix);

        /// <summary>
        /// Sets the max size.
        /// </summary>
        /// <param name="textLayout">The text layout.</param>
        /// <param name="maxSize">The max size.</param>
        public static void SetMaxSize(this IDWriteTextLayout textLayout, SizeF maxSize)
        {
            textLayout.SetMaxHeight(maxSize.Height);
            textLayout.SetMaxWidth(maxSize.Width);
        }

        /// <summary>
        /// Creates the solid color brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        public unsafe static ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in Color color) => CreateSolidColorBrush(renderTarget, color.ToD2D1_COLOR_F());

        /// <summary>
        /// Creates the solid color brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        public unsafe static ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in D2D1_COLOR_F color)
        {
            fixed (D2D1_COLOR_F* c = &color)
            {
                renderTarget.CreateSolidColorBrush(c, null, out var solidColorBrush);
                return solidColorBrush;
            }
        }

        /// <summary>
        /// Creates the solid color brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <param name="properties">The properties.</param>
        /// <returns></returns>
        public unsafe static ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in Color color, in D2D1_BRUSH_PROPERTIES properties) => CreateSolidColorBrush(renderTarget, color.ToD2D1_COLOR_F(), properties);

        /// <summary>
        /// Creates the solid color brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <param name="properties">The properties.</param>
        /// <returns></returns>
        public unsafe static ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in D2D1_COLOR_F color, in D2D1_BRUSH_PROPERTIES properties)
        {
            fixed (D2D1_COLOR_F* c = &color)
            fixed (D2D1_BRUSH_PROPERTIES* p = &properties)
            {
                renderTarget.CreateSolidColorBrush(c, p, out var solidColorBrush);
                return solidColorBrush;
            }
        }

        /// <summary>
        /// Clears the specified render target.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        public unsafe static void Clear(this ID2D1RenderTarget renderTarget) => renderTarget.Clear(null);

        /// <summary>
        /// Clears the specified color.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        public unsafe static void Clear(this ID2D1RenderTarget renderTarget, in Color color)
        {
            Clear(renderTarget, color.ToD2D1_COLOR_F());
        }

        /// <summary>
        /// Clears the specified color.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        public unsafe static void Clear(this ID2D1RenderTarget renderTarget, in D2D1_COLOR_F color)
        {
            fixed (D2D1_COLOR_F* c = &color) renderTarget.Clear(c);
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <returns></returns>
        public static SizeF GetSize(this ID2D1RenderTarget renderTarget)
        {
            renderTarget.GetSize(out var size);
            return size.ToSizeF();
        }

        /// <summary>
        /// Set the transform to identity.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        public unsafe static void SetTransform(this ID2D1RenderTarget renderTarget)
        {
            var identity = Matrix3x2.Identity.ToD2D_MATRIX_3X2_F();
            renderTarget.SetTransform(&identity);
        }
    }
}
