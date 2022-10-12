// <copyright file="FriendlyOverloadExtensions.cs" company="Shkyrockett" >
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
using System.Runtime.Versioning;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;
using Windows.Win32.Graphics.Gdi;

namespace Windows.Win32
{
    /// <summary>
    /// The friendly overload extensions.
    /// </summary>
    public static partial class FriendlyOverloadExtensions
    {
        #region Factory Shims
        /// <summary>
        /// Creates a render target for interacting with a device context.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="renderTargetProperties">The render target properties.</param>
        /// <returns>An ID2D1DCRenderTarget.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1DCRenderTarget CreateDCRenderTarget(this ID2D1Factory factory, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
        {
            fixed (D2D1_RENDER_TARGET_PROPERTIES* p = &renderTargetProperties)
            {
                factory.CreateDCRenderTarget(p, out var hwndRenderTarget);
                return hwndRenderTarget;
            }
        }

        /// <summary>
        /// Creates a render target for interacting with a windows handle.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="renderTargetProperties">The render target properties.</param>
        /// <param name="hwndRenderTargetProperties">The hwnd render target properties.</param>
        /// <returns>An ID2D1HwndRenderTarget.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1HwndRenderTarget CreateHwndRenderTarget(this ID2D1Factory factory, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties)
        {
            fixed (D2D1_RENDER_TARGET_PROPERTIES* p = &renderTargetProperties)
            fixed (D2D1_HWND_RENDER_TARGET_PROPERTIES* h = &hwndRenderTargetProperties)
            {
                factory.CreateHwndRenderTarget(p, h, out var hwndRenderTarget);
                return hwndRenderTarget;
            }
        }

        /// <summary>
        /// Creates a stroke style.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="strokeStyleProperties">The stroke style properties.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1StrokeStyle CreateStrokeStyle(this ID2D1Factory factory, in D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties)
        {
            fixed (D2D1_STROKE_STYLE_PROPERTIES* s = &strokeStyleProperties)
            {
                factory.CreateStrokeStyle(s, null, 0, out var strokeStyle);
                return strokeStyle;
            }
        }

        /// <summary>
        /// Creates a text format.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="fontFamilyName">The font family name.</param>
        /// <param name="fontWeight">The font weight.</param>
        /// <param name="fontStyle">The font style.</param>
        /// <param name="fontStretch">The font stretch.</param>
        /// <param name="fontSize">The font size.</param>
        /// <param name="localeName">The locale name.</param>
        /// <returns>An IDWriteTextFormat.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe IDWriteTextFormat CreateTextFormat(this IDWriteFactory factory, string fontFamilyName, DWRITE_FONT_WEIGHT fontWeight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL, DWRITE_FONT_STYLE fontStyle = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL, DWRITE_FONT_STRETCH fontStretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL, float fontSize = 12.0f, string? localeName = null)
        {
            factory.CreateTextFormat(fontFamilyName, fontCollection: null, fontWeight, fontStyle, fontStretch, fontSize, localeName ?? CultureInfo.CurrentCulture.Name, out var textLayout);
            return textLayout;
        }

        /// <summary>
        /// Creates a text layout.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="text">The text.</param>
        /// <param name="textFormat">The text format.</param>
        /// <param name="maxSize">The max size.</param>
        /// <returns>An IDWriteTextLayout.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe IDWriteTextLayout CreateTextLayout(this IDWriteFactory factory, ReadOnlySpan<char> text, IDWriteTextFormat? textFormat, SizeF? maxSize)
        {
            fixed (char* c = &MemoryMarshal.GetReference(text))
            {
                factory.CreateTextLayout(c, (uint)text.Length, textFormat, maxSize?.Width ?? default, maxSize?.Height ?? default, out var textLayout);
                return textLayout;
            }
        }

        /// <summary>
        /// Creates a text layout.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <param name="text">The text.</param>
        /// <param name="textFormat">The text format.</param>
        /// <param name="maxSize">The max size.</param>
        /// <returns>An IDWriteTextLayout.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe IDWriteTextLayout CreateTextLayout(this IDWriteFactory factory, ReadOnlySpan<char> text, IDWriteTextFormat? textFormat, D2D_SIZE_F? maxSize)
        {
            fixed (char* c = &MemoryMarshal.GetReference(text))
            {
                factory.CreateTextLayout(c, (uint)text.Length, textFormat, maxSize?.width ?? default, maxSize?.height ?? default, out var textLayout);
                return textLayout;
            }
        }

        /// <summary>
        /// Creates a typography.
        /// </summary>
        /// <param name="factory">The factory.</param>
        /// <returns>An IDWriteTypography.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe IDWriteTypography CreateTypography(this IDWriteFactory factory)
        {
            factory.CreateTypography(out var typography);
            return typography;
        }
        #endregion
    }
}
