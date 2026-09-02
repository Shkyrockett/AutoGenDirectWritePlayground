// <copyright file="FriendlyOverloadExtensions.RenderTargetHelpers.cs" company="Shkyrockett" >
// Copyright © 2020 - 2025 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.Gdi;

namespace Windows.Win32;

/// <summary>
/// The friendly overload extensions.
/// </summary>
public static partial class FriendlyOverloadExtensions
{
    extension<T>(T renderTarget) where T : ID2D1DCRenderTarget
    {
        #region BindDC
        /// <summary>
        /// Binds a renter target to a specified device context.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="graphics">The graphics.</param>
        /// <param name="rectangle">The rectangle.</param>
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT BindDC(global::System.Drawing.Graphics graphics, Rectangle rectangle)
            => BindDC(renderTarget, graphics, rectangle.ToRECT());

        /// <summary>
        /// Binds a renter target to a specified device context.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="graphics">The graphics.</param>
        /// <param name="rectangle">The rectangle.</param>
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HRESULT BindDC(global::System.Drawing.Graphics graphics, RECT rectangle)
        {
            HDC hdc = new(graphics.GetHdc());
            var hr = renderTarget.BindDC(hdc, rectangle);
            graphics.ReleaseHdc(hdc); // Remember to clean up borrowed DC handle.
            return hr;
        }
        #endregion
    }

    extension<T>(T renderTarget) where T : ID2D1RenderTarget
    {
        #region CreateRadialGradientBrush
        /// <summary>
        /// Creates the radial gradient brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="radialBrushProperties">The radial brush properties.</param>
        /// <param name="gradientStops">The gradient stops.</param>
        /// <returns>
        /// An ID2D1Brush.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1Brush? TryCreateRadialGradientBrush(in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialBrushProperties, ID2D1GradientStopCollection gradientStops)
            => renderTarget.CreateRadialGradientBrush(radialBrushProperties, null, gradientStops, out var gradientBrush).Succeeded ? gradientBrush : (ID2D1Brush?)default;

        /// <summary>
        /// Creates the radial gradient brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="radialBrushProperties">The radial brush properties.</param>
        /// <param name="brushProperties">The brush properties.</param>
        /// <param name="gradientStops">The gradient stops.</param>
        /// <returns>
        /// An ID2D1Brush.
        /// </returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1Brush? TryCreateRadialGradientBrush(in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialBrushProperties, in D2D1_BRUSH_PROPERTIES brushProperties, ID2D1GradientStopCollection gradientStops)
            => renderTarget.CreateRadialGradientBrush(radialBrushProperties, brushProperties, gradientStops, out var gradientBrush).Succeeded ? gradientBrush : (ID2D1Brush?)default;
        #endregion

        #region CreateSolidColorBrush
        /// <summary>
        /// Creates a solid color brush with a specified color.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1SolidColorBrush? TryCreateSolidColorBrush(in Color color)
            => TryCreateSolidColorBrush(renderTarget, color.ToD2D1_COLOR_F());

        /// <summary>
        /// Creates a solid color brush with a specified color.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1SolidColorBrush? TryCreateSolidColorBrush(in D2D1_COLOR_F color)
            => renderTarget.CreateSolidColorBrush(color, null, out var solidColorBrush).Succeeded ? solidColorBrush : default;

        /// <summary>
        /// Creates a solid color brush with a specified color and properties.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <param name="properties">The properties.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1SolidColorBrush? TryCreateSolidColorBrush(in Color color, in D2D1_BRUSH_PROPERTIES properties)
            => TryCreateSolidColorBrush(renderTarget, color.ToD2D1_COLOR_F(), properties);

        /// <summary>
        /// Creates a solid color brush with a specified color and properties.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <param name="properties">The properties.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ID2D1SolidColorBrush? TryCreateSolidColorBrush(in D2D1_COLOR_F color, in D2D1_BRUSH_PROPERTIES properties)
            => renderTarget.CreateSolidColorBrush(color, properties, out var solidColorBrush).Succeeded ? solidColorBrush : default;
        #endregion

        #region SetTransform
        /// <summary>
        /// Sets the transform.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <inheritdoc cref="ID2D1RenderTarget.SetTransform(D2D_MATRIX_3X2_F*)" />
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SetTransform()
            => renderTarget.SetTransform((D2D_MATRIX_3X2_F)Matrix3x2.Identity);
        #endregion
    }
}
