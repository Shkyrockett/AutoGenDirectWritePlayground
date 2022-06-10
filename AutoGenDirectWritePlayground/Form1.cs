// <copyright file="Form1.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;
using Windows.Win32.Graphics.Dxgi.Common;

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
    /// The text format
    /// </summary>
    protected IDWriteTextFormat? textFormat;

    /// <summary>
    /// The text layout
    /// </summary>
    protected IDWriteTextLayout? textLayout;

    /// <summary>
    /// The typography
    /// </summary>
    protected IDWriteTypography? typography;

    /// <summary>
    /// The black brush
    /// </summary>
    protected ID2D1SolidColorBrush? blackBrush;

    /// <summary>
    /// The resources valid
    /// </summary>
    private bool resourcesValid;

    /// <summary>
    /// The render target
    /// </summary>
    private ID2D1DCRenderTarget? dcRenderTarget;
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="Form1"/> class.
    /// </summary>
    public Form1()
    {
        InitializeComponent();
        dcRenderTarget ??= InitializeDirect2DResources();
        DoSizeLayout(Size);
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

    /// <summary>
    /// Form resize event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The e.</param>
    private void Form1_Resize(object sender, EventArgs e) => DoSizeLayout((sender as Control)!.Size!);

    /// <summary>
    /// Applied resizing to the text layout area.
    /// </summary>
    /// <param name="size">The size.</param>
    private void DoSizeLayout(Size size)
    {
        textLayout?.SetMaxSize(size);
        Invalidate();
    }

    /// <summary>
    /// Paints the form.
    /// </summary>
    /// <param name="e">The e.</param>
    protected unsafe override void OnPaint(PaintEventArgs e)
    {
        dcRenderTarget ??= InitializeDirect2DResources(); // recreate resources if they have become invalid.
        dcRenderTarget?.BindDC(e.Graphics, e.ClipRectangle);
        RenderTarget?.BeginDraw();
        DoDrawing(RenderTarget!);
        var result = RenderTarget?.EndDraw();
        Validate();

        if (result == HRESULT.D2DERR_RECREATE_TARGET)
        {
            DiscardDirect2DResources();
        }

        base.OnPaint(e);
    }

    ///// <summary>
    ///// Ons the paint background.
    ///// </summary>
    ///// <param name="e">The e.</param>
    //protected unsafe override void OnPaintBackground(PaintEventArgs e)
    //{
    //    dcRenderTarget ??= InitializeDirect2DResources(); // recreate resources if they have become invalid.
    //    dcRenderTarget?.BindDC(e.Graphics, e.ClipRectangle);
    //    RenderTarget?.BeginDraw();
    //    RenderTarget?.Clear(this.BackColor);
    //    var result = RenderTarget?.EndDraw();
    //    Validate();

    //    if (result == HRESULT.D2DERR_RECREATE_TARGET)
    //    {
    //        DiscardDirect2DResources();
    //    }

    //    //base.OnPaintBackground(e);
    //}

    /// <summary>
    /// Does the drawing.
    /// </summary>
    private void DoDrawing(ID2D1RenderTarget renderTarget)
    {
        renderTarget?.SetTransform();
        //renderTarget?.Clear(Color.CornflowerBlue);
        renderTarget?.DrawTextLayout(default, textLayout!, blackBrush!, D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT);
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
        Marshal.ReleaseComObject(dcRenderTarget!);
        Marshal.ReleaseComObject(blackBrush!);
        Marshal.ReleaseComObject(textFormat!);
        Marshal.ReleaseComObject(textLayout!);
        Marshal.ReleaseComObject(typography!);
        dcRenderTarget = null;
        resourcesValid = false;
    }

    /// <summary>
    /// Initializes Direct2D for use with a GDI DC.
    /// </summary>
    private unsafe ID2D1DCRenderTarget? InitializeDirect2DResources()
    {
        if (!resourcesValid)
        {
            var renderTargetProperties = new D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_DEFAULT, new D2D1_PIXEL_FORMAT(DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM, D2D1_ALPHA_MODE.D2D1_ALPHA_MODE_IGNORE), 0, 0, 0, 0);
            dcRenderTarget = Direct2dFactory?.CreateDCRenderTarget(renderTargetProperties);
            CreateResources(dcRenderTarget);
            resourcesValid = true;
        }
        return dcRenderTarget;
    }

    /// <summary>
    /// Initializes Direct2D for use with a GDI DC.
    /// </summary>
    private unsafe void CreateResources(ID2D1RenderTarget? renderTarget)
    {
        var text = "Hello c# World 🌎 From ... DirectWrite!";
        blackBrush = renderTarget?.CreateSolidColorBrush(Color.Black);

        textFormat = DirectWriteFactory?.CreateTextFormat("Gabriola", fontSize: 64);
        textFormat?.SetTextAlignment(DWRITE_TEXT_ALIGNMENT.DWRITE_TEXT_ALIGNMENT_CENTER);
        textFormat?.SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT.DWRITE_PARAGRAPH_ALIGNMENT_CENTER);

        textLayout = DirectWriteFactory?.CreateTextLayout(text, textFormat, renderTarget?.GetSize() ?? default);

        var textTypographyRange = new DWRITE_TEXT_RANGE(0u, (uint)text.Length);
        typography = DirectWriteFactory?.CreateTypography();
        typography?.AddFontFeature(new DWRITE_FONT_FEATURE(DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7, 1));
        textLayout?.SetTypography(typography, textTypographyRange);

        // (27, 12) is the text range around "DirectWrite!"
        var textDirectWriteRange = new DWRITE_TEXT_RANGE(27u, 12u);
        textLayout?.SetFontSize(100, textDirectWriteRange);
        textLayout?.SetUnderline(true, textDirectWriteRange);
        textLayout?.SetFontWeight(DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_BOLD, textDirectWriteRange);
    }
}
