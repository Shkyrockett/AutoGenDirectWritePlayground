// <copyright file="Form1.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;
using Windows.Win32.Graphics.Dxgi.Common;
using Windows.Win32.Graphics.Gdi;

namespace AutoGenDirectWritePlayground;

/// <summary>
/// The form1.
/// </summary>
/// <seealso cref="Form" />
public partial class Form1
    : Form
{
#region Fields
    /// <summary>
    /// The text format.
    /// </summary>
    protected IDWriteTextFormat? textFormat;

    /// <summary>
    /// The text layout.
    /// </summary>
    protected IDWriteTextLayout? textLayout;

    /// <summary>
    /// The typography.
    /// </summary>
    protected IDWriteTypography? typography;

    /// <summary>
    /// The typography 2.
    /// </summary>
    protected IDWriteTypography? typography2;

    /// <summary>
    /// The black brush.
    /// </summary>
    protected ID2D1SolidColorBrush? blackBrush;

    /// <summary>
    /// The green brush.
    /// </summary>
    protected ID2D1SolidColorBrush? greenBrush;

    ///// <summary>
    ///// The outline brush
    ///// </summary>
    //protected ID2D1Brush? outlineBrush;

    /// <summary>
    /// The fill brush
    /// </summary>
    protected ID2D1Brush? fillBrush;

    /// <summary>
    /// The gradient stops.
    /// </summary>
    protected ID2D1GradientStopCollection? gradientStops;

    /// <summary>
    /// The render target.
    /// </summary>
    private ID2D1DCRenderTarget? dcRenderTarget;

    /// <summary>
    /// Index of the current world emoji to use.
    /// </summary>
    private int worldIndex = 0;

    /// <summary>
    /// Array of world emoji.
    /// </summary>
    private readonly string[] worlds = { "🌎", "🌍", "🌏" };

    private bool updating;
#endregion

#region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// </summary>
    public Form1()
    {
        InitializeComponent();

        dcRenderTarget ??= InitializeDirect2DDCRenderTarget();
        CreateResources(RenderTarget);
        DoSizeLayout(ClientSize);

        // Set the number of ticks to refresh the world.
        timer.Interval = 500;//50;

        // Start the world update timer if it isn't in design mode.
        timer.Start();
    }
#endregion

#region Properties
    /// <summary>
    /// Gets the direct2d factory.
    /// </summary>
    /// <value>
    /// The direct2d factory.
    /// </value>
    protected static ID2D1Factory7? Direct2dFactory { get; } = Direct2d.CreateFactory7();

    /// <summary>
    /// Gets the direct write factory.
    /// </summary>
    /// <value>
    /// The direct write factory.
    /// </value>
    protected static IDWriteFactory7? DirectWriteFactory { get; } = DirectWrite.CreateFactory7();

    /// <summary>
    /// Gets the render target.
    /// </summary>
    /// <value>
    /// The render target.
    /// </value>
    protected ID2D1RenderTarget? RenderTarget => dcRenderTarget;
#endregion

#region Events
    /// <summary>
    /// Form resize event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The e.</param>
    private void Form1_Resize(object sender, EventArgs e) => DoSizeLayout((sender as Control)!.ClientSize!);

    /// <summary>
    /// timer tick.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The e.</param>
    private void Timer_Tick(object sender, EventArgs e)
    {
        Text = $"Auto Generated DirectWrite Playground {worlds[worldIndex]}";
        if (dcRenderTarget is not null)
        {
            CreateResources(RenderTarget);
            Invalidate();
        }

        worldIndex++;
        if (worldIndex > 2) worldIndex = 0;
    }

    /// <summary>
    /// Paints the form.
    /// </summary>
    /// <param name="e">The e.</param>
    protected override unsafe void OnPaint(PaintEventArgs e)
    {
        //dcRenderTarget ??= InitializeDirect2DDCRenderTarget();// Recreate resources if they have become invalid.
        if (dcRenderTarget is not null)
        {
            var hdc = e.Graphics.GetHdc();

            bindDc(dcRenderTarget!, new HDC(hdc), ClientRectangle);
            //dcRenderTarget?.BindDC(new HDC(hdc), ClientRectangle);

            e.Graphics.ReleaseHdc(hdc);
            RenderTarget?.BeginDraw();
            DoDrawing(RenderTarget!);
#if GenerateRenderTarget
            RenderTarget?.EndDraw();
#else
            var result = RenderTarget?.EndDraw();
#endif
            Validate();

#if !GenerateRenderTarget
            if (result == HRESULT.D2DERR_RECREATE_TARGET)
            {
                DiscardDirect2DResources();
                dcRenderTarget ??= InitializeDirect2DDCRenderTarget(); // Recreate resources if they have become invalid.
                CreateResources(RenderTarget);
                DoSizeLayout(ClientSize);
            }
#endif
        }

        base.OnPaint(e);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static void bindDc(ID2D1DCRenderTarget dcRenderTarget, HDC hdc, in RECT rect)
        {
            fixed (RECT* r = &rect)
            {
                dcRenderTarget?.BindDC(hdc, r);
            }
        }
    }

    /// <summary>
    /// Paints the background.
    /// </summary>
    /// <param name="e">The e.</param>
    protected override unsafe void OnPaintBackground(PaintEventArgs e)
    {
        //dcRenderTarget ??= InitializeDirect2DDCRenderTarget();// Recreate resources if they have become invalid.
        if (dcRenderTarget is not null)
        {
            var hdc = e.Graphics.GetHdc();

            bindDc(dcRenderTarget!, new HDC(hdc), ClientRectangle);
            //dcRenderTarget?.BindDC(new HDC(hdc), ClientRectangle);

            e.Graphics.ReleaseHdc(hdc);
            RenderTarget?.BeginDraw();
            RenderTarget?.Clear(BackColor);
#if GenerateRenderTarget
            RenderTarget?.EndDraw();
#else
            var result = RenderTarget?.EndDraw();
#endif
            Validate();

#if !GenerateRenderTarget
            if (result == HRESULT.D2DERR_RECREATE_TARGET)
            {
                DiscardDirect2DResources();
                dcRenderTarget ??= InitializeDirect2DDCRenderTarget(); // Recreate resources if they have become invalid.
                CreateResources(RenderTarget);
                DoSizeLayout(ClientSize);
            }
#endif
        }

        base.OnPaintBackground(e);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static void bindDc(ID2D1DCRenderTarget dcRenderTarget, HDC hdc, in RECT rect)
        {
            fixed (RECT* r = &rect)
            {
                dcRenderTarget?.BindDC(hdc, r);
            }
        }
    }
#endregion

    /// <summary>
    /// Applied resizing to the text layout area.
    /// </summary>
    /// <param name="size">The size.</param>
    private void DoSizeLayout(Size size)
    {
        if (dcRenderTarget is not null)
        {
            textLayout?.SetMaxSize(size);
            CreateResizedResources(dcRenderTarget, size);
            Invalidate();
        }
    }

    /// <summary>
    /// Does the drawing.
    /// </summary>
    private void DoDrawing(ID2D1RenderTarget renderTarget)
    {
        renderTarget?.SetTransform();
        if (textLayout is not null && blackBrush is not null)
            renderTarget?.DrawTextLayout(new(), textLayout, blackBrush, D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT);
        //renderTarget?.FillRectangle(new D2D_RECT_F(50f, 50f, 100f, 100f), blackBrush!);
        //renderTarget?.DrawRectangle(new D2D_RECT_F(50f, 50f, 100f, 100f), blackBrush!, 1f, default!);
        //renderTarget?.FillEllipse(new D2D1_ELLIPSE(new D2D_POINT_2F(100f, 100f), 50f, 100f), blackBrush!);
        //renderTarget?.DrawEllipse(new D2D1_ELLIPSE(new D2D_POINT_2F(100f, 100f), 50f, 100f), blackBrush!, 1f, default!);
        //renderTarget?.FillRoundedRectangle(new D2D1_ROUNDED_RECT(new D2D_RECT_F(50f, 50f, 150f, 150f), 10f, 10f), blackBrush!);
        //renderTarget?.DrawRoundedRectangle(new D2D1_ROUNDED_RECT(new D2D_RECT_F(50f, 50f, 150f, 150f), 10f, 10f), blackBrush!, 1f, default!);
        //renderTarget?.DrawLine(new D2D_POINT_2F(50f, 50f), new D2D_POINT_2F(100f, 100f), blackBrush!, 1f, default!);
    }

    /// <summary>
    /// Discards the device resources.
    /// </summary>
    private unsafe void DiscardDirect2DResources()
    {
        if (blackBrush is not null)
        {
            Marshal.ReleaseComObject(blackBrush!);
            blackBrush = null;
        }
        if (greenBrush is not null)
        {
            Marshal.ReleaseComObject(greenBrush!);
            greenBrush = null;
        }
        //if (outlineBrush is not null)
        //{
        //    Marshal.ReleaseComObject(outlineBrush!);
        //    outlineBrush = null;
        //}
        if (fillBrush is not null)
        {
            Marshal.ReleaseComObject(fillBrush!);
            fillBrush = null;
        }
        if (gradientStops is not null)
        {
            Marshal.ReleaseComObject(gradientStops!);
            gradientStops = null;
        }
        if (textFormat is not null)
        {
            Marshal.ReleaseComObject(textFormat!);
            textFormat = null;
        }
        if (typography is not null)
        {
            Marshal.ReleaseComObject(typography!);
            typography = null;
        }
        if (typography2 is not null)
        {
            Marshal.ReleaseComObject(typography2!);
            typography2 = null;
        }
        if (textLayout is not null)
        {
            Marshal.ReleaseComObject(textLayout!);
            textLayout = null;
        }
        if (dcRenderTarget is not null)
        {
            Marshal.ReleaseComObject(dcRenderTarget!);
            dcRenderTarget = null;
        }
    }

    /// <summary>
    /// Initializes Direct2D for use with a GDI DC.
    /// </summary>
    private static unsafe ID2D1DCRenderTarget? InitializeDirect2DDCRenderTarget()
    {
        const D2D1_RENDER_TARGET_TYPE type = D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_DEFAULT;
        const DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM;
        const D2D1_ALPHA_MODE alphaMode = D2D1_ALPHA_MODE.D2D1_ALPHA_MODE_IGNORE;
        var pixelFormat = new D2D1_PIXEL_FORMAT(format, alphaMode);
        const D2D1_RENDER_TARGET_USAGE usage = D2D1_RENDER_TARGET_USAGE.D2D1_RENDER_TARGET_USAGE_GDI_COMPATIBLE;
        const D2D1_FEATURE_LEVEL featureLevel = D2D1_FEATURE_LEVEL.D2D1_FEATURE_LEVEL_DEFAULT;
        var renderTargetProperties = new D2D1_RENDER_TARGET_PROPERTIES(type, pixelFormat, 0, 0, usage, featureLevel);
        var dcRenderTarget = Direct2dFactory?.CreateDCRenderTarget(renderTargetProperties);
        return dcRenderTarget!;
    }

    /// <summary>
    /// Creates the gradient.
    /// </summary>
    /// <param name="renderTarget">The render target.</param>
    /// <param name="size"></param>
    private unsafe void CreateResizedResources(ID2D1RenderTarget? renderTarget, Size size)
    {
        // Gradient brush
        ReadOnlySpan<D2D1_GRADIENT_STOP> stops = stackalloc[]
        {
            new D2D1_GRADIENT_STOP(0.0f, Color.Gold),
            new D2D1_GRADIENT_STOP(0.85f, Color.FromArgb((int)(255f * 0.8f), Color.Orange)),
            new D2D1_GRADIENT_STOP(1.0f, Color.FromArgb((int)(255f * 0.7f), Color.OrangeRed))
        };

        var center = new PointF(size.Width / 2f, size.Height / 2f);
        var gradientOriginOffset = new PointF(size.Width / 4f, size.Height / 4f);
        var (radiusX, radiusY) = (Math.Max(size.Width / 2f, size.Height / 2f), Math.Max(size.Width / 2f, size.Height / 2f));
        var radialBrushProperties = new D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES(center, gradientOriginOffset, radiusX, radiusY);
        if (gradientStops is not null) Marshal.ReleaseComObject(gradientStops);
#pragma warning disable CS7036 // There is no argument given that corresponds to the required parameter 'gradientStopsCount' of 'ID2D1RenderTarget.CreateGradientStopCollection(D2D1_GRADIENT_STOP*, uint, D2D1_GAMMA, D2D1_EXTEND_MODE, out ID2D1GradientStopCollection)'
        gradientStops = renderTarget?.CreateGradientStopCollection(stops);
#pragma warning restore CS7036 // There is no argument given that corresponds to the required parameter 'gradientStopsCount' of 'ID2D1RenderTarget.CreateGradientStopCollection(D2D1_GRADIENT_STOP*, uint, D2D1_GAMMA, D2D1_EXTEND_MODE, out ID2D1GradientStopCollection)'

        if (fillBrush is not null) Marshal.ReleaseComObject(fillBrush);
#pragma warning disable CS7036 // There is no argument given that corresponds to the required parameter 'gradientStopCollection' of 'ID2D1RenderTarget.CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)'
        fillBrush = renderTarget?.CreateRadialGradientBrush(radialBrushProperties, gradientStops!);
#pragma warning restore CS7036 // There is no argument given that corresponds to the required parameter 'gradientStopCollection' of 'ID2D1RenderTarget.CreateRadialGradientBrush(D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection, out ID2D1RadialGradientBrush)'
    }

    /// <summary>
    /// Initializes Direct2D for use with a GDI DC.
    /// </summary>
    private unsafe void CreateResources(ID2D1RenderTarget? renderTarget)
    {
        if (updating) return;
        updating = true;
        var world = worlds[worldIndex];
        var text = $"Hello World {world} from… \r\nDirectWrite \r\n…using only  C#!";
        if (blackBrush is not null) Marshal.ReleaseComObject(blackBrush);
#pragma warning disable CS7036 // There is no argument given that corresponds to the required parameter 'solidColorBrush' of 'ID2D1RenderTarget.CreateSolidColorBrush(D2D1_COLOR_F*, D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)'
        blackBrush = renderTarget?.CreateSolidColorBrush(Color.Black);
#pragma warning restore CS7036 // There is no argument given that corresponds to the required parameter 'solidColorBrush' of 'ID2D1RenderTarget.CreateSolidColorBrush(D2D1_COLOR_F*, D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)'
        if (greenBrush is not null) Marshal.ReleaseComObject(greenBrush);
#pragma warning disable CS7036 // There is no argument given that corresponds to the required parameter 'solidColorBrush' of 'ID2D1RenderTarget.CreateSolidColorBrush(D2D1_COLOR_F*, D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)'
        greenBrush = renderTarget?.CreateSolidColorBrush(Color.Green);
#pragma warning restore CS7036 // There is no argument given that corresponds to the required parameter 'solidColorBrush' of 'ID2D1RenderTarget.CreateSolidColorBrush(D2D1_COLOR_F*, D2D1_BRUSH_PROPERTIES*, out ID2D1SolidColorBrush)'

        if (textFormat is not null) Marshal.ReleaseComObject(textFormat);
        textFormat = DirectWriteFactory?.CreateTextFormat("Gabriola", fontSize: 64f);
        textFormat?.SetTextAlignment(DWRITE_TEXT_ALIGNMENT.DWRITE_TEXT_ALIGNMENT_CENTER);
        textFormat?.SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT.DWRITE_PARAGRAPH_ALIGNMENT_CENTER);

        if (typography is not null) Marshal.ReleaseComObject(typography);
        typography = DirectWriteFactory?.CreateTypography();
        typography?.AddFontFeature(new DWRITE_FONT_FEATURE(DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7, 1));

        if (typography2 is not null) Marshal.ReleaseComObject(typography2);
        typography2 = DirectWriteFactory?.CreateTypography();
        typography2?.AddFontFeature(new DWRITE_FONT_FEATURE(DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_6, 1));

        if (textLayout is not null) Marshal.ReleaseComObject(textLayout);
        textLayout = DirectWriteFactory?.CreateTextLayout(text, textFormat, renderTarget?.GetSize() ?? default);

        // (0, ^) is the entire string.
        var textTypographyRange = new DWRITE_TEXT_RANGE(0u, (uint)text.Length);
        textLayout?.SetTypography(typography, textTypographyRange);

        // (23, 11) is the text range around "DirectWrite".
        var textDirectWriteRange = new DWRITE_TEXT_RANGE(23u, 11u);
        textLayout?.SetFontSize(100, textDirectWriteRange);
        textLayout?.SetUnderline(true, textDirectWriteRange);
        textLayout?.SetFontWeight(DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_BOLD, textDirectWriteRange);
        textLayout?.SetDrawingEffect(fillBrush, textDirectWriteRange);

        // (36, 11) is the text range around "using only".
        var textUsingOnlyWriteRange = new DWRITE_TEXT_RANGE(36u, 11u);
        textLayout?.SetTypography(typography2, textUsingOnlyWriteRange);

        // (50, 2) is the text range around "C#".
        var cSharpDirectWriteRange = new DWRITE_TEXT_RANGE(50u, 2u);
        textLayout?.SetUnderline(true, cSharpDirectWriteRange);
        textLayout?.SetFontStyle(DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_ITALIC, cSharpDirectWriteRange);
        textLayout?.SetFontFamilyName("Cascadia Mono", cSharpDirectWriteRange);
        textLayout?.SetDrawingEffect(greenBrush, cSharpDirectWriteRange);

        // (52, 1) is the text range around "!".
        var exclaimDirectWriteRange = new DWRITE_TEXT_RANGE(52u, 1u);
        textLayout?.SetFontWeight(DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_BOLD, exclaimDirectWriteRange);
        updating = false;
    }
}
