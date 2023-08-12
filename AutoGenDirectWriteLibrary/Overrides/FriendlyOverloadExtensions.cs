// <copyright file="FriendlyOverloadExtensions.cs" company="Shkyrockett" >
// Copyright © 2020 - 2023 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;
using Windows.Win32.Graphics.Gdi;

namespace Windows.Win32;

/// <summary>
/// The friendly overload extensions.
/// </summary>
public static partial class FriendlyOverloadExtensions
{
#pragma warning disable IDE0030 // Use coalesce expression
    #region RenderTarget Shims
    #region BlendImage
    /// <summary>
    /// Blends the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="blendMode">The blend mode.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.BlendImage(ID2D1Image, D2D1_BLEND_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void BlendImage(this ID2D1DeviceContext6 @this, ID2D1Image image, D2D1_BLEND_MODE blendMode, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.BlendImage(image, blendMode, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode);
    }
    #endregion

    #region CreateBitmap
    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1BitmapRenderTarget @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1RenderTarget @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1HwndRenderTarget @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DCRenderTarget @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DeviceContext @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DeviceContext1 @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DeviceContext2 @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DeviceContext3 @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DeviceContext4 @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DeviceContext5 @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }

    /// <summary>
    /// Creates the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="srcData">The source data.</param>
    /// <param name="pitch">The pitch.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateBitmap(D2D_SIZE_U, void*, uint, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmap(this ID2D1DeviceContext6 @this, D2D_SIZE_U size, void* srcData, uint pitch, in D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (D2D1_BITMAP_PROPERTIES* bitmapPropertiesLocal = &bitmapProperties)
        {
            @this.CreateBitmap(size, srcData, pitch, bitmapPropertiesLocal, out bitmap);
        }
    }
    #endregion

    #region CreateBitmapBrush
    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1BitmapRenderTarget @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1RenderTarget @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1HwndRenderTarget @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DCRenderTarget @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DeviceContext @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DeviceContext1 @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DeviceContext2 @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DeviceContext3 @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DeviceContext4 @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DeviceContext5 @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }

    /// <summary>
    /// Creates the bitmap brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="bitmapBrushProperties">The bitmap brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="bitmapBrush">The bitmap brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateBitmapBrush(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1BitmapBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapBrush(this ID2D1DeviceContext6 @this, ID2D1Bitmap bitmap, D2D1_BITMAP_BRUSH_PROPERTIES? bitmapBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1BitmapBrush bitmapBrush)
    {
        var bitmapBrushPropertiesLocal = bitmapBrushProperties.HasValue ? bitmapBrushProperties.Value : default;
        var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
        @this.CreateBitmapBrush(bitmap, bitmapBrushProperties.HasValue ? &bitmapBrushPropertiesLocal : null, brushProperties.HasValue ? &brushPropertiesLocal : null, out bitmapBrush);
    }
    #endregion

    #region CreateBitmapFromDxgiSurface
    /// <summary>
    /// Creates the bitmap from dxgi surface.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surface">The surface.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateBitmapFromDxgiSurface(Graphics.Dxgi.IDXGISurface, in D2D1_BITMAP_PROPERTIES1, out ID2D1Bitmap1)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromDxgiSurface(this ID2D1DeviceContext @this, Graphics.Dxgi.IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? bitmapProperties, out ID2D1Bitmap1 bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromDxgiSurface(surface, bitmapProperties.HasValue ? bitmapPropertiesLocal : Unsafe.NullRef<D2D1_BITMAP_PROPERTIES1>(), out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from dxgi surface.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surface">The surface.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateBitmapFromDxgiSurface(Graphics.Dxgi.IDXGISurface, in D2D1_BITMAP_PROPERTIES1, out ID2D1Bitmap1)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromDxgiSurface(this ID2D1DeviceContext1 @this, Graphics.Dxgi.IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? bitmapProperties, out ID2D1Bitmap1 bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromDxgiSurface(surface, bitmapProperties.HasValue ? bitmapPropertiesLocal : Unsafe.NullRef<D2D1_BITMAP_PROPERTIES1>(), out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from dxgi surface.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surface">The surface.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateBitmapFromDxgiSurface(Graphics.Dxgi.IDXGISurface, in D2D1_BITMAP_PROPERTIES1, out ID2D1Bitmap1)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromDxgiSurface(this ID2D1DeviceContext2 @this, Graphics.Dxgi.IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? bitmapProperties, out ID2D1Bitmap1 bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromDxgiSurface(surface, bitmapProperties.HasValue ? bitmapPropertiesLocal : Unsafe.NullRef<D2D1_BITMAP_PROPERTIES1>(), out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from dxgi surface.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surface">The surface.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateBitmapFromDxgiSurface(Graphics.Dxgi.IDXGISurface, in D2D1_BITMAP_PROPERTIES1, out ID2D1Bitmap1)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromDxgiSurface(this ID2D1DeviceContext3 @this, Graphics.Dxgi.IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? bitmapProperties, out ID2D1Bitmap1 bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromDxgiSurface(surface, bitmapProperties.HasValue ? bitmapPropertiesLocal : Unsafe.NullRef<D2D1_BITMAP_PROPERTIES1>(), out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from dxgi surface.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surface">The surface.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateBitmapFromDxgiSurface(Graphics.Dxgi.IDXGISurface, in D2D1_BITMAP_PROPERTIES1, out ID2D1Bitmap1)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromDxgiSurface(this ID2D1DeviceContext4 @this, Graphics.Dxgi.IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? bitmapProperties, out ID2D1Bitmap1 bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromDxgiSurface(surface, bitmapProperties.HasValue ? bitmapPropertiesLocal : Unsafe.NullRef<D2D1_BITMAP_PROPERTIES1>(), out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from dxgi surface.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surface">The surface.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateBitmapFromDxgiSurface(Graphics.Dxgi.IDXGISurface, in D2D1_BITMAP_PROPERTIES1, out ID2D1Bitmap1)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromDxgiSurface(this ID2D1DeviceContext5 @this, Graphics.Dxgi.IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? bitmapProperties, out ID2D1Bitmap1 bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromDxgiSurface(surface, bitmapProperties.HasValue ? bitmapPropertiesLocal : Unsafe.NullRef<D2D1_BITMAP_PROPERTIES1>(), out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from dxgi surface.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surface">The surface.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateBitmapFromDxgiSurface(Graphics.Dxgi.IDXGISurface, in D2D1_BITMAP_PROPERTIES1, out ID2D1Bitmap1)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromDxgiSurface(this ID2D1DeviceContext6 @this, Graphics.Dxgi.IDXGISurface surface, D2D1_BITMAP_PROPERTIES1? bitmapProperties, out ID2D1Bitmap1 bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromDxgiSurface(surface, bitmapProperties.HasValue ? bitmapPropertiesLocal : Unsafe.NullRef<D2D1_BITMAP_PROPERTIES1>(), out bitmap);
    }
    #endregion

    #region CreateBitmapFromWicBitmap
    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1BitmapRenderTarget @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1RenderTarget @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1HwndRenderTarget @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DCRenderTarget @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DeviceContext @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DeviceContext1 @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DeviceContext2 @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DeviceContext3 @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DeviceContext4 @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DeviceContext5 @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }

    /// <summary>
    /// Creates the bitmap from wic bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="wicBitmapSource">The wic bitmap source.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateBitmapFromWicBitmap(Graphics.Imaging.IWICBitmapSource, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateBitmapFromWicBitmap(this ID2D1DeviceContext6 @this, Graphics.Imaging.IWICBitmapSource wicBitmapSource, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
        @this.CreateBitmapFromWicBitmap(wicBitmapSource, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
    }
    #endregion

    #region CreateColorContextFromFilename
    /// <summary>
    /// Creates the color context from filename.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateColorContextFromFilename(Foundation.PCWSTR, out ID2D1ColorContext)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromFilename(this ID2D1DeviceContext @this, string filename, out ID2D1ColorContext colorContext)
    {
        fixed (char* filenameLocal = filename)
        {
            @this.CreateColorContextFromFilename(filenameLocal, out colorContext);
        }
    }

    /// <summary>
    /// Creates the color context from filename.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateColorContextFromFilename(Foundation.PCWSTR, out ID2D1ColorContext)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromFilename(this ID2D1DeviceContext1 @this, string filename, out ID2D1ColorContext colorContext)
    {
        fixed (char* filenameLocal = filename)
        {
            @this.CreateColorContextFromFilename(filenameLocal, out colorContext);
        }
    }

    /// <summary>
    /// Creates the color context from filename.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateColorContextFromFilename(Foundation.PCWSTR, out ID2D1ColorContext)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromFilename(this ID2D1DeviceContext2 @this, string filename, out ID2D1ColorContext colorContext)
    {
        fixed (char* filenameLocal = filename)
        {
            @this.CreateColorContextFromFilename(filenameLocal, out colorContext);
        }
    }

    /// <summary>
    /// Creates the color context from filename.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateColorContextFromFilename(Foundation.PCWSTR, out ID2D1ColorContext)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromFilename(this ID2D1DeviceContext3 @this, string filename, out ID2D1ColorContext colorContext)
    {
        fixed (char* filenameLocal = filename)
        {
            @this.CreateColorContextFromFilename(filenameLocal, out colorContext);
        }
    }

    /// <summary>
    /// Creates the color context from filename.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateColorContextFromFilename(Foundation.PCWSTR, out ID2D1ColorContext)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromFilename(this ID2D1DeviceContext4 @this, string filename, out ID2D1ColorContext colorContext)
    {
        fixed (char* filenameLocal = filename)
        {
            @this.CreateColorContextFromFilename(filenameLocal, out colorContext);
        }
    }

    /// <summary>
    /// Creates the color context from filename.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateColorContextFromFilename(Foundation.PCWSTR, out ID2D1ColorContext)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromFilename(this ID2D1DeviceContext5 @this, string filename, out ID2D1ColorContext colorContext)
    {
        fixed (char* filenameLocal = filename)
        {
            @this.CreateColorContextFromFilename(filenameLocal, out colorContext);
        }
    }

    /// <summary>
    /// Creates the color context from filename.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="filename">The filename.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateColorContextFromFilename(Foundation.PCWSTR, out ID2D1ColorContext)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromFilename(this ID2D1DeviceContext6 @this, string filename, out ID2D1ColorContext colorContext)
    {
        fixed (char* filenameLocal = filename)
        {
            @this.CreateColorContextFromFilename(filenameLocal, out colorContext);
        }
    }
    #endregion

    #region CreateColorContextFromSimpleColorProfile
    /// <summary>
    /// Creates the color context from simple color profile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="simpleProfile">The simple profile.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateColorContextFromSimpleColorProfile(Windows.Win32.Graphics.Direct2D.D2D1_SIMPLE_COLOR_PROFILE*, out ID2D1ColorContext1)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromSimpleColorProfile(this ID2D1DeviceContext5 @this, in D2D1_SIMPLE_COLOR_PROFILE simpleProfile, out ID2D1ColorContext1 colorContext)
    {
        fixed (D2D1_SIMPLE_COLOR_PROFILE* simpleProfileLocal = &simpleProfile)
        {
            @this.CreateColorContextFromSimpleColorProfile(simpleProfileLocal, out colorContext);
        }
    }

    /// <summary>
    /// Creates the color context from simple color profile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="simpleProfile">The simple profile.</param>
    /// <param name="colorContext">The color context.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateColorContextFromSimpleColorProfile(Windows.Win32.Graphics.Direct2D.D2D1_SIMPLE_COLOR_PROFILE*, out ID2D1ColorContext1)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateColorContextFromSimpleColorProfile(this ID2D1DeviceContext6 @this, in D2D1_SIMPLE_COLOR_PROFILE simpleProfile, out ID2D1ColorContext1 colorContext)
    {
        fixed (D2D1_SIMPLE_COLOR_PROFILE* simpleProfileLocal = &simpleProfile)
        {
            @this.CreateColorContextFromSimpleColorProfile(simpleProfileLocal, out colorContext);
        }
    }
    #endregion

    #region CreateCompatibleRenderTarget
    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1BitmapRenderTarget @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1RenderTarget @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1HwndRenderTarget @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DCRenderTarget @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DeviceContext @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DeviceContext1 @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DeviceContext2 @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DeviceContext3 @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DeviceContext4 @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DeviceContext5 @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }

    /// <summary>
    /// Creates the compatible render target.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="desiredSize">Size of the desired.</param>
    /// <param name="desiredPixelSize">Size of the desired pixel.</param>
    /// <param name="desiredFormat">The desired format.</param>
    /// <param name="options">The options.</param>
    /// <param name="bitmapRenderTarget">The bitmap render target.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateCompatibleRenderTarget(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_U*, Windows.Win32.Graphics.Direct2D.Common.D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, out ID2D1BitmapRenderTarget)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateCompatibleRenderTarget(this ID2D1DeviceContext6 @this, D2D_SIZE_F? desiredSize, D2D_SIZE_U? desiredPixelSize, D2D1_PIXEL_FORMAT? desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget)
    {
        var desiredSizeLocal = desiredSize.HasValue ? desiredSize.Value : default;
        var desiredPixelSizeLocal = desiredPixelSize.HasValue ? desiredPixelSize.Value : default;
        var desiredFormatLocal = desiredFormat.HasValue ? desiredFormat.Value : default;
        @this.CreateCompatibleRenderTarget(desiredSize.HasValue ? &desiredSizeLocal : null, desiredPixelSize.HasValue ? &desiredPixelSizeLocal : null, desiredFormat.HasValue ? &desiredFormatLocal : null, options, out bitmapRenderTarget);
    }
    #endregion

    #region CreateEffect
    /// <summary>
    /// Creates the effect.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effectId">The effect identifier.</param>
    /// <param name="effect">The effect.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateEffect(Guid*, out ID2D1Effect)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateEffect(this ID2D1DeviceContext @this, in Guid effectId, out ID2D1Effect effect)
    {
        fixed (Guid* effectIdLocal = &effectId)
        {
            @this.CreateEffect(effectIdLocal, out effect);
        }
    }

    /// <summary>
    /// Creates the effect.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effectId">The effect identifier.</param>
    /// <param name="effect">The effect.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateEffect(Guid*, out ID2D1Effect)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateEffect(this ID2D1DeviceContext1 @this, in Guid effectId, out ID2D1Effect effect)
    {
        fixed (Guid* effectIdLocal = &effectId)
        {
            @this.CreateEffect(effectIdLocal, out effect);
        }
    }

    /// <summary>
    /// Creates the effect.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effectId">The effect identifier.</param>
    /// <param name="effect">The effect.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateEffect(Guid*, out ID2D1Effect)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateEffect(this ID2D1DeviceContext2 @this, in Guid effectId, out ID2D1Effect effect)
    {
        fixed (Guid* effectIdLocal = &effectId)
        {
            @this.CreateEffect(effectIdLocal, out effect);
        }
    }

    /// <summary>
    /// Creates the effect.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effectId">The effect identifier.</param>
    /// <param name="effect">The effect.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateEffect(Guid*, out ID2D1Effect)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateEffect(this ID2D1DeviceContext3 @this, in Guid effectId, out ID2D1Effect effect)
    {
        fixed (Guid* effectIdLocal = &effectId)
        {
            @this.CreateEffect(effectIdLocal, out effect);
        }
    }

    /// <summary>
    /// Creates the effect.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effectId">The effect identifier.</param>
    /// <param name="effect">The effect.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateEffect(Guid*, out ID2D1Effect)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateEffect(this ID2D1DeviceContext4 @this, in Guid effectId, out ID2D1Effect effect)
    {
        fixed (Guid* effectIdLocal = &effectId)
        {
            @this.CreateEffect(effectIdLocal, out effect);
        }
    }

    /// <summary>
    /// Creates the effect.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effectId">The effect identifier.</param>
    /// <param name="effect">The effect.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateEffect(Guid*, out ID2D1Effect)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateEffect(this ID2D1DeviceContext5 @this, in Guid effectId, out ID2D1Effect effect)
    {
        fixed (Guid* effectIdLocal = &effectId)
        {
            @this.CreateEffect(effectIdLocal, out effect);
        }
    }

    /// <summary>
    /// Creates the effect.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effectId">The effect identifier.</param>
    /// <param name="effect">The effect.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateEffect(Guid*, out ID2D1Effect)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateEffect(this ID2D1DeviceContext6 @this, in Guid effectId, out ID2D1Effect effect)
    {
        fixed (Guid* effectIdLocal = &effectId)
        {
            @this.CreateEffect(effectIdLocal, out effect);
        }
    }
    #endregion

    #region CreateInk
    /// <summary>
    /// Creates the ink.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="startPoint">The start point.</param>
    /// <param name="ink">The ink.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateInk(Windows.Win32.Graphics.Direct2D.D2D1_INK_POINT*, out ID2D1Ink)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInk(this ID2D1DeviceContext2 @this, in D2D1_INK_POINT startPoint, out ID2D1Ink ink)
    {
        fixed (D2D1_INK_POINT* startPointLocal = &startPoint)
        {
            @this.CreateInk(startPointLocal, out ink);
        }
    }

    /// <summary>
    /// Creates the ink.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="startPoint">The start point.</param>
    /// <param name="ink">The ink.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateInk(Windows.Win32.Graphics.Direct2D.D2D1_INK_POINT*, out ID2D1Ink)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInk(this ID2D1DeviceContext3 @this, in D2D1_INK_POINT startPoint, out ID2D1Ink ink)
    {
        fixed (D2D1_INK_POINT* startPointLocal = &startPoint)
        {
            @this.CreateInk(startPointLocal, out ink);
        }
    }

    /// <summary>
    /// Creates the ink.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="startPoint">The start point.</param>
    /// <param name="ink">The ink.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateInk(Windows.Win32.Graphics.Direct2D.D2D1_INK_POINT*, out ID2D1Ink)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInk(this ID2D1DeviceContext4 @this, in D2D1_INK_POINT startPoint, out ID2D1Ink ink)
    {
        fixed (D2D1_INK_POINT* startPointLocal = &startPoint)
        {
            @this.CreateInk(startPointLocal, out ink);
        }
    }

    /// <summary>
    /// Creates the ink.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="startPoint">The start point.</param>
    /// <param name="ink">The ink.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateInk(Windows.Win32.Graphics.Direct2D.D2D1_INK_POINT*, out ID2D1Ink)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInk(this ID2D1DeviceContext5 @this, in D2D1_INK_POINT startPoint, out ID2D1Ink ink)
    {
        fixed (D2D1_INK_POINT* startPointLocal = &startPoint)
        {
            @this.CreateInk(startPointLocal, out ink);
        }
    }

    /// <summary>
    /// Creates the ink.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="startPoint">The start point.</param>
    /// <param name="ink">The ink.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateInk(Windows.Win32.Graphics.Direct2D.D2D1_INK_POINT*, out ID2D1Ink)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInk(this ID2D1DeviceContext6 @this, in D2D1_INK_POINT startPoint, out ID2D1Ink ink)
    {
        fixed (D2D1_INK_POINT* startPointLocal = &startPoint)
        {
            @this.CreateInk(startPointLocal, out ink);
        }
    }
    #endregion

    #region CreateInkStyle
    /// <summary>
    /// Creates the ink style.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="inkStyleProperties">The ink style properties.</param>
    /// <param name="inkStyle">The ink style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateInkStyle(Windows.Win32.Graphics.Direct2D.D2D1_INK_STYLE_PROPERTIES*, out ID2D1InkStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInkStyle(this ID2D1DeviceContext2 @this, D2D1_INK_STYLE_PROPERTIES? inkStyleProperties, out ID2D1InkStyle inkStyle)
    {
        var inkStylePropertiesLocal = inkStyleProperties.HasValue ? inkStyleProperties.Value : default;
        @this.CreateInkStyle(inkStyleProperties.HasValue ? &inkStylePropertiesLocal : null, out inkStyle);
    }

    /// <summary>
    /// Creates the ink style.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="inkStyleProperties">The ink style properties.</param>
    /// <param name="inkStyle">The ink style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateInkStyle(Windows.Win32.Graphics.Direct2D.D2D1_INK_STYLE_PROPERTIES*, out ID2D1InkStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInkStyle(this ID2D1DeviceContext3 @this, D2D1_INK_STYLE_PROPERTIES? inkStyleProperties, out ID2D1InkStyle inkStyle)
    {
        var inkStylePropertiesLocal = inkStyleProperties.HasValue ? inkStyleProperties.Value : default;
        @this.CreateInkStyle(inkStyleProperties.HasValue ? &inkStylePropertiesLocal : null, out inkStyle);
    }

    /// <summary>
    /// Creates the ink style.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="inkStyleProperties">The ink style properties.</param>
    /// <param name="inkStyle">The ink style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateInkStyle(Windows.Win32.Graphics.Direct2D.D2D1_INK_STYLE_PROPERTIES*, out ID2D1InkStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInkStyle(this ID2D1DeviceContext4 @this, D2D1_INK_STYLE_PROPERTIES? inkStyleProperties, out ID2D1InkStyle inkStyle)
    {
        var inkStylePropertiesLocal = inkStyleProperties.HasValue ? inkStyleProperties.Value : default;
        @this.CreateInkStyle(inkStyleProperties.HasValue ? &inkStylePropertiesLocal : null, out inkStyle);
    }

    /// <summary>
    /// Creates the ink style.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="inkStyleProperties">The ink style properties.</param>
    /// <param name="inkStyle">The ink style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateInkStyle(Windows.Win32.Graphics.Direct2D.D2D1_INK_STYLE_PROPERTIES*, out ID2D1InkStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInkStyle(this ID2D1DeviceContext5 @this, D2D1_INK_STYLE_PROPERTIES? inkStyleProperties, out ID2D1InkStyle inkStyle)
    {
        var inkStylePropertiesLocal = inkStyleProperties.HasValue ? inkStyleProperties.Value : default;
        @this.CreateInkStyle(inkStyleProperties.HasValue ? &inkStylePropertiesLocal : null, out inkStyle);
    }

    /// <summary>
    /// Creates the ink style.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="inkStyleProperties">The ink style properties.</param>
    /// <param name="inkStyle">The ink style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateInkStyle(Windows.Win32.Graphics.Direct2D.D2D1_INK_STYLE_PROPERTIES*, out ID2D1InkStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateInkStyle(this ID2D1DeviceContext6 @this, D2D1_INK_STYLE_PROPERTIES? inkStyleProperties, out ID2D1InkStyle inkStyle)
    {
        var inkStylePropertiesLocal = inkStyleProperties.HasValue ? inkStyleProperties.Value : default;
        @this.CreateInkStyle(inkStyleProperties.HasValue ? &inkStylePropertiesLocal : null, out inkStyle);
    }
    #endregion

    #region CreateImageSourceFromDxgi
    /// <summary>
    /// Creates the image source from dxgi.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surfaces">The surfaces.</param>
    /// <param name="colorSpace">The color space.</param>
    /// <param name="options">The options.</param>
    /// <param name="imageSource">The image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateImageSourceFromDxgi(Windows.Win32.Graphics.Dxgi.IDXGISurface[], uint, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, out ID2D1ImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageSourceFromDxgi(this ID2D1DeviceContext2 @this, Graphics.Dxgi.IDXGISurface[] surfaces, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, out ID2D1ImageSource imageSource) => @this.CreateImageSourceFromDxgi(surfaces, (uint)surfaces.Length, colorSpace, options, out imageSource);

    /// <summary>
    /// Creates the image source from dxgi.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surfaces">The surfaces.</param>
    /// <param name="colorSpace">The color space.</param>
    /// <param name="options">The options.</param>
    /// <param name="imageSource">The image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateImageSourceFromDxgi(Windows.Win32.Graphics.Dxgi.IDXGISurface[], uint, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, out ID2D1ImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageSourceFromDxgi(this ID2D1DeviceContext3 @this, Graphics.Dxgi.IDXGISurface[] surfaces, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, out ID2D1ImageSource imageSource) => @this.CreateImageSourceFromDxgi(surfaces, (uint)surfaces.Length, colorSpace, options, out imageSource);

    /// <summary>
    /// Creates the image source from dxgi.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surfaces">The surfaces.</param>
    /// <param name="colorSpace">The color space.</param>
    /// <param name="options">The options.</param>
    /// <param name="imageSource">The image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateImageSourceFromDxgi(Windows.Win32.Graphics.Dxgi.IDXGISurface[], uint, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, out ID2D1ImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageSourceFromDxgi(this ID2D1DeviceContext4 @this, Graphics.Dxgi.IDXGISurface[] surfaces, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, out ID2D1ImageSource imageSource) => @this.CreateImageSourceFromDxgi(surfaces, (uint)surfaces.Length, colorSpace, options, out imageSource);

    /// <summary>
    /// Creates the image source from dxgi.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surfaces">The surfaces.</param>
    /// <param name="colorSpace">The color space.</param>
    /// <param name="options">The options.</param>
    /// <param name="imageSource">The image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateImageSourceFromDxgi(Windows.Win32.Graphics.Dxgi.IDXGISurface[], uint, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, out ID2D1ImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageSourceFromDxgi(this ID2D1DeviceContext5 @this, Graphics.Dxgi.IDXGISurface[] surfaces, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, out ID2D1ImageSource imageSource) => @this.CreateImageSourceFromDxgi(surfaces, (uint)surfaces.Length, colorSpace, options, out imageSource);

    /// <summary>
    /// Creates the image source from dxgi.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="surfaces">The surfaces.</param>
    /// <param name="colorSpace">The color space.</param>
    /// <param name="options">The options.</param>
    /// <param name="imageSource">The image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateImageSourceFromDxgi(Windows.Win32.Graphics.Dxgi.IDXGISurface[], uint, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS, out ID2D1ImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageSourceFromDxgi(this ID2D1DeviceContext6 @this, Graphics.Dxgi.IDXGISurface[] surfaces, Graphics.Dxgi.Common.DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, out ID2D1ImageSource imageSource) => @this.CreateImageSourceFromDxgi(surfaces, (uint)surfaces.Length, colorSpace, options, out imageSource);
    #endregion

    #region CreateGradientMesh
    /// <summary>
    /// Creates the gradient mesh.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="patches">The patches.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateGradientMesh(Windows.Win32.Graphics.Direct2D.D2D1_GRADIENT_MESH_PATCH*, uint, out ID2D1GradientMesh)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientMesh(this ID2D1DeviceContext2 @this, ReadOnlySpan<D2D1_GRADIENT_MESH_PATCH> patches, out ID2D1GradientMesh gradientMesh)
    {
        fixed (D2D1_GRADIENT_MESH_PATCH* patchesLocal = patches)
        {
            @this.CreateGradientMesh(patchesLocal, (uint)patches.Length, out gradientMesh);
        }
    }

    /// <summary>
    /// Creates the gradient mesh.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="patches">The patches.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateGradientMesh(Windows.Win32.Graphics.Direct2D.D2D1_GRADIENT_MESH_PATCH*, uint, out ID2D1GradientMesh)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientMesh(this ID2D1DeviceContext3 @this, ReadOnlySpan<D2D1_GRADIENT_MESH_PATCH> patches, out ID2D1GradientMesh gradientMesh)
    {
        fixed (D2D1_GRADIENT_MESH_PATCH* patchesLocal = patches)
        {
            @this.CreateGradientMesh(patchesLocal, (uint)patches.Length, out gradientMesh);
        }
    }

    /// <summary>
    /// Creates the gradient mesh.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="patches">The patches.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateGradientMesh(Windows.Win32.Graphics.Direct2D.D2D1_GRADIENT_MESH_PATCH*, uint, out ID2D1GradientMesh)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientMesh(this ID2D1DeviceContext4 @this, ReadOnlySpan<D2D1_GRADIENT_MESH_PATCH> patches, out ID2D1GradientMesh gradientMesh)
    {
        fixed (D2D1_GRADIENT_MESH_PATCH* patchesLocal = patches)
        {
            @this.CreateGradientMesh(patchesLocal, (uint)patches.Length, out gradientMesh);
        }
    }

    /// <summary>
    /// Creates the gradient mesh.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="patches">The patches.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateGradientMesh(Windows.Win32.Graphics.Direct2D.D2D1_GRADIENT_MESH_PATCH*, uint, out ID2D1GradientMesh)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientMesh(this ID2D1DeviceContext5 @this, ReadOnlySpan<D2D1_GRADIENT_MESH_PATCH> patches, out ID2D1GradientMesh gradientMesh)
    {
        fixed (D2D1_GRADIENT_MESH_PATCH* patchesLocal = patches)
        {
            @this.CreateGradientMesh(patchesLocal, (uint)patches.Length, out gradientMesh);
        }
    }

    /// <summary>
    /// Creates the gradient mesh.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="patches">The patches.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateGradientMesh(Windows.Win32.Graphics.Direct2D.D2D1_GRADIENT_MESH_PATCH*, uint, out ID2D1GradientMesh)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientMesh(this ID2D1DeviceContext6 @this, ReadOnlySpan<D2D1_GRADIENT_MESH_PATCH> patches, out ID2D1GradientMesh gradientMesh)
    {
        fixed (D2D1_GRADIENT_MESH_PATCH* patchesLocal = patches)
        {
            @this.CreateGradientMesh(patchesLocal, (uint)patches.Length, out gradientMesh);
        }
    }
    #endregion

    #region GetGradientMeshWorldBounds
    /// <summary>
    /// Gets the gradient mesh world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <param name="pBounds">The p bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetGradientMeshWorldBounds(ID2D1GradientMesh, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGradientMeshWorldBounds(this ID2D1DeviceContext2 @this, ID2D1GradientMesh gradientMesh, out D2D_RECT_F pBounds)
    {
        fixed (D2D_RECT_F* pBoundsLocal = &pBounds)
        {
            @this.GetGradientMeshWorldBounds(gradientMesh, pBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the gradient mesh world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <param name="pBounds">The p bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetGradientMeshWorldBounds(ID2D1GradientMesh, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGradientMeshWorldBounds(this ID2D1DeviceContext3 @this, ID2D1GradientMesh gradientMesh, out D2D_RECT_F pBounds)
    {
        fixed (D2D_RECT_F* pBoundsLocal = &pBounds)
        {
            @this.GetGradientMeshWorldBounds(gradientMesh, pBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the gradient mesh world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <param name="pBounds">The p bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetGradientMeshWorldBounds(ID2D1GradientMesh, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGradientMeshWorldBounds(this ID2D1DeviceContext4 @this, ID2D1GradientMesh gradientMesh, out D2D_RECT_F pBounds)
    {
        fixed (D2D_RECT_F* pBoundsLocal = &pBounds)
        {
            @this.GetGradientMeshWorldBounds(gradientMesh, pBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the gradient mesh world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <param name="pBounds">The p bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetGradientMeshWorldBounds(ID2D1GradientMesh, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGradientMeshWorldBounds(this ID2D1DeviceContext5 @this, ID2D1GradientMesh gradientMesh, out D2D_RECT_F pBounds)
    {
        fixed (D2D_RECT_F* pBoundsLocal = &pBounds)
        {
            @this.GetGradientMeshWorldBounds(gradientMesh, pBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the gradient mesh world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientMesh">The gradient mesh.</param>
    /// <param name="pBounds">The p bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetGradientMeshWorldBounds(ID2D1GradientMesh, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGradientMeshWorldBounds(this ID2D1DeviceContext6 @this, ID2D1GradientMesh gradientMesh, out D2D_RECT_F pBounds)
    {
        fixed (D2D_RECT_F* pBoundsLocal = &pBounds)
        {
            @this.GetGradientMeshWorldBounds(gradientMesh, pBoundsLocal);
        }
    }
    #endregion

    #region CreateGradientStopCollection
    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1BitmapRenderTarget @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1RenderTarget @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1HwndRenderTarget @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DCRenderTarget @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="straightAlphaGradientStops">The straight alpha gradient stops.</param>
    /// <param name="preInterpolationSpace">The pre interpolation space.</param>
    /// <param name="postInterpolationSpace">The post interpolation space.</param>
    /// <param name="bufferPrecision">The buffer precision.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="colorInterpolationMode">The color interpolation mode.</param>
    /// <param name="gradientStopCollection1">The gradient stop collection1.</param>
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext @this, ReadOnlySpan<D2D1_GRADIENT_STOP> straightAlphaGradientStops, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1)
    {
        fixed (D2D1_GRADIENT_STOP* straightAlphaGradientStopsLocal = straightAlphaGradientStops)
        {
            @this.CreateGradientStopCollection(straightAlphaGradientStopsLocal, (uint)straightAlphaGradientStops.Length, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, out gradientStopCollection1);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext1 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="straightAlphaGradientStops">The straight alpha gradient stops.</param>
    /// <param name="preInterpolationSpace">The pre interpolation space.</param>
    /// <param name="postInterpolationSpace">The post interpolation space.</param>
    /// <param name="bufferPrecision">The buffer precision.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="colorInterpolationMode">The color interpolation mode.</param>
    /// <param name="gradientStopCollection1">The gradient stop collection1.</param>
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext1 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> straightAlphaGradientStops, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1)
    {
        fixed (D2D1_GRADIENT_STOP* straightAlphaGradientStopsLocal = straightAlphaGradientStops)
        {
            @this.CreateGradientStopCollection(straightAlphaGradientStopsLocal, (uint)straightAlphaGradientStops.Length, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, out gradientStopCollection1);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext2 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="straightAlphaGradientStops">The straight alpha gradient stops.</param>
    /// <param name="preInterpolationSpace">The pre interpolation space.</param>
    /// <param name="postInterpolationSpace">The post interpolation space.</param>
    /// <param name="bufferPrecision">The buffer precision.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="colorInterpolationMode">The color interpolation mode.</param>
    /// <param name="gradientStopCollection1">The gradient stop collection1.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext2 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> straightAlphaGradientStops, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1)
    {
        fixed (D2D1_GRADIENT_STOP* straightAlphaGradientStopsLocal = straightAlphaGradientStops)
        {
            @this.CreateGradientStopCollection(straightAlphaGradientStopsLocal, (uint)straightAlphaGradientStops.Length, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, out gradientStopCollection1);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext3 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="straightAlphaGradientStops">The straight alpha gradient stops.</param>
    /// <param name="preInterpolationSpace">The pre interpolation space.</param>
    /// <param name="postInterpolationSpace">The post interpolation space.</param>
    /// <param name="bufferPrecision">The buffer precision.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="colorInterpolationMode">The color interpolation mode.</param>
    /// <param name="gradientStopCollection1">The gradient stop collection1.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext3 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> straightAlphaGradientStops, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1)
    {
        fixed (D2D1_GRADIENT_STOP* straightAlphaGradientStopsLocal = straightAlphaGradientStops)
        {
            @this.CreateGradientStopCollection(straightAlphaGradientStopsLocal, (uint)straightAlphaGradientStops.Length, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, out gradientStopCollection1);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext4 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="straightAlphaGradientStops">The straight alpha gradient stops.</param>
    /// <param name="preInterpolationSpace">The pre interpolation space.</param>
    /// <param name="postInterpolationSpace">The post interpolation space.</param>
    /// <param name="bufferPrecision">The buffer precision.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="colorInterpolationMode">The color interpolation mode.</param>
    /// <param name="gradientStopCollection1">The gradient stop collection1.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext4 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> straightAlphaGradientStops, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1)
    {
        fixed (D2D1_GRADIENT_STOP* straightAlphaGradientStopsLocal = straightAlphaGradientStops)
        {
            @this.CreateGradientStopCollection(straightAlphaGradientStopsLocal, (uint)straightAlphaGradientStops.Length, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, out gradientStopCollection1);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext5 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="straightAlphaGradientStops">The straight alpha gradient stops.</param>
    /// <param name="preInterpolationSpace">The pre interpolation space.</param>
    /// <param name="postInterpolationSpace">The post interpolation space.</param>
    /// <param name="bufferPrecision">The buffer precision.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="colorInterpolationMode">The color interpolation mode.</param>
    /// <param name="gradientStopCollection1">The gradient stop collection1.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext5 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> straightAlphaGradientStops, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1)
    {
        fixed (D2D1_GRADIENT_STOP* straightAlphaGradientStopsLocal = straightAlphaGradientStops)
        {
            @this.CreateGradientStopCollection(straightAlphaGradientStopsLocal, (uint)straightAlphaGradientStops.Length, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, out gradientStopCollection1);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gradientStops">The gradient stops.</param>
    /// <param name="colorInterpolationGamma">The color interpolation gamma.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext6 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> gradientStops, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection)
    {
        fixed (D2D1_GRADIENT_STOP* gradientStopsLocal = gradientStops)
        {
            @this.CreateGradientStopCollection(gradientStopsLocal, (uint)gradientStops.Length, colorInterpolationGamma, extendMode, out gradientStopCollection);
        }
    }

    /// <summary>
    /// Creates the gradient stop collection.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="straightAlphaGradientStops">The straight alpha gradient stops.</param>
    /// <param name="preInterpolationSpace">The pre interpolation space.</param>
    /// <param name="postInterpolationSpace">The post interpolation space.</param>
    /// <param name="bufferPrecision">The buffer precision.</param>
    /// <param name="extendMode">The extend mode.</param>
    /// <param name="colorInterpolationMode">The color interpolation mode.</param>
    /// <param name="gradientStopCollection1">The gradient stop collection1.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateGradientStopCollection(this ID2D1DeviceContext6 @this, ReadOnlySpan<D2D1_GRADIENT_STOP> straightAlphaGradientStops, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, out ID2D1GradientStopCollection1 gradientStopCollection1)
    {
        fixed (D2D1_GRADIENT_STOP* straightAlphaGradientStopsLocal = straightAlphaGradientStops)
        {
            @this.CreateGradientStopCollection(straightAlphaGradientStopsLocal, (uint)straightAlphaGradientStops.Length, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, out gradientStopCollection1);
        }
    }
    #endregion

    #region CreateImageBrush
    /// <summary>
    /// Creates the image brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="imageBrushProperties">The image brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="imageBrush">The image brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateImageBrush(ID2D1Image, Windows.Win32.Graphics.Direct2D.D2D1_IMAGE_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1ImageBrush)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageBrush(this ID2D1DeviceContext @this, ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1ImageBrush imageBrush)
    {
        fixed (D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushPropertiesLocal = &imageBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateImageBrush(image, imageBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out imageBrush);
        }
    }

    /// <summary>
    /// Creates the image brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="imageBrushProperties">The image brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="imageBrush">The image brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateImageBrush(ID2D1Image, Windows.Win32.Graphics.Direct2D.D2D1_IMAGE_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1ImageBrush)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageBrush(this ID2D1DeviceContext1 @this, ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1ImageBrush imageBrush)
    {
        fixed (D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushPropertiesLocal = &imageBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateImageBrush(image, imageBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out imageBrush);
        }
    }

    /// <summary>
    /// Creates the image brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="imageBrushProperties">The image brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="imageBrush">The image brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateImageBrush(ID2D1Image, Windows.Win32.Graphics.Direct2D.D2D1_IMAGE_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1ImageBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageBrush(this ID2D1DeviceContext2 @this, ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1ImageBrush imageBrush)
    {
        fixed (D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushPropertiesLocal = &imageBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateImageBrush(image, imageBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out imageBrush);
        }
    }

    /// <summary>
    /// Creates the image brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="imageBrushProperties">The image brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="imageBrush">The image brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateImageBrush(ID2D1Image, Windows.Win32.Graphics.Direct2D.D2D1_IMAGE_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1ImageBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    public static unsafe void CreateImageBrush(this ID2D1DeviceContext3 @this, ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1ImageBrush imageBrush)
    {
        fixed (D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushPropertiesLocal = &imageBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateImageBrush(image, imageBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out imageBrush);
        }
    }

    /// <summary>
    /// Creates the image brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="imageBrushProperties">The image brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="imageBrush">The image brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateImageBrush(ID2D1Image, Windows.Win32.Graphics.Direct2D.D2D1_IMAGE_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1ImageBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageBrush(this ID2D1DeviceContext4 @this, ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1ImageBrush imageBrush)
    {
        fixed (D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushPropertiesLocal = &imageBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateImageBrush(image, imageBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out imageBrush);
        }
    }

    /// <summary>
    /// Creates the image brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="imageBrushProperties">The image brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="imageBrush">The image brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateImageBrush(ID2D1Image, Windows.Win32.Graphics.Direct2D.D2D1_IMAGE_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1ImageBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageBrush(this ID2D1DeviceContext5 @this, ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1ImageBrush imageBrush)
    {
        fixed (D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushPropertiesLocal = &imageBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateImageBrush(image, imageBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out imageBrush);
        }
    }

    /// <summary>
    /// Creates the image brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="imageBrushProperties">The image brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="imageBrush">The image brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateImageBrush(ID2D1Image, Windows.Win32.Graphics.Direct2D.D2D1_IMAGE_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1ImageBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateImageBrush(this ID2D1DeviceContext6 @this, ID2D1Image image, in D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1ImageBrush imageBrush)
    {
        fixed (D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushPropertiesLocal = &imageBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateImageBrush(image, imageBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out imageBrush);
        }
    }
    #endregion

    #region CreateLayer
    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1BitmapRenderTarget @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1RenderTarget @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1HwndRenderTarget @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DCRenderTarget @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DeviceContext @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DeviceContext1 @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DeviceContext2 @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DeviceContext3 @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DeviceContext4 @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DeviceContext5 @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }

    /// <summary>
    /// Creates the layer.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="size">The size.</param>
    /// <param name="layer">The layer.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateLayer(Windows.Win32.Graphics.Direct2D.Common.D2D_SIZE_F*, out ID2D1Layer)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLayer(this ID2D1DeviceContext6 @this, D2D_SIZE_F? size, out ID2D1Layer layer)
    {
        var sizeLocal = size.HasValue ? size.Value : default;
        @this.CreateLayer(size.HasValue ? &sizeLocal : null, out layer);
    }
    #endregion

    #region CreateLinearGradientBrush
    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1BitmapRenderTarget @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1RenderTarget @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1HwndRenderTarget @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DCRenderTarget @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DeviceContext @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DeviceContext1 @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DeviceContext2 @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DeviceContext3 @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DeviceContext4 @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DeviceContext5 @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }

    /// <summary>
    /// Creates the linear gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="linearGradientBrushProperties">The linear gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="linearGradientBrush">The linear gradient brush.</param>
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateLinearGradientBrush(this ID2D1DeviceContext6 @this, in D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush)
    {
        fixed (D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushPropertiesLocal = &linearGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateLinearGradientBrush(linearGradientBrushPropertiesLocal, brushProperties.HasValue ? (&brushPropertiesLocal) : null, gradientStopCollection, out linearGradientBrush);
        }
    }
    #endregion

    #region CreateRadialGradientBrush
    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1BitmapRenderTarget @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1RenderTarget @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1HwndRenderTarget @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DCRenderTarget @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DeviceContext @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DeviceContext1 @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DeviceContext2 @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DeviceContext3 @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DeviceContext4 @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DeviceContext5 @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }

    /// <summary>
    /// Creates the radial gradient brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="radialGradientBrushProperties">The radial gradient brush properties.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="gradientStopCollection">The gradient stop collection.</param>
    /// <param name="radialGradientBrush">The radial gradient brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateRadialGradientBrush(Windows.Win32.Graphics.Direct2D.D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateRadialGradientBrush(this ID2D1DeviceContext6 @this, in D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, D2D1_BRUSH_PROPERTIES? brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush)
    {
        fixed (D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushPropertiesLocal = &radialGradientBrushProperties)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateRadialGradientBrush(radialGradientBrushPropertiesLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, gradientStopCollection, out radialGradientBrush);
        }
    }
    #endregion

    #region CreateSharedBitmap
    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1BitmapRenderTarget @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1RenderTarget @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1HwndRenderTarget @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DCRenderTarget @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DeviceContext @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DeviceContext1 @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DeviceContext2 @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DeviceContext3 @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DeviceContext4 @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DeviceContext5 @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }

    /// <summary>
    /// Creates the shared bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="riid">The riid.</param>
    /// <param name="data">The data.</param>
    /// <param name="bitmapProperties">The bitmap properties.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateSharedBitmap(Guid*, void*, Windows.Win32.Graphics.Direct2D.D2D1_BITMAP_PROPERTIES*, out ID2D1Bitmap)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSharedBitmap(this ID2D1DeviceContext6 @this, in Guid riid, void* data, D2D1_BITMAP_PROPERTIES? bitmapProperties, out ID2D1Bitmap bitmap)
    {
        fixed (Guid* riidLocal = &riid)
        {
            var bitmapPropertiesLocal = bitmapProperties.HasValue ? bitmapProperties.Value : default;
            @this.CreateSharedBitmap(riidLocal, data, bitmapProperties.HasValue ? &bitmapPropertiesLocal : null, out bitmap);
        }
    }
    #endregion

    #region CreateSolidColorBrush
    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1BitmapRenderTarget @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1RenderTarget @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1HwndRenderTarget @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DCRenderTarget @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DeviceContext @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DeviceContext1 @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DeviceContext2 @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DeviceContext3 @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DeviceContext4 @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DeviceContext5 @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }

    /// <summary>
    /// Creates the solid color brush.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="color">The color.</param>
    /// <param name="brushProperties">The brush properties.</param>
    /// <param name="solidColorBrush">The solid color brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateSolidColorBrush(Windows.Win32.Graphics.Direct2D.Common.D2D1_COLOR_F*, Windows.Win32.Graphics.Direct2D.D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateSolidColorBrush(this ID2D1DeviceContext6 @this, in D2D1_COLOR_F color, D2D1_BRUSH_PROPERTIES? brushProperties, out ID2D1SolidColorBrush solidColorBrush)
    {
        fixed (D2D1_COLOR_F* colorLocal = &color)
        {
            var brushPropertiesLocal = brushProperties.HasValue ? brushProperties.Value : default;
            @this.CreateSolidColorBrush(colorLocal, brushProperties.HasValue ? &brushPropertiesLocal : null, out solidColorBrush);
        }
    }
    #endregion

    #region CreateTransformedImageSource
    /// <summary>
    /// Creates the transformed image source.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="imageSource">The image source.</param>
    /// <param name="properties">The properties.</param>
    /// <param name="transformedImageSource">The transformed image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.CreateTransformedImageSource(ID2D1ImageSource, Windows.Win32.Graphics.Direct2D.D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, out ID2D1TransformedImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateTransformedImageSource(this ID2D1DeviceContext2 @this, ID2D1ImageSource imageSource, in D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, out ID2D1TransformedImageSource transformedImageSource)
    {
        fixed (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* propertiesLocal = &properties)
        {
            @this.CreateTransformedImageSource(imageSource, propertiesLocal, out transformedImageSource);
        }
    }

    /// <summary>
    /// Creates the transformed image source.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="imageSource">The image source.</param>
    /// <param name="properties">The properties.</param>
    /// <param name="transformedImageSource">The transformed image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.CreateTransformedImageSource(ID2D1ImageSource, Windows.Win32.Graphics.Direct2D.D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, out ID2D1TransformedImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateTransformedImageSource(this ID2D1DeviceContext3 @this, ID2D1ImageSource imageSource, in D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, out ID2D1TransformedImageSource transformedImageSource)
    {
        fixed (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* propertiesLocal = &properties)
        {
            @this.CreateTransformedImageSource(imageSource, propertiesLocal, out transformedImageSource);
        }
    }

    /// <summary>
    /// Creates the transformed image source.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="imageSource">The image source.</param>
    /// <param name="properties">The properties.</param>
    /// <param name="transformedImageSource">The transformed image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.CreateTransformedImageSource(ID2D1ImageSource, Windows.Win32.Graphics.Direct2D.D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, out ID2D1TransformedImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateTransformedImageSource(this ID2D1DeviceContext4 @this, ID2D1ImageSource imageSource, in D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, out ID2D1TransformedImageSource transformedImageSource)
    {
        fixed (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* propertiesLocal = &properties)
        {
            @this.CreateTransformedImageSource(imageSource, propertiesLocal, out transformedImageSource);
        }
    }

    /// <summary>
    /// Creates the transformed image source.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="imageSource">The image source.</param>
    /// <param name="properties">The properties.</param>
    /// <param name="transformedImageSource">The transformed image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.CreateTransformedImageSource(ID2D1ImageSource, Windows.Win32.Graphics.Direct2D.D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, out ID2D1TransformedImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateTransformedImageSource(this ID2D1DeviceContext5 @this, ID2D1ImageSource imageSource, in D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, out ID2D1TransformedImageSource transformedImageSource)
    {
        fixed (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* propertiesLocal = &properties)
        {
            @this.CreateTransformedImageSource(imageSource, propertiesLocal, out transformedImageSource);
        }
    }

    /// <summary>
    /// Creates the transformed image source.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="imageSource">The image source.</param>
    /// <param name="properties">The properties.</param>
    /// <param name="transformedImageSource">The transformed image source.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.CreateTransformedImageSource(ID2D1ImageSource, Windows.Win32.Graphics.Direct2D.D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, out ID2D1TransformedImageSource)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void CreateTransformedImageSource(this ID2D1DeviceContext6 @this, ID2D1ImageSource imageSource, in D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, out ID2D1TransformedImageSource transformedImageSource)
    {
        fixed (D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* propertiesLocal = &properties)
        {
            @this.CreateTransformedImageSource(imageSource, propertiesLocal, out transformedImageSource);
        }
    }
    #endregion

    #region DrawBitmap
    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1BitmapRenderTarget @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1RenderTarget @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1HwndRenderTarget @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DCRenderTarget @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DeviceContext @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DeviceContext1 @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DeviceContext2 @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DeviceContext3 @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DeviceContext4 @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DeviceContext5 @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the bitmap.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="bitmap">The bitmap.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="opacity">The opacity.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawBitmap(ID2D1Bitmap, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawBitmap(this ID2D1DeviceContext6 @this, ID2D1Bitmap bitmap, D2D_RECT_F? destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawBitmap(bitmap, destinationRectangle.HasValue ? &destinationRectangleLocal : null, opacity, interpolationMode, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }
    #endregion

    #region DrawEllipse
    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1BitmapRenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1RenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1HwndRenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DCRenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DeviceContext @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DeviceContext1 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DeviceContext2 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DeviceContext3 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DeviceContext4 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DeviceContext5 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawEllipse(this ID2D1DeviceContext6 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.DrawEllipse(ellipseLocal, brush, strokeWidth, strokeStyle);
        }
    }
    #endregion

    #region DrawGdiMetafile
    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext @this, ID2D1GdiMetafile gdiMetafile, D2D_POINT_2F? targetOffset)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, targetOffset.HasValue ? &targetOffsetLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext1 @this, ID2D1GdiMetafile gdiMetafile, D2D_POINT_2F? targetOffset)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, targetOffset.HasValue ? &targetOffsetLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext2 @this, ID2D1GdiMetafile gdiMetafile, D2D_POINT_2F? targetOffset)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, targetOffset.HasValue ? &targetOffsetLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext3 @this, ID2D1GdiMetafile gdiMetafile, D2D_POINT_2F? targetOffset)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, targetOffset.HasValue ? &targetOffsetLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext4 @this, ID2D1GdiMetafile gdiMetafile, D2D_POINT_2F? targetOffset)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, targetOffset.HasValue ? &targetOffsetLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext5 @this, ID2D1GdiMetafile gdiMetafile, D2D_POINT_2F? targetOffset)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, targetOffset.HasValue ? &targetOffsetLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext6 @this, ID2D1GdiMetafile gdiMetafile, D2D_POINT_2F? targetOffset)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, targetOffset.HasValue ? &targetOffsetLocal : null);
    }
    #endregion

    #region DrawGdiMetafile
    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext2 @this, ID2D1GdiMetafile gdiMetafile, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext3 @this, ID2D1GdiMetafile gdiMetafile, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext4 @this, ID2D1GdiMetafile gdiMetafile, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext5 @this, ID2D1GdiMetafile gdiMetafile, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Draws the GDI metafile.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="gdiMetafile">The GDI metafile.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawGdiMetafile(ID2D1GdiMetafile, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGdiMetafile(this ID2D1DeviceContext6 @this, ID2D1GdiMetafile gdiMetafile, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.DrawGdiMetafile(gdiMetafile, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }
    #endregion

    #region DrawGlyphRun
    /// <summary>
    /// Draws the glyph run.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="glyphRunDescription">The glyph run description.</param>
    /// <param name="foregroundBrush">The foreground brush.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawGlyphRun(D2D_POINT_2F, in DWRITE_GLYPH_RUN, Windows.Win32.Graphics.DirectWrite.DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGlyphRun(this ID2D1DeviceContext @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION? glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        var glyphRunDescriptionLocal = glyphRunDescription.HasValue ? glyphRunDescription.Value : default;
        @this.DrawGlyphRun(baselineOrigin, in glyphRun, glyphRunDescription.HasValue ? &glyphRunDescriptionLocal : null, foregroundBrush, measuringMode);
    }

    /// <summary>
    /// Draws the glyph run.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="glyphRunDescription">The glyph run description.</param>
    /// <param name="foregroundBrush">The foreground brush.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawGlyphRun(D2D_POINT_2F, in DWRITE_GLYPH_RUN, Windows.Win32.Graphics.DirectWrite.DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGlyphRun(this ID2D1DeviceContext1 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION? glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        var glyphRunDescriptionLocal = glyphRunDescription.HasValue ? glyphRunDescription.Value : default;
        @this.DrawGlyphRun(baselineOrigin, in glyphRun, glyphRunDescription.HasValue ? &glyphRunDescriptionLocal : null, foregroundBrush, measuringMode);
    }

    /// <summary>
    /// Draws the glyph run.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="glyphRunDescription">The glyph run description.</param>
    /// <param name="foregroundBrush">The foreground brush.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawGlyphRun(D2D_POINT_2F, in DWRITE_GLYPH_RUN, Windows.Win32.Graphics.DirectWrite.DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGlyphRun(this ID2D1DeviceContext2 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION? glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        var glyphRunDescriptionLocal = glyphRunDescription.HasValue ? glyphRunDescription.Value : default;
        @this.DrawGlyphRun(baselineOrigin, in glyphRun, glyphRunDescription.HasValue ? &glyphRunDescriptionLocal : null, foregroundBrush, measuringMode);
    }

    /// <summary>
    /// Draws the glyph run.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="glyphRunDescription">The glyph run description.</param>
    /// <param name="foregroundBrush">The foreground brush.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawGlyphRun(D2D_POINT_2F, in DWRITE_GLYPH_RUN, Windows.Win32.Graphics.DirectWrite.DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGlyphRun(this ID2D1DeviceContext3 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION? glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        var glyphRunDescriptionLocal = glyphRunDescription.HasValue ? glyphRunDescription.Value : default;
        @this.DrawGlyphRun(baselineOrigin, in glyphRun, glyphRunDescription.HasValue ? &glyphRunDescriptionLocal : null, foregroundBrush, measuringMode);
    }

    /// <summary>
    /// Draws the glyph run.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="glyphRunDescription">The glyph run description.</param>
    /// <param name="foregroundBrush">The foreground brush.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawGlyphRun(D2D_POINT_2F, in DWRITE_GLYPH_RUN, Windows.Win32.Graphics.DirectWrite.DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGlyphRun(this ID2D1DeviceContext4 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION? glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        var glyphRunDescriptionLocal = glyphRunDescription.HasValue ? glyphRunDescription.Value : default;
        @this.DrawGlyphRun(baselineOrigin, in glyphRun, glyphRunDescription.HasValue ? &glyphRunDescriptionLocal : null, foregroundBrush, measuringMode);
    }

    /// <summary>
    /// Draws the glyph run.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="glyphRunDescription">The glyph run description.</param>
    /// <param name="foregroundBrush">The foreground brush.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawGlyphRun(D2D_POINT_2F, in DWRITE_GLYPH_RUN, Windows.Win32.Graphics.DirectWrite.DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGlyphRun(this ID2D1DeviceContext5 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION? glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        var glyphRunDescriptionLocal = glyphRunDescription.HasValue ? glyphRunDescription.Value : default;
        @this.DrawGlyphRun(baselineOrigin, in glyphRun, glyphRunDescription.HasValue ? &glyphRunDescriptionLocal : null, foregroundBrush, measuringMode);
    }

    /// <summary>
    /// Draws the glyph run.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="glyphRunDescription">The glyph run description.</param>
    /// <param name="foregroundBrush">The foreground brush.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawGlyphRun(D2D_POINT_2F, in DWRITE_GLYPH_RUN, Windows.Win32.Graphics.DirectWrite.DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawGlyphRun(this ID2D1DeviceContext6 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_GLYPH_RUN_DESCRIPTION? glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode)
    {
        var glyphRunDescriptionLocal = glyphRunDescription.HasValue ? glyphRunDescription.Value : default;
        @this.DrawGlyphRun(baselineOrigin, in glyphRun, glyphRunDescription.HasValue ? &glyphRunDescriptionLocal : null, foregroundBrush, measuringMode);
    }
    #endregion

    #region DrawImage
    /// <summary>
    /// Draws the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="compositeMode">The composite mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawImage(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawImage(this ID2D1DeviceContext @this, ID2D1Image image, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.DrawImage(image, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode, compositeMode);
    }

    /// <summary>
    /// Draws the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="compositeMode">The composite mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawImage(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawImage(this ID2D1DeviceContext1 @this, ID2D1Image image, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.DrawImage(image, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode, compositeMode);
    }

    /// <summary>
    /// Draws the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="compositeMode">The composite mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawImage(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawImage(this ID2D1DeviceContext2 @this, ID2D1Image image, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.DrawImage(image, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode, compositeMode);
    }

    /// <summary>
    /// Draws the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="compositeMode">The composite mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawImage(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawImage(this ID2D1DeviceContext3 @this, ID2D1Image image, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.DrawImage(image, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode, compositeMode);
    }

    /// <summary>
    /// Draws the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="compositeMode">The composite mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawImage(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawImage(this ID2D1DeviceContext4 @this, ID2D1Image image, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.DrawImage(image, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode, compositeMode);
    }

    /// <summary>
    /// Draws the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="compositeMode">The composite mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawImage(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawImage(this ID2D1DeviceContext5 @this, ID2D1Image image, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.DrawImage(image, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode, compositeMode);
    }

    /// <summary>
    /// Draws the image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="targetOffset">The target offset.</param>
    /// <param name="imageRectangle">The image rectangle.</param>
    /// <param name="interpolationMode">The interpolation mode.</param>
    /// <param name="compositeMode">The composite mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawImage(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_POINT_2F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawImage(this ID2D1DeviceContext6 @this, ID2D1Image image, D2D_POINT_2F? targetOffset, D2D_RECT_F? imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode)
    {
        var targetOffsetLocal = targetOffset.HasValue ? targetOffset.Value : default;
        var imageRectangleLocal = imageRectangle.HasValue ? imageRectangle.Value : default;
        @this.DrawImage(image, targetOffset.HasValue ? &targetOffsetLocal : null, imageRectangle.HasValue ? &imageRectangleLocal : null, interpolationMode, compositeMode);
    }
    #endregion

    #region DrawRectangle
    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1BitmapRenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1RenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1HwndRenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DCRenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DeviceContext @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DeviceContext1 @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DeviceContext2 @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DeviceContext3 @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DeviceContext4 @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DeviceContext5 @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRectangle(this ID2D1DeviceContext6 @this, in D2D_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.DrawRectangle(rectLocal, brush, strokeWidth, strokeStyle);
        }
    }
    #endregion

    #region DrawRoundedRectangle
    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1BitmapRenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1RenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1HwndRenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DCRenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DeviceContext @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DeviceContext1 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DeviceContext2 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DeviceContext3 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DeviceContext4 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DeviceContext5 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }

    /// <summary>
    /// Draws the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="strokeWidth">Width of the stroke.</param>
    /// <param name="strokeStyle">The stroke style.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush, float, ID2D1StrokeStyle)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawRoundedRectangle(this ID2D1DeviceContext6 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.DrawRoundedRectangle(roundedRectLocal, brush, strokeWidth, strokeStyle);
        }
    }
    #endregion

    #region DrawText
    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1BitmapRenderTarget @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1RenderTarget @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1HwndRenderTarget @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DCRenderTarget @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DeviceContext @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DeviceContext1 @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DeviceContext2 @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DeviceContext3 @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DeviceContext4 @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DeviceContext5 @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }

    /// <summary>
    /// Draws the text.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="string">The string.</param>
    /// <param name="stringLength">Length of the string.</param>
    /// <param name="textFormat">The text format.</param>
    /// <param name="layoutRect">The layout rect.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawText(Foundation.PCWSTR, uint, IDWriteTextFormat, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawText(this ID2D1DeviceContext6 @this, string @string, uint stringLength, IDWriteTextFormat textFormat, in D2D_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode)
    {
        fixed (D2D_RECT_F* layoutRectLocal = &layoutRect)
        {
            fixed (char* @stringLocal = @string)
            {
                @this.DrawText(@stringLocal, stringLength, textFormat, layoutRectLocal, defaultFillBrush, options, measuringMode);
            }
        }
    }
    #endregion

    #region DrawTextLayout
    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1BitmapRenderTarget @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1RenderTarget @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1HwndRenderTarget @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DCRenderTarget @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DeviceContext @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DeviceContext1 @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DeviceContext2 @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DeviceContext3 @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DeviceContext4 @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DeviceContext5 @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);

    /// <summary>
    /// Draws the text layout.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="origin">The origin.</param>
    /// <param name="textLayout">The text layout.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="options">The options.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.DrawTextLayout(D2D_POINT_2F, IDWriteTextLayout, ID2D1Brush, D2D1_DRAW_TEXT_OPTIONS)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void DrawTextLayout(this ID2D1DeviceContext6 @this, D2D_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_NONE) => @this.DrawTextLayout(origin, textLayout, defaultFillBrush, options);
    #endregion

    #region FillEllipse
    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1BitmapRenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1RenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1HwndRenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DCRenderTarget @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DeviceContext @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DeviceContext1 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DeviceContext2 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DeviceContext3 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DeviceContext4 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DeviceContext5 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }

    /// <summary>
    /// Fills the ellipse.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="ellipse">The ellipse.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.FillEllipse(Windows.Win32.Graphics.Direct2D.D2D1_ELLIPSE*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillEllipse(this ID2D1DeviceContext6 @this, in D2D1_ELLIPSE ellipse, ID2D1Brush brush)
    {
        fixed (D2D1_ELLIPSE* ellipseLocal = &ellipse)
        {
            @this.FillEllipse(ellipseLocal, brush);
        }
    }
    #endregion

    #region FillOpacityMask
    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1BitmapRenderTarget @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1RenderTarget @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1HwndRenderTarget @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DCRenderTarget @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DeviceContext @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DeviceContext1 @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DeviceContext2 @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DeviceContext3 @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DeviceContext4 @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DeviceContext5 @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }

    /// <summary>
    /// Fills the opacity mask.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="opacityMask">The opacity mask.</param>
    /// <param name="brush">The brush.</param>
    /// <param name="content">The content.</param>
    /// <param name="destinationRectangle">The destination rectangle.</param>
    /// <param name="sourceRectangle">The source rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.FillOpacityMask(ID2D1Bitmap, ID2D1Brush, D2D1_OPACITY_MASK_CONTENT, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillOpacityMask(this ID2D1DeviceContext6 @this, ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, D2D_RECT_F? destinationRectangle, D2D_RECT_F? sourceRectangle)
    {
        var destinationRectangleLocal = destinationRectangle.HasValue ? destinationRectangle.Value : default;
        var sourceRectangleLocal = sourceRectangle.HasValue ? sourceRectangle.Value : default;
        @this.FillOpacityMask(opacityMask, brush, content, destinationRectangle.HasValue ? &destinationRectangleLocal : null, sourceRectangle.HasValue ? &sourceRectangleLocal : null);
    }
    #endregion

    #region FillRectangle
    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1BitmapRenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1RenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1HwndRenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DCRenderTarget @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DeviceContext @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DeviceContext1 @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DeviceContext2 @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DeviceContext3 @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DeviceContext4 @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DeviceContext5 @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="rect">The rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.FillRectangle(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*,ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRectangle(this ID2D1DeviceContext6 @this, in D2D_RECT_F rect, ID2D1Brush brush)
    {
        fixed (D2D_RECT_F* rectLocal = &rect)
        {
            @this.FillRectangle(rectLocal, brush);
        }
    }
    #endregion

    #region FillRoundedRectangle
    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1BitmapRenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1RenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1HwndRenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DCRenderTarget @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DeviceContext @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DeviceContext1 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DeviceContext2 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DeviceContext3 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DeviceContext4 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DeviceContext5 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }

    /// <summary>
    /// Fills the rounded rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="roundedRect">The rounded rect.</param>
    /// <param name="brush">The brush.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.FillRoundedRectangle(Windows.Win32.Graphics.Direct2D.D2D1_ROUNDED_RECT*, ID2D1Brush)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void FillRoundedRectangle(this ID2D1DeviceContext6 @this, in D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush)
    {
        fixed (D2D1_ROUNDED_RECT* roundedRectLocal = &roundedRect)
        {
            @this.FillRoundedRectangle(roundedRectLocal, brush);
        }
    }
    #endregion

    #region GetColorBitmapGlyphImage
    /// <summary>
    /// Gets the color bitmap glyph image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="glyphImageFormat">The glyph image format.</param>
    /// <param name="glyphOrigin">The glyph origin.</param>
    /// <param name="fontFace">The font face.</param>
    /// <param name="fontEmSize">Size of the font em.</param>
    /// <param name="glyphIndex">Index of the glyph.</param>
    /// <param name="isSideways">The is sideways.</param>
    /// <param name="worldTransform">The world transform.</param>
    /// <param name="dpiX">The dpi x.</param>
    /// <param name="dpiY">The dpi y.</param>
    /// <param name="glyphTransform">The glyph transform.</param>
    /// <param name="glyphImage">The glyph image.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetColorBitmapGlyphImage(DWRITE_GLYPH_IMAGE_FORMATS, D2D_POINT_2F, IDWriteFontFace, float, ushort, Foundation.BOOL, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, float, float, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, out ID2D1Image)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetColorBitmapGlyphImage(this ID2D1DeviceContext4 @this, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, Foundation.BOOL isSideways, D2D_MATRIX_3X2_F? worldTransform, float dpiX, float dpiY, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1Image glyphImage)
    {
        fixed (D2D_MATRIX_3X2_F* glyphTransformLocal = &glyphTransform)
        {
            var worldTransformLocal = worldTransform.HasValue ? worldTransform.Value : default;
            @this.GetColorBitmapGlyphImage(glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform.HasValue ? &worldTransformLocal : null, dpiX, dpiY, glyphTransformLocal, out glyphImage);
        }
    }

    /// <summary>
    /// Gets the color bitmap glyph image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="glyphImageFormat">The glyph image format.</param>
    /// <param name="glyphOrigin">The glyph origin.</param>
    /// <param name="fontFace">The font face.</param>
    /// <param name="fontEmSize">Size of the font em.</param>
    /// <param name="glyphIndex">Index of the glyph.</param>
    /// <param name="isSideways">The is sideways.</param>
    /// <param name="worldTransform">The world transform.</param>
    /// <param name="dpiX">The dpi x.</param>
    /// <param name="dpiY">The dpi y.</param>
    /// <param name="glyphTransform">The glyph transform.</param>
    /// <param name="glyphImage">The glyph image.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetColorBitmapGlyphImage(DWRITE_GLYPH_IMAGE_FORMATS, D2D_POINT_2F, IDWriteFontFace, float, ushort, Foundation.BOOL, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, float, float, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, out ID2D1Image)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetColorBitmapGlyphImage(this ID2D1DeviceContext5 @this, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, Foundation.BOOL isSideways, D2D_MATRIX_3X2_F? worldTransform, float dpiX, float dpiY, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1Image glyphImage)
    {
        fixed (D2D_MATRIX_3X2_F* glyphTransformLocal = &glyphTransform)
        {
            var worldTransformLocal = worldTransform.HasValue ? worldTransform.Value : default;
            @this.GetColorBitmapGlyphImage(glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform.HasValue ? &worldTransformLocal : null, dpiX, dpiY, glyphTransformLocal, out glyphImage);
        }
    }

    /// <summary>
    /// Gets the color bitmap glyph image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="glyphImageFormat">The glyph image format.</param>
    /// <param name="glyphOrigin">The glyph origin.</param>
    /// <param name="fontFace">The font face.</param>
    /// <param name="fontEmSize">Size of the font em.</param>
    /// <param name="glyphIndex">Index of the glyph.</param>
    /// <param name="isSideways">The is sideways.</param>
    /// <param name="worldTransform">The world transform.</param>
    /// <param name="dpiX">The dpi x.</param>
    /// <param name="dpiY">The dpi y.</param>
    /// <param name="glyphTransform">The glyph transform.</param>
    /// <param name="glyphImage">The glyph image.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetColorBitmapGlyphImage(DWRITE_GLYPH_IMAGE_FORMATS, D2D_POINT_2F, IDWriteFontFace, float, ushort, Foundation.BOOL, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, float, float, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, out ID2D1Image)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetColorBitmapGlyphImage(this ID2D1DeviceContext6 @this, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, Foundation.BOOL isSideways, D2D_MATRIX_3X2_F? worldTransform, float dpiX, float dpiY, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1Image glyphImage)
    {
        fixed (D2D_MATRIX_3X2_F* glyphTransformLocal = &glyphTransform)
        {
            var worldTransformLocal = worldTransform.HasValue ? worldTransform.Value : default;
            @this.GetColorBitmapGlyphImage(glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform.HasValue ? &worldTransformLocal : null, dpiX, dpiY, glyphTransformLocal, out glyphImage);
        }
    }
    #endregion

    #region GetEffectInvalidRectangles
    /// <summary>
    /// Gets the effect invalid rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="rectangles">The rectangles.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.GetEffectInvalidRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectInvalidRectangles(this ID2D1DeviceContext @this, ID2D1Effect effect, Span<D2D_RECT_F> rectangles)
    {
        fixed (D2D_RECT_F* rectanglesLocal = rectangles)
        {
            @this.GetEffectInvalidRectangles(effect, rectanglesLocal, (uint)rectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect invalid rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="rectangles">The rectangles.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetEffectInvalidRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectInvalidRectangles(this ID2D1DeviceContext1 @this, ID2D1Effect effect, Span<D2D_RECT_F> rectangles)
    {
        fixed (D2D_RECT_F* rectanglesLocal = rectangles)
        {
            @this.GetEffectInvalidRectangles(effect, rectanglesLocal, (uint)rectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect invalid rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="rectangles">The rectangles.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetEffectInvalidRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectInvalidRectangles(this ID2D1DeviceContext2 @this, ID2D1Effect effect, Span<D2D_RECT_F> rectangles)
    {
        fixed (D2D_RECT_F* rectanglesLocal = rectangles)
        {
            @this.GetEffectInvalidRectangles(effect, rectanglesLocal, (uint)rectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect invalid rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="rectangles">The rectangles.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetEffectInvalidRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectInvalidRectangles(this ID2D1DeviceContext3 @this, ID2D1Effect effect, Span<D2D_RECT_F> rectangles)
    {
        fixed (D2D_RECT_F* rectanglesLocal = rectangles)
        {
            @this.GetEffectInvalidRectangles(effect, rectanglesLocal, (uint)rectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect invalid rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="rectangles">The rectangles.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetEffectInvalidRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectInvalidRectangles(this ID2D1DeviceContext4 @this, ID2D1Effect effect, Span<D2D_RECT_F> rectangles)
    {
        fixed (D2D_RECT_F* rectanglesLocal = rectangles)
        {
            @this.GetEffectInvalidRectangles(effect, rectanglesLocal, (uint)rectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect invalid rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="rectangles">The rectangles.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetEffectInvalidRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectInvalidRectangles(this ID2D1DeviceContext5 @this, ID2D1Effect effect, Span<D2D_RECT_F> rectangles)
    {
        fixed (D2D_RECT_F* rectanglesLocal = rectangles)
        {
            @this.GetEffectInvalidRectangles(effect, rectanglesLocal, (uint)rectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect invalid rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="rectangles">The rectangles.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetEffectInvalidRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectInvalidRectangles(this ID2D1DeviceContext6 @this, ID2D1Effect effect, Span<D2D_RECT_F> rectangles)
    {
        fixed (D2D_RECT_F* rectanglesLocal = rectangles)
        {
            @this.GetEffectInvalidRectangles(effect, rectanglesLocal, (uint)rectangles.Length);
        }
    }
    #endregion

    #region GetEffectRequiredInputRectangles
    /// <summary>
    /// Gets the effect required input rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderEffect">The render effect.</param>
    /// <param name="renderImageRectangle">The render image rectangle.</param>
    /// <param name="inputDescriptions">The input descriptions.</param>
    /// <param name="requiredInputRectangles">The required input rectangles.</param>
    /// <exception cref="System.ArgumentException">Input length not the same as required - requiredInputRectangles</exception>
    /// <inheritdoc cref="ID2D1DeviceContext.GetEffectRequiredInputRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.D2D1_EFFECT_INPUT_DESCRIPTION[], Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectRequiredInputRectangles(this ID2D1DeviceContext @this, ID2D1Effect renderEffect, D2D_RECT_F? renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, Span<D2D_RECT_F> requiredInputRectangles)
    {
        fixed (D2D_RECT_F* requiredInputRectanglesLocal = requiredInputRectangles)
        {
            var renderImageRectangleLocal = renderImageRectangle.HasValue ? renderImageRectangle.Value : default;
            if (inputDescriptions.Length != requiredInputRectangles.Length) throw new ArgumentException("Input length not the same as required", nameof(requiredInputRectangles));
            @this.GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle.HasValue ? &renderImageRectangleLocal : null, inputDescriptions, requiredInputRectanglesLocal, (uint)requiredInputRectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect required input rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderEffect">The render effect.</param>
    /// <param name="renderImageRectangle">The render image rectangle.</param>
    /// <param name="inputDescriptions">The input descriptions.</param>
    /// <param name="requiredInputRectangles">The required input rectangles.</param>
    /// <exception cref="System.ArgumentException">Input length not the same as required - requiredInputRectangles</exception>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetEffectRequiredInputRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.D2D1_EFFECT_INPUT_DESCRIPTION[], Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectRequiredInputRectangles(this ID2D1DeviceContext1 @this, ID2D1Effect renderEffect, D2D_RECT_F? renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, Span<D2D_RECT_F> requiredInputRectangles)
    {
        fixed (D2D_RECT_F* requiredInputRectanglesLocal = requiredInputRectangles)
        {
            var renderImageRectangleLocal = renderImageRectangle.HasValue ? renderImageRectangle.Value : default;
            if (inputDescriptions.Length != requiredInputRectangles.Length) throw new ArgumentException("Input length not the same as required", nameof(requiredInputRectangles));
            @this.GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle.HasValue ? &renderImageRectangleLocal : null, inputDescriptions, requiredInputRectanglesLocal, (uint)requiredInputRectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect required input rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderEffect">The render effect.</param>
    /// <param name="renderImageRectangle">The render image rectangle.</param>
    /// <param name="inputDescriptions">The input descriptions.</param>
    /// <param name="requiredInputRectangles">The required input rectangles.</param>
    /// <exception cref="System.ArgumentException">Input length not the same as required - requiredInputRectangles</exception>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetEffectRequiredInputRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.D2D1_EFFECT_INPUT_DESCRIPTION[], Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectRequiredInputRectangles(this ID2D1DeviceContext2 @this, ID2D1Effect renderEffect, D2D_RECT_F? renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, Span<D2D_RECT_F> requiredInputRectangles)
    {
        fixed (D2D_RECT_F* requiredInputRectanglesLocal = requiredInputRectangles)
        {
            var renderImageRectangleLocal = renderImageRectangle.HasValue ? renderImageRectangle.Value : default;
            if (inputDescriptions.Length != requiredInputRectangles.Length) throw new ArgumentException("Input length not the same as required", nameof(requiredInputRectangles));
            @this.GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle.HasValue ? &renderImageRectangleLocal : null, inputDescriptions, requiredInputRectanglesLocal, (uint)requiredInputRectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect required input rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderEffect">The render effect.</param>
    /// <param name="renderImageRectangle">The render image rectangle.</param>
    /// <param name="inputDescriptions">The input descriptions.</param>
    /// <param name="requiredInputRectangles">The required input rectangles.</param>
    /// <exception cref="System.ArgumentException">Input length not the same as required - requiredInputRectangles</exception>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetEffectRequiredInputRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.D2D1_EFFECT_INPUT_DESCRIPTION[], Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectRequiredInputRectangles(this ID2D1DeviceContext3 @this, ID2D1Effect renderEffect, D2D_RECT_F? renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, Span<D2D_RECT_F> requiredInputRectangles)
    {
        fixed (D2D_RECT_F* requiredInputRectanglesLocal = requiredInputRectangles)
        {
            var renderImageRectangleLocal = renderImageRectangle.HasValue ? renderImageRectangle.Value : default;
            if (inputDescriptions.Length != requiredInputRectangles.Length) throw new ArgumentException("Input length not the same as required", nameof(requiredInputRectangles));
            @this.GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle.HasValue ? &renderImageRectangleLocal : null, inputDescriptions, requiredInputRectanglesLocal, (uint)requiredInputRectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect required input rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderEffect">The render effect.</param>
    /// <param name="renderImageRectangle">The render image rectangle.</param>
    /// <param name="inputDescriptions">The input descriptions.</param>
    /// <param name="requiredInputRectangles">The required input rectangles.</param>
    /// <exception cref="System.ArgumentException">Input length not the same as required - requiredInputRectangles</exception>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetEffectRequiredInputRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.D2D1_EFFECT_INPUT_DESCRIPTION[], Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectRequiredInputRectangles(this ID2D1DeviceContext4 @this, ID2D1Effect renderEffect, D2D_RECT_F? renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, Span<D2D_RECT_F> requiredInputRectangles)
    {
        fixed (D2D_RECT_F* requiredInputRectanglesLocal = requiredInputRectangles)
        {
            var renderImageRectangleLocal = renderImageRectangle.HasValue ? renderImageRectangle.Value : default;
            if (inputDescriptions.Length != requiredInputRectangles.Length) throw new ArgumentException("Input length not the same as required", nameof(requiredInputRectangles));
            @this.GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle.HasValue ? &renderImageRectangleLocal : null, inputDescriptions, requiredInputRectanglesLocal, (uint)requiredInputRectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect required input rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderEffect">The render effect.</param>
    /// <param name="renderImageRectangle">The render image rectangle.</param>
    /// <param name="inputDescriptions">The input descriptions.</param>
    /// <param name="requiredInputRectangles">The required input rectangles.</param>
    /// <exception cref="System.ArgumentException">Input length not the same as required - requiredInputRectangles</exception>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetEffectRequiredInputRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.D2D1_EFFECT_INPUT_DESCRIPTION[], Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectRequiredInputRectangles(this ID2D1DeviceContext5 @this, ID2D1Effect renderEffect, D2D_RECT_F? renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, Span<D2D_RECT_F> requiredInputRectangles)
    {
        fixed (D2D_RECT_F* requiredInputRectanglesLocal = requiredInputRectangles)
        {
            var renderImageRectangleLocal = renderImageRectangle.HasValue ? renderImageRectangle.Value : default;
            if (inputDescriptions.Length != requiredInputRectangles.Length) throw new ArgumentException("Input length not the same as required", nameof(requiredInputRectangles));
            @this.GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle.HasValue ? &renderImageRectangleLocal : null, inputDescriptions, requiredInputRectanglesLocal, (uint)requiredInputRectangles.Length);
        }
    }

    /// <summary>
    /// Gets the effect required input rectangles.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderEffect">The render effect.</param>
    /// <param name="renderImageRectangle">The render image rectangle.</param>
    /// <param name="inputDescriptions">The input descriptions.</param>
    /// <param name="requiredInputRectangles">The required input rectangles.</param>
    /// <exception cref="System.ArgumentException">Input length not the same as required - requiredInputRectangles</exception>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetEffectRequiredInputRectangles(ID2D1Effect, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, Windows.Win32.Graphics.Direct2D.D2D1_EFFECT_INPUT_DESCRIPTION[], Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, uint)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetEffectRequiredInputRectangles(this ID2D1DeviceContext6 @this, ID2D1Effect renderEffect, D2D_RECT_F? renderImageRectangle, D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, Span<D2D_RECT_F> requiredInputRectangles)
    {
        fixed (D2D_RECT_F* requiredInputRectanglesLocal = requiredInputRectangles)
        {
            var renderImageRectangleLocal = renderImageRectangle.HasValue ? renderImageRectangle.Value : default;
            if (inputDescriptions.Length != requiredInputRectangles.Length) throw new ArgumentException("Input length not the same as required", nameof(requiredInputRectangles));
            @this.GetEffectRequiredInputRectangles(renderEffect, renderImageRectangle.HasValue ? &renderImageRectangleLocal : null, inputDescriptions, requiredInputRectanglesLocal, (uint)requiredInputRectangles.Length);
        }
    }
    #endregion

    #region GetGlyphRunWorldBounds
    /// <summary>
    /// Gets the glyph run world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <param name="bounds">The bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.GetGlyphRunWorldBounds(D2D_POINT_2F, in DWRITE_GLYPH_RUN, DWRITE_MEASURING_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGlyphRunWorldBounds(this ID2D1DeviceContext @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds)
    {
        fixed (D2D_RECT_F* boundsLocal = &bounds)
        {
            @this.GetGlyphRunWorldBounds(baselineOrigin, in glyphRun, measuringMode, boundsLocal);
        }
    }

    /// <summary>
    /// Gets the glyph run world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <param name="bounds">The bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetGlyphRunWorldBounds(D2D_POINT_2F, in DWRITE_GLYPH_RUN, DWRITE_MEASURING_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGlyphRunWorldBounds(this ID2D1DeviceContext1 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds)
    {
        fixed (D2D_RECT_F* boundsLocal = &bounds)
        {
            @this.GetGlyphRunWorldBounds(baselineOrigin, in glyphRun, measuringMode, boundsLocal);
        }
    }

    /// <summary>
    /// Gets the glyph run world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <param name="bounds">The bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetGlyphRunWorldBounds(D2D_POINT_2F, in DWRITE_GLYPH_RUN, DWRITE_MEASURING_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGlyphRunWorldBounds(this ID2D1DeviceContext2 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds)
    {
        fixed (D2D_RECT_F* boundsLocal = &bounds)
        {
            @this.GetGlyphRunWorldBounds(baselineOrigin, in glyphRun, measuringMode, boundsLocal);
        }
    }

    /// <summary>
    /// Gets the glyph run world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <param name="bounds">The bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetGlyphRunWorldBounds(D2D_POINT_2F, in DWRITE_GLYPH_RUN, DWRITE_MEASURING_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGlyphRunWorldBounds(this ID2D1DeviceContext3 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds)
    {
        fixed (D2D_RECT_F* boundsLocal = &bounds)
        {
            @this.GetGlyphRunWorldBounds(baselineOrigin, in glyphRun, measuringMode, boundsLocal);
        }
    }

    /// <summary>
    /// Gets the glyph run world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <param name="bounds">The bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetGlyphRunWorldBounds(D2D_POINT_2F, in DWRITE_GLYPH_RUN, DWRITE_MEASURING_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGlyphRunWorldBounds(this ID2D1DeviceContext4 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds)
    {
        fixed (D2D_RECT_F* boundsLocal = &bounds)
        {
            @this.GetGlyphRunWorldBounds(baselineOrigin, in glyphRun, measuringMode, boundsLocal);
        }
    }

    /// <summary>
    /// Gets the glyph run world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <param name="bounds">The bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetGlyphRunWorldBounds(D2D_POINT_2F, in DWRITE_GLYPH_RUN, DWRITE_MEASURING_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGlyphRunWorldBounds(this ID2D1DeviceContext5 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds)
    {
        fixed (D2D_RECT_F* boundsLocal = &bounds)
        {
            @this.GetGlyphRunWorldBounds(baselineOrigin, in glyphRun, measuringMode, boundsLocal);
        }
    }

    /// <summary>
    /// Gets the glyph run world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="baselineOrigin">The baseline origin.</param>
    /// <param name="glyphRun">The glyph run.</param>
    /// <param name="measuringMode">The measuring mode.</param>
    /// <param name="bounds">The bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetGlyphRunWorldBounds(D2D_POINT_2F, in DWRITE_GLYPH_RUN, DWRITE_MEASURING_MODE, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetGlyphRunWorldBounds(this ID2D1DeviceContext6 @this, D2D_POINT_2F baselineOrigin, in DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, out D2D_RECT_F bounds)
    {
        fixed (D2D_RECT_F* boundsLocal = &bounds)
        {
            @this.GetGlyphRunWorldBounds(baselineOrigin, in glyphRun, measuringMode, boundsLocal);
        }
    }
    #endregion

    #region GetImageLocalBounds
    /// <summary>
    /// Gets the image local bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="localBounds">The local bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.GetImageLocalBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageLocalBounds(this ID2D1DeviceContext @this, ID2D1Image image, out D2D_RECT_F localBounds)
    {
        fixed (D2D_RECT_F* localBoundsLocal = &localBounds)
        {
            @this.GetImageLocalBounds(image, localBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image local bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="localBounds">The local bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetImageLocalBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageLocalBounds(this ID2D1DeviceContext1 @this, ID2D1Image image, out D2D_RECT_F localBounds)
    {
        fixed (D2D_RECT_F* localBoundsLocal = &localBounds)
        {
            @this.GetImageLocalBounds(image, localBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image local bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="localBounds">The local bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetImageLocalBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageLocalBounds(this ID2D1DeviceContext2 @this, ID2D1Image image, out D2D_RECT_F localBounds)
    {
        fixed (D2D_RECT_F* localBoundsLocal = &localBounds)
        {
            @this.GetImageLocalBounds(image, localBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image local bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="localBounds">The local bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetImageLocalBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageLocalBounds(this ID2D1DeviceContext3 @this, ID2D1Image image, out D2D_RECT_F localBounds)
    {
        fixed (D2D_RECT_F* localBoundsLocal = &localBounds)
        {
            @this.GetImageLocalBounds(image, localBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image local bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="localBounds">The local bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetImageLocalBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageLocalBounds(this ID2D1DeviceContext4 @this, ID2D1Image image, out D2D_RECT_F localBounds)
    {
        fixed (D2D_RECT_F* localBoundsLocal = &localBounds)
        {
            @this.GetImageLocalBounds(image, localBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image local bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="localBounds">The local bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetImageLocalBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageLocalBounds(this ID2D1DeviceContext5 @this, ID2D1Image image, out D2D_RECT_F localBounds)
    {
        fixed (D2D_RECT_F* localBoundsLocal = &localBounds)
        {
            @this.GetImageLocalBounds(image, localBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image local bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="localBounds">The local bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetImageLocalBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageLocalBounds(this ID2D1DeviceContext6 @this, ID2D1Image image, out D2D_RECT_F localBounds)
    {
        fixed (D2D_RECT_F* localBoundsLocal = &localBounds)
        {
            @this.GetImageLocalBounds(image, localBoundsLocal);
        }
    }
    #endregion

    #region GetImageWorldBounds
    /// <summary>
    /// Gets the image world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="worldBounds">The world bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.GetImageWorldBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageWorldBounds(this ID2D1DeviceContext @this, ID2D1Image image, out D2D_RECT_F worldBounds)
    {
        fixed (D2D_RECT_F* worldBoundsLocal = &worldBounds)
        {
            @this.GetImageWorldBounds(image, worldBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="worldBounds">The world bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetImageWorldBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageWorldBounds(this ID2D1DeviceContext1 @this, ID2D1Image image, out D2D_RECT_F worldBounds)
    {
        fixed (D2D_RECT_F* worldBoundsLocal = &worldBounds)
        {
            @this.GetImageWorldBounds(image, worldBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="worldBounds">The world bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetImageWorldBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageWorldBounds(this ID2D1DeviceContext2 @this, ID2D1Image image, out D2D_RECT_F worldBounds)
    {
        fixed (D2D_RECT_F* worldBoundsLocal = &worldBounds)
        {
            @this.GetImageWorldBounds(image, worldBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="worldBounds">The world bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetImageWorldBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageWorldBounds(this ID2D1DeviceContext3 @this, ID2D1Image image, out D2D_RECT_F worldBounds)
    {
        fixed (D2D_RECT_F* worldBoundsLocal = &worldBounds)
        {
            @this.GetImageWorldBounds(image, worldBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="worldBounds">The world bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetImageWorldBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageWorldBounds(this ID2D1DeviceContext4 @this, ID2D1Image image, out D2D_RECT_F worldBounds)
    {
        fixed (D2D_RECT_F* worldBoundsLocal = &worldBounds)
        {
            @this.GetImageWorldBounds(image, worldBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="worldBounds">The world bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetImageWorldBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageWorldBounds(this ID2D1DeviceContext5 @this, ID2D1Image image, out D2D_RECT_F worldBounds)
    {
        fixed (D2D_RECT_F* worldBoundsLocal = &worldBounds)
        {
            @this.GetImageWorldBounds(image, worldBoundsLocal);
        }
    }

    /// <summary>
    /// Gets the image world bounds.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="image">The image.</param>
    /// <param name="worldBounds">The world bounds.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetImageWorldBounds(ID2D1Image, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetImageWorldBounds(this ID2D1DeviceContext6 @this, ID2D1Image image, out D2D_RECT_F worldBounds)
    {
        fixed (D2D_RECT_F* worldBoundsLocal = &worldBounds)
        {
            @this.GetImageWorldBounds(image, worldBoundsLocal);
        }
    }
    #endregion

    #region GetPixelSize
    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1BitmapRenderTarget @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1RenderTarget.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1RenderTarget @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1HwndRenderTarget @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DCRenderTarget.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DCRenderTarget @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext1 @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext2 @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext3 @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext4 @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext5 @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size of the pixel.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetPixelSize(out D2D_SIZE_U)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_U GetPixelSize(this ID2D1DeviceContext6 @this)
    {
        @this.GetPixelSize(out var size);
        return size;
    }
    #endregion

    #region GetRenderingControls
    /// <summary>
    /// Gets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.GetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetRenderingControls(this ID2D1DeviceContext @this, out D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.GetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Gets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetRenderingControls(this ID2D1DeviceContext1 @this, out D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.GetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Gets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetRenderingControls(this ID2D1DeviceContext2 @this, out D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.GetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Gets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetRenderingControls(this ID2D1DeviceContext3 @this, out D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.GetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Gets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetRenderingControls(this ID2D1DeviceContext4 @this, out D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.GetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Gets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetRenderingControls(this ID2D1DeviceContext5 @this, out D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.GetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Gets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetRenderingControls(this ID2D1DeviceContext6 @this, out D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.GetRenderingControls(renderingControlsLocal);
        }
    }
    #endregion

    #region GetSize
    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1BitmapRenderTarget @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1RenderTarget.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1RenderTarget @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1HwndRenderTarget @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DCRenderTarget.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DCRenderTarget @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DeviceContext @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DeviceContext1 @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DeviceContext2 @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DeviceContext3 @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DeviceContext4 @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DeviceContext5 @this)
    {
        @this.GetSize(out var size);
        return size;
    }

    /// <summary>
    /// Gets the size.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetSize(out D2D_SIZE_F)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe D2D_SIZE_F GetSize(this ID2D1DeviceContext6 @this)
    {
        @this.GetSize(out var size);
        return size;
    }
    #endregion

    #region GetSvgGlyphImage
    /// <summary>
    /// Gets the SVG glyph image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="glyphOrigin">The glyph origin.</param>
    /// <param name="fontFace">The font face.</param>
    /// <param name="fontEmSize">Size of the font em.</param>
    /// <param name="glyphIndex">Index of the glyph.</param>
    /// <param name="isSideways">The is sideways.</param>
    /// <param name="worldTransform">The world transform.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="svgGlyphStyle">The SVG glyph style.</param>
    /// <param name="colorPaletteIndex">Index of the color palette.</param>
    /// <param name="glyphTransform">The glyph transform.</param>
    /// <param name="glyphImage">The glyph image.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetSvgGlyphImage(D2D_POINT_2F, IDWriteFontFace, float, ushort, Foundation.BOOL, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, ID2D1Brush, ID2D1SvgGlyphStyle, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, out ID2D1CommandList)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetSvgGlyphImage(this ID2D1DeviceContext4 @this, D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, Foundation.BOOL isSideways, D2D_MATRIX_3X2_F? worldTransform, ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1CommandList glyphImage)
    {
        fixed (D2D_MATRIX_3X2_F* glyphTransformLocal = &glyphTransform)
        {
            var worldTransformLocal = worldTransform.HasValue ? worldTransform.Value : default;
            @this.GetSvgGlyphImage(glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform.HasValue ? &worldTransformLocal : null, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformLocal, out glyphImage);
        }
    }

    /// <summary>
    /// Gets the SVG glyph image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="glyphOrigin">The glyph origin.</param>
    /// <param name="fontFace">The font face.</param>
    /// <param name="fontEmSize">Size of the font em.</param>
    /// <param name="glyphIndex">Index of the glyph.</param>
    /// <param name="isSideways">The is sideways.</param>
    /// <param name="worldTransform">The world transform.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="svgGlyphStyle">The SVG glyph style.</param>
    /// <param name="colorPaletteIndex">Index of the color palette.</param>
    /// <param name="glyphTransform">The glyph transform.</param>
    /// <param name="glyphImage">The glyph image.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetSvgGlyphImage(D2D_POINT_2F, IDWriteFontFace, float, ushort, Foundation.BOOL, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, ID2D1Brush, ID2D1SvgGlyphStyle, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, out ID2D1CommandList)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetSvgGlyphImage(this ID2D1DeviceContext5 @this, D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, Foundation.BOOL isSideways, D2D_MATRIX_3X2_F? worldTransform, ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1CommandList glyphImage)
    {
        fixed (D2D_MATRIX_3X2_F* glyphTransformLocal = &glyphTransform)
        {
            var worldTransformLocal = worldTransform.HasValue ? worldTransform.Value : default;
            @this.GetSvgGlyphImage(glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform.HasValue ? &worldTransformLocal : null, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformLocal, out glyphImage);
        }
    }

    /// <summary>
    /// Gets the SVG glyph image.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="glyphOrigin">The glyph origin.</param>
    /// <param name="fontFace">The font face.</param>
    /// <param name="fontEmSize">Size of the font em.</param>
    /// <param name="glyphIndex">Index of the glyph.</param>
    /// <param name="isSideways">The is sideways.</param>
    /// <param name="worldTransform">The world transform.</param>
    /// <param name="defaultFillBrush">The default fill brush.</param>
    /// <param name="svgGlyphStyle">The SVG glyph style.</param>
    /// <param name="colorPaletteIndex">Index of the color palette.</param>
    /// <param name="glyphTransform">The glyph transform.</param>
    /// <param name="glyphImage">The glyph image.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetSvgGlyphImage(D2D_POINT_2F, IDWriteFontFace, float, ushort, Foundation.BOOL, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, ID2D1Brush, ID2D1SvgGlyphStyle, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*, out ID2D1CommandList)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetSvgGlyphImage(this ID2D1DeviceContext6 @this, D2D_POINT_2F glyphOrigin, IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, Foundation.BOOL isSideways, D2D_MATRIX_3X2_F? worldTransform, ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, out D2D_MATRIX_3X2_F glyphTransform, out ID2D1CommandList glyphImage)
    {
        fixed (D2D_MATRIX_3X2_F* glyphTransformLocal = &glyphTransform)
        {
            var worldTransformLocal = worldTransform.HasValue ? worldTransform.Value : default;
            @this.GetSvgGlyphImage(glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform.HasValue ? &worldTransformLocal : null, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformLocal, out glyphImage);
        }
    }
    #endregion

    #region GetTransform
    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1BitmapRenderTarget @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1RenderTarget @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1HwndRenderTarget @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DCRenderTarget @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DeviceContext @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DeviceContext1 @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DeviceContext2 @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DeviceContext3 @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DeviceContext4 @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DeviceContext5 @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Gets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.GetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void GetTransform(this ID2D1DeviceContext6 @this, out D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.GetTransform(transformLocal);
        }
    }
    #endregion

    #region InvalidateEffectInputRectangle
    /// <summary>
    /// Invalidates the effect input rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="input">The input.</param>
    /// <param name="inputRectangle">The input rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.InvalidateEffectInputRectangle(ID2D1Effect, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void InvalidateEffectInputRectangle(this ID2D1DeviceContext @this, ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle)
    {
        fixed (D2D_RECT_F* inputRectangleLocal = &inputRectangle)
        {
            @this.InvalidateEffectInputRectangle(effect, input, inputRectangleLocal);
        }
    }

    /// <summary>
    /// Invalidates the effect input rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="input">The input.</param>
    /// <param name="inputRectangle">The input rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.InvalidateEffectInputRectangle(ID2D1Effect, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void InvalidateEffectInputRectangle(this ID2D1DeviceContext1 @this, ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle)
    {
        fixed (D2D_RECT_F* inputRectangleLocal = &inputRectangle)
        {
            @this.InvalidateEffectInputRectangle(effect, input, inputRectangleLocal);
        }
    }

    /// <summary>
    /// Invalidates the effect input rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="input">The input.</param>
    /// <param name="inputRectangle">The input rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.InvalidateEffectInputRectangle(ID2D1Effect, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void InvalidateEffectInputRectangle(this ID2D1DeviceContext2 @this, ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle)
    {
        fixed (D2D_RECT_F* inputRectangleLocal = &inputRectangle)
        {
            @this.InvalidateEffectInputRectangle(effect, input, inputRectangleLocal);
        }
    }

    /// <summary>
    /// Invalidates the effect input rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="input">The input.</param>
    /// <param name="inputRectangle">The input rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.InvalidateEffectInputRectangle(ID2D1Effect, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void InvalidateEffectInputRectangle(this ID2D1DeviceContext3 @this, ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle)
    {
        fixed (D2D_RECT_F* inputRectangleLocal = &inputRectangle)
        {
            @this.InvalidateEffectInputRectangle(effect, input, inputRectangleLocal);
        }
    }

    /// <summary>
    /// Invalidates the effect input rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="input">The input.</param>
    /// <param name="inputRectangle">The input rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.InvalidateEffectInputRectangle(ID2D1Effect, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void InvalidateEffectInputRectangle(this ID2D1DeviceContext4 @this, ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle)
    {
        fixed (D2D_RECT_F* inputRectangleLocal = &inputRectangle)
        {
            @this.InvalidateEffectInputRectangle(effect, input, inputRectangleLocal);
        }
    }

    /// <summary>
    /// Invalidates the effect input rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="input">The input.</param>
    /// <param name="inputRectangle">The input rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.InvalidateEffectInputRectangle(ID2D1Effect, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void InvalidateEffectInputRectangle(this ID2D1DeviceContext5 @this, ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle)
    {
        fixed (D2D_RECT_F* inputRectangleLocal = &inputRectangle)
        {
            @this.InvalidateEffectInputRectangle(effect, input, inputRectangleLocal);
        }
    }

    /// <summary>
    /// Invalidates the effect input rectangle.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="effect">The effect.</param>
    /// <param name="input">The input.</param>
    /// <param name="inputRectangle">The input rectangle.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.InvalidateEffectInputRectangle(ID2D1Effect, uint, Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void InvalidateEffectInputRectangle(this ID2D1DeviceContext6 @this, ID2D1Effect effect, uint input, in D2D_RECT_F inputRectangle)
    {
        fixed (D2D_RECT_F* inputRectangleLocal = &inputRectangle)
        {
            @this.InvalidateEffectInputRectangle(effect, input, inputRectangleLocal);
        }
    }
    #endregion

    #region IsSupported
    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1BitmapRenderTarget @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1RenderTarget.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1RenderTarget @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1HwndRenderTarget @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DCRenderTarget.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DCRenderTarget @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DeviceContext @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext1.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DeviceContext1 @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext2.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DeviceContext2 @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext3.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DeviceContext3 @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext4.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DeviceContext4 @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext5.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DeviceContext5 @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }

    /// <summary>
    /// Determines whether the specified render target properties is supported.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderTargetProperties">The render target properties.</param>
    /// <returns></returns>
    /// <inheritdoc cref="ID2D1DeviceContext6.IsSupported(Windows.Win32.Graphics.Direct2D.D2D1_RENDER_TARGET_PROPERTIES*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe Foundation.BOOL IsSupported(this ID2D1DeviceContext6 @this, in D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties)
    {
        fixed (D2D1_RENDER_TARGET_PROPERTIES* renderTargetPropertiesLocal = &renderTargetProperties)
        {
            var __result = @this.IsSupported(renderTargetPropertiesLocal);
            return __result;
        }
    }
    #endregion

    #region PushAxisAlignedClip
    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1BitmapRenderTarget @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1RenderTarget @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1HwndRenderTarget @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DCRenderTarget @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DeviceContext @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DeviceContext1 @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DeviceContext2 @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DeviceContext3 @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DeviceContext4 @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DeviceContext5 @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }

    /// <summary>
    /// Pushes the axis aligned clip.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="clipRect">The clip rect.</param>
    /// <param name="antialiasMode">The antialias mode.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.PushAxisAlignedClip(Windows.Win32.Graphics.Direct2D.Common.D2D_RECT_F*, D2D1_ANTIALIAS_MODE)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void PushAxisAlignedClip(this ID2D1DeviceContext6 @this, in D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
    {
        fixed (D2D_RECT_F* clipRectLocal = &clipRect)
        {
            @this.PushAxisAlignedClip(clipRectLocal, antialiasMode);
        }
    }
    #endregion

    #region SetRenderingControls
    /// <summary>
    /// Sets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.SetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetRenderingControls(this ID2D1DeviceContext @this, in D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.SetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Sets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.SetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetRenderingControls(this ID2D1DeviceContext1 @this, in D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.SetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Sets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.SetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetRenderingControls(this ID2D1DeviceContext2 @this, in D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.SetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Sets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.SetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetRenderingControls(this ID2D1DeviceContext3 @this, in D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.SetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Sets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.SetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetRenderingControls(this ID2D1DeviceContext4 @this, in D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.SetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Sets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.SetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetRenderingControls(this ID2D1DeviceContext5 @this, in D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.SetRenderingControls(renderingControlsLocal);
        }
    }

    /// <summary>
    /// Sets the rendering controls.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="renderingControls">The rendering controls.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.SetRenderingControls(Windows.Win32.Graphics.Direct2D.D2D1_RENDERING_CONTROLS*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetRenderingControls(this ID2D1DeviceContext6 @this, in D2D1_RENDERING_CONTROLS renderingControls)
    {
        fixed (D2D1_RENDERING_CONTROLS* renderingControlsLocal = &renderingControls)
        {
            @this.SetRenderingControls(renderingControlsLocal);
        }
    }
    #endregion

    #region SetTransform
    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1BitmapRenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1BitmapRenderTarget @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1RenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1RenderTarget @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1HwndRenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1HwndRenderTarget @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DCRenderTarget.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows6.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DCRenderTarget @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows8.0")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext1.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows8.1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext1 @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext2.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext2 @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext3.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext3 @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext4.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext4 @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext5.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext5 @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }

    /// <summary>
    /// Sets the transform.
    /// </summary>
    /// <param name="this">The this.</param>
    /// <param name="transform">The transform.</param>
    /// <inheritdoc cref="ID2D1DeviceContext6.SetTransform(Windows.Win32.Graphics.Direct2D.Common.D2D_MATRIX_3X2_F*)" />
    [SupportedOSPlatform("windows10.0.10240")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static unsafe void SetTransform(this ID2D1DeviceContext6 @this, in D2D_MATRIX_3X2_F transform)
    {
        fixed (D2D_MATRIX_3X2_F* transformLocal = &transform)
        {
            @this.SetTransform(transformLocal);
        }
    }
    #endregion
    #endregion
#pragma warning restore IDE0030 // Use coalesce expression
}
