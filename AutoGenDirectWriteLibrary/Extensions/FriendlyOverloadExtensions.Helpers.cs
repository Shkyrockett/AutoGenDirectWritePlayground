// <copyright file="FriendlyOverloadExtensions.RenderTargetHelpers.cs" company="Shkyrockett" >
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
        #region Clear
        /// <summary>
        /// Clears the specified render target.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1RenderTarget renderTarget) => renderTarget.Clear(null);

        /// <summary>
        /// Clears the specified render target with a color.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1RenderTarget renderTarget, in Color color) => Clear(renderTarget, color.ToD2D1_COLOR_F());

        /// <inheritdoc cref="ID2D1BitmapRenderTarget.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1BitmapRenderTarget @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1RenderTarget.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1RenderTarget @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1HwndRenderTarget.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1HwndRenderTarget @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DCRenderTarget.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DCRenderTarget @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DeviceContext.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows8.0")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DeviceContext @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DeviceContext1.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows8.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DeviceContext1 @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DeviceContext2.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DeviceContext2 @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DeviceContext3.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DeviceContext3 @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DeviceContext4.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DeviceContext4 @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DeviceContext5.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DeviceContext5 @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }

        /// <inheritdoc cref="ID2D1DeviceContext6.Clear(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*)" />
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void Clear(this ID2D1DeviceContext6 @this, D2D1_COLOR_F? clearColor)
        {
            var clearColorLocal = clearColor.HasValue ? clearColor.Value : default;
            @this.Clear(clearColor.HasValue ? (&clearColorLocal) : null);
        }
        #endregion

        #region CreateGradientStopCollection
        /// <summary>
        /// Creates the gradient stop collection.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="gradientStops">The gradient stops.</param>
        /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
        /// <param name="extendMode">The extend mode.</param>
        /// <returns>An ID2D1GradientStopCollection.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1GradientStopCollection CreateGradientStopCollection(this ID2D1RenderTarget renderTarget, in D2D1_GRADIENT_STOP[] gradientStops, D2D1_GAMMA colorInterpolationGamma = D2D1_GAMMA.D2D1_GAMMA_2_2, D2D1_EXTEND_MODE extendMode = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP)
        {
            fixed (D2D1_GRADIENT_STOP* s = gradientStops)
            {
                renderTarget.CreateGradientStopCollection(s, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out var gradientStopCollection);
                return gradientStopCollection;
            }
        }

        /// <summary>
        /// Creates the gradient stop collection.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="gradientStops">The gradient stops.</param>
        /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
        /// <param name="extendMode">The extend mode.</param>
        /// <returns>An ID2D1GradientStopCollection.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1GradientStopCollection CreateGradientStopCollection(this ID2D1RenderTarget renderTarget, in ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma = D2D1_GAMMA.D2D1_GAMMA_2_2, D2D1_EXTEND_MODE extendMode = D2D1_EXTEND_MODE.D2D1_EXTEND_MODE_CLAMP)
        {
            fixed (D2D1_GRADIENT_STOP* s = gradientStops)
            {
                renderTarget.CreateGradientStopCollection(s, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out var gradientStopCollection);
                return gradientStopCollection;
            }
        }
        #endregion

        #region CreateRadialGradientBrush
        /// <summary>
        /// Creates the radial gradient brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="radialBrushProperties">The radial brush properties.</param>
        /// <param name="gradientStops">The gradient stops.</param>
        /// <returns>An ID2D1Brush.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Brush CreateRadialGradientBrush(this ID2D1RenderTarget renderTarget, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialBrushProperties, ID2D1GradientStopCollection gradientStops)
        {
            fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* r = &radialBrushProperties)
            {
                renderTarget.CreateRadialGradientBrush(r, null, gradientStops, out var gradientBrush);
                return gradientBrush;
            }
        }

        /// <summary>
        /// Creates the radial gradient brush.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="radialBrushProperties">The radial brush properties.</param>
        /// <param name="brushProperties"></param>
        /// <param name="gradientStops">The gradient stops.</param>
        /// <returns>An ID2D1Brush.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1Brush CreateRadialGradientBrush(this ID2D1RenderTarget renderTarget, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialBrushProperties, in D2D1_BRUSH_PROPERTIES brushProperties, ID2D1GradientStopCollection gradientStops)
        {
            fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* r = &radialBrushProperties)
            fixed (D2D1_BRUSH_PROPERTIES* b = &brushProperties)
            {
                renderTarget.CreateRadialGradientBrush(r, b, gradientStops, out var gradientBrush);
                return gradientBrush;
            }
        }
        #endregion

        #region CreateSolidColorBrush
        /// <summary>
        /// Creates a solid color brush with a specified color.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in Color color) => CreateSolidColorBrush(renderTarget, color.ToD2D1_COLOR_F());

        /// <summary>
        /// Creates a solid color brush with a specified color.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in D2D1_COLOR_F color)
        {
            fixed (D2D1_COLOR_F* c = &color)
            {
                renderTarget.CreateSolidColorBrush(c, null, out var solidColorBrush);
                return solidColorBrush;
            }
        }

        /// <summary>
        /// Creates a solid color brush with a specified color and properties.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <param name="properties">The properties.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in Color color, in D2D1_BRUSH_PROPERTIES properties) => CreateSolidColorBrush(renderTarget, color.ToD2D1_COLOR_F(), properties);

        /// <summary>
        /// Creates a solid color brush with a specified color and properties.
        /// </summary>
        /// <param name="renderTarget">The render target.</param>
        /// <param name="color">The color.</param>
        /// <param name="properties">The properties.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ID2D1SolidColorBrush CreateSolidColorBrush(this ID2D1RenderTarget renderTarget, in D2D1_COLOR_F color, in D2D1_BRUSH_PROPERTIES properties)
        {
            fixed (D2D1_COLOR_F* c = &color)
            fixed (D2D1_BRUSH_PROPERTIES* p = &properties)
            {
                renderTarget.CreateSolidColorBrush(c, p, out var solidColorBrush);
                return solidColorBrush;
            }
        }
        #endregion

        #region SetTransform
        /// <inheritdoc cref="ID2D1BitmapRenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1BitmapRenderTarget @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1RenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1RenderTarget @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1HwndRenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1HwndRenderTarget @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DCRenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows6.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DCRenderTarget @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DeviceContext.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows8.0")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DeviceContext @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DeviceContext1.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows8.1")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DeviceContext1 @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DeviceContext2.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DeviceContext2 @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DeviceContext3.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DeviceContext3 @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DeviceContext4.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DeviceContext4 @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DeviceContext5.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DeviceContext5 @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }

        /// <inheritdoc cref="ID2D1DeviceContext6.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)"/>
        [SupportedOSPlatform("windows10.0.10240")]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void SetTransform(this ID2D1DeviceContext6 @this)
        {
            var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
            @this.SetTransform(&identity);
        }
        #endregion
    }
}
