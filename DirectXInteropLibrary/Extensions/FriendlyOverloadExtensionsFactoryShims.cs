// <copyright file="FriendlyOverloadExtensions.cs" company="Shkyrockett" >
// Copyright © 2020 - 2025 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;

namespace Windows.Win32;

/// <summary>
/// The friendly overload extensions.
/// </summary>
public static partial class FriendlyOverloadExtensions
{
    extension<F>(F factory) where F : ID2D1Factory
    {
        #region Factory Shims
        /// <summary>
        /// Creates a render target for interacting with a device context.
        /// </summary>
        /// <param name="renderTargetProperties">The render target properties.</param>
        /// <returns>
        /// An ID2D1DCRenderTarget.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1DCRenderTarget? TryCreateDCRenderTarget(ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
            => factory.CreateDCRenderTarget(renderTargetProperties, out ID2D1DCRenderTarget? dcRenderTarget).Succeeded ? dcRenderTarget : default;

        /// <summary>
        /// Creates a render target for interacting with a windows handle.
        /// </summary>
        /// <param name="renderTargetProperties">The render target properties.</param>
        /// <param name="hwndRenderTargetProperties">The hwnd render target properties.</param>
        /// <returns>
        /// An ID2D1HwndRenderTarget.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1HwndRenderTarget? TryCreateHwndRenderTarget(ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties)
            => factory.CreateHwndRenderTarget(renderTargetProperties, hwndRenderTargetProperties, out ID2D1HwndRenderTarget? hwndRenderTarget).Succeeded ? hwndRenderTarget : default;

        /// <summary>
        /// Creates a stroke style.
        /// </summary>
        /// <param name="strokeStyleProperties">The stroke style properties.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1StrokeStyle? TryCreateStrokeStyle(in D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties)
            => factory.CreateStrokeStyle(strokeStyleProperties, null, out ID2D1StrokeStyle? strokeStyle).Succeeded ? strokeStyle : default;

        /// <summary>
        /// Creates a stroke style.
        /// </summary>
        /// <param name="strokeStyleProperties">The stroke style properties.</param>
        /// <param name="dashes">The dashes.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1StrokeStyle? TryCreateStrokeStyle(in D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, ReadOnlySpan<float> dashes)
            => factory.CreateStrokeStyle(strokeStyleProperties, dashes, out ID2D1StrokeStyle strokeStyle).Succeeded ? strokeStyle : default;
    }

    extension<F>(F factory) where F : IDWriteFactory
    {
        /// <summary>
        /// Creates a text format.
        /// </summary>
        /// <param name="fontFamilyName">The font family name.</param>
        /// <param name="fontWeight">The font weight.</param>
        /// <param name="fontStyle">The font style.</param>
        /// <param name="fontStretch">The font stretch.</param>
        /// <param name="fontSize">The font size.</param>
        /// <param name="localeName">The locale name.</param>
        /// <returns>
        /// An IDWriteTextFormat.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public IDWriteTextFormat? TryCreateTextFormat(string fontFamilyName, DWRITE_FONT_WEIGHT fontWeight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL, DWRITE_FONT_STYLE fontStyle = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL, DWRITE_FONT_STRETCH fontStretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL, float fontSize = 12.0f, string? localeName = null)
            => factory.CreateTextFormat(fontFamilyName, fontCollection: null, fontWeight, fontStyle, fontStretch, fontSize, localeName ?? CultureInfo.CurrentCulture.Name, out IDWriteTextFormat? textLayout).Succeeded ? textLayout : default;

        /// <summary>
        /// Creates a text layout.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="textFormat">The text format.</param>
        /// <param name="maxSize">The max size.</param>
        /// <returns>
        /// An IDWriteTextLayout.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public IDWriteTextLayout? TryCreateTextLayout(string text, IDWriteTextFormat? textFormat, SizeF? maxSize)
            => factory.CreateTextLayout(text, (uint)text.Length, textFormat, maxSize?.Width ?? default, maxSize?.Height ?? default, out IDWriteTextLayout? textLayout).Succeeded ? textLayout : default;

        /// <summary>
        /// Creates a text layout.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="textFormat">The text format.</param>
        /// <param name="maxSize">The max size.</param>
        /// <returns>
        /// An IDWriteTextLayout.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public IDWriteTextLayout? TryCreateTextLayout(string text, IDWriteTextFormat? textFormat, D2D_SIZE_F? maxSize)
            => factory.CreateTextLayout(text, (uint)text.Length, textFormat, maxSize?.width ?? default, maxSize?.height ?? default, out IDWriteTextLayout? textLayout).Succeeded ? textLayout : default;

        /// <summary>
        /// Creates a typography.
        /// </summary>
        /// <returns>
        /// An IDWriteTypography.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public IDWriteTypography? TryCreateTypography()
            => factory.CreateTypography(out IDWriteTypography? typography).Succeeded ? typography : default;
     #endregion
   }
}
