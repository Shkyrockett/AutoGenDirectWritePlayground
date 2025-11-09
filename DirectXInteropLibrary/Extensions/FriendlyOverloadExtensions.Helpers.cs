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
using System.Runtime.InteropServices;
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
    #region BindDC
    /// <summary>
    /// Binds the dc.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="hDC">The h dc.</param>
    /// <param name="pSubRect">The p sub rect.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.BindDC(HDC, Windows.Win32.Foundation.RECT*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void BindDC(this ID2D1DCRenderTarget @this, HDC hDC, in RECT pSubRect)
    {
        fixed (RECT* pSubRectLocal = &pSubRect)
        {
            @this.BindDC(hDC, pSubRectLocal);
        }
    }

    /// <summary>
    /// Binds the dc.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="hDC">The h dc.</param>
    /// <param name="pSubRect">The p sub rect.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.BindDC(HDC, Windows.Win32.Foundation.RECT*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void BindDC(this ID2D1DCRenderTarget @this, SafeHandle hDC, in RECT pSubRect)
    {
        var hDCAddRef = false;
        try
        {
            fixed (RECT* pSubRectLocal = &pSubRect)
            {
                HDC hDCLocal;
                if (hDC is not null)
                {
                    hDC.DangerousAddRef(ref hDCAddRef);
                    hDCLocal = (HDC)hDC.DangerousGetHandle();
                }
                else
                    hDCLocal = default;
                @this.BindDC(hDCLocal, pSubRectLocal);
            }
        }
        finally
        {
            if (hDCAddRef)
                hDC.DangerousRelease();
        }
    }

    /// <summary>
    /// Binds a renter target to a specified device context.
    /// </summary>
    /// <param name="renderTarget">The render target.</param>
    /// <param name="graphics">The graphics.</param>
    /// <param name="rectangle">The rectangle.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void BindDC(this ID2D1DCRenderTarget renderTarget, global::System.Drawing.Graphics graphics, Rectangle rectangle) => BindDC(renderTarget, graphics, rectangle.ToRECT());

    /// <summary>
    /// Binds a renter target to a specified device context.
    /// </summary>
    /// <param name="renderTarget">The render target.</param>
    /// <param name="graphics">The graphics.</param>
    /// <param name="rectangle">The rectangle.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void BindDC(this ID2D1DCRenderTarget renderTarget, global::System.Drawing.Graphics graphics, RECT rectangle)
    {
        HDC hdc = new(graphics.GetHdc());
        renderTarget.BindDC(hdc, &rectangle);
        graphics.ReleaseHdc(hdc); // Remember to clean up borrowed DC handle.
    }
    #endregion


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
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <returns>
    /// An ID2D1Brush.
    /// </returns>
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
    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1BitmapRenderTarget @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1RenderTarget @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1HwndRenderTarget @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DCRenderTarget @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext1 @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext2 @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext3 @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext4 @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext5 @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.SetTransform(D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext6 @this)
    {
        var identity = (D2D_MATRIX_3X2_F)Matrix3x2.Identity;
        @this.SetTransform(&identity);
    }
    #endregion
}
