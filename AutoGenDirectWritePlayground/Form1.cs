// <copyright file="Form1.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using AutoGenDirectWriteLibrary;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;
using Windows.Win32.Graphics.Dxgi.Common;

namespace AutoGenDirectWritePlayground
{
    /// <summary>
    /// The form1.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
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

        /// <summary>
        /// The render target
        /// </summary>
        private ID2D1HwndRenderTarget? handleRenderTarget;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            textFormat = DirectWriteFactory?.CreateTextFormat("Gabriola", fontSize: 64);
            textFormat?.SetTextAlignment(DWRITE_TEXT_ALIGNMENT.DWRITE_TEXT_ALIGNMENT_CENTER);
            textFormat?.SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT.DWRITE_PARAGRAPH_ALIGNMENT_CENTER);
            InitializeDirect2D();
            DoSize(Size);
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the direct2d factory.
        /// </summary>
        /// <value>
        /// The direct2d factory.
        /// </value>
        protected static ID2D1Factory? Direct2dFactory { get; } = Direct2d.CreateFactory();

        /// <summary>
        /// Gets the direct write factory.
        /// </summary>
        /// <value>
        /// The direct write factory.
        /// </value>
        protected static IDWriteFactory? DirectWriteFactory { get; } = DirectWrite.CreateFactory();

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
        private void Form1_Resize(object sender, EventArgs e)
        {
            var s = (Control)sender;
            InitializeDirect2D();
            DoSize(s!.Size!);
        }

        /// <summary>
        /// Applied resizing to the text layout area.
        /// </summary>
        /// <param name="size">The size.</param>
        private void DoSize(Size size)
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
            InitializeDirect2D(e.Graphics, e.ClipRectangle);
            RenderTarget?.BeginDraw();
            DoDrawing();
            var result = RenderTarget?.EndDraw();
            Validate();

            if (result == HRESULT.D2DERR_RECREATE_TARGET)
            {
                resourcesValid = false;
            }

            base.OnPaint(e);
        }

        /// <summary>
        /// Does the drawing.
        /// </summary>
        private void DoDrawing()
        {
            RenderTarget?.SetTransform();
            RenderTarget?.Clear(Color.CornflowerBlue);
            RenderTarget?.DrawTextLayout(default, textLayout!, blackBrush!, D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT);
        }

        /// <summary>
        /// Initializes Direct2D for use with a GDI DC.
        /// </summary>
        private unsafe void CreateResources()
        {
            var black = Color.Black.ToD2D1_COLOR_F();
            RenderTarget?.CreateSolidColorBrush(&black, null, out blackBrush);
            var text = "Hello c# World 🌎 From ... DirectWrite!";
            textLayout = DirectWriteFactory?.CreateTextLayout(text, textFormat, RenderTarget?.GetSize() ?? default);

            var textTypographyRange = new DWRITE_TEXT_RANGE() { startPosition = 0u, length = (uint)text.Length };
            typography = DirectWriteFactory?.CreateTypography();
            typography?.AddFontFeature(new DWRITE_FONT_FEATURE() { nameTag = DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7, parameter = 1 });
            textLayout?.SetTypography(typography, textTypographyRange);

            // (27, 12) is the text range around "DirectWrite!"
            var textDirectWriteRange = new DWRITE_TEXT_RANGE() { startPosition = 27u, length = 12u };
            textLayout?.SetFontSize(100, textDirectWriteRange);
            textLayout?.SetUnderline(true, textDirectWriteRange);
            textLayout?.SetFontWeight(DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_BOLD, textDirectWriteRange);
        }

        /// <summary>
        /// Initializes Direct2D for use with a GDI DC.
        /// </summary>
        private unsafe void InitializeDirect2D()
        {
            if (!resourcesValid)
            {
                var renderTargetProperties = new D2D1_RENDER_TARGET_PROPERTIES()
                {
                    type = D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_DEFAULT,
                    dpiX = 0,
                    dpiY = 0,
                    minLevel = 0,
                    pixelFormat = new D2D1_PIXEL_FORMAT
                    {
                        format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM,
                        alphaMode = D2D1_ALPHA_MODE.D2D1_ALPHA_MODE_IGNORE
                    },
                };
                dcRenderTarget = Direct2dFactory?.CreateDCRenderTarget(renderTargetProperties);
                CreateResources();
                resourcesValid = true;
            }
        }

        /// <summary>
        /// Initializes Direct2D.
        /// </summary>
        /// <param name="graphics">The graphics.</param>
        /// <param name="rectangle"></param>
        private unsafe void InitializeDirect2D(Graphics graphics, Rectangle rectangle)
        {
            InitializeDirect2D();
            dcRenderTarget?.BindDC(graphics, rectangle);
        }

        /// <summary>
        /// Initializes Direct2D using a Window handle.
        /// </summary>
        /// <param name="window">The window.</param>
        private unsafe void InitializeDirect2D(IntPtr window)
        {
            if (!resourcesValid)
            {
                handleRenderTarget = Direct2dFactory?.CreateHwndRenderTarget(default, new D2D1_HWND_RENDER_TARGET_PROPERTIES() { hwnd = (HWND)window, pixelSize = new D2D_SIZE_U() { width = (uint)ClientRectangle.Size.Width, height = (uint)ClientRectangle.Size.Height }, presentOptions = D2D1_PRESENT_OPTIONS.D2D1_PRESENT_OPTIONS_NONE });
                CreateResources();
                resourcesValid = true;
            }
        }

        /// <summary>
        /// Initializes Direct2D using a Window handle.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="size">The size.</param>
        private unsafe void InitializeDirect2D(IntPtr window, Size size)
        {
            if (!resourcesValid)
            {
                handleRenderTarget = Direct2dFactory?.CreateHwndRenderTarget(default, new D2D1_HWND_RENDER_TARGET_PROPERTIES() { hwnd = (HWND)window, pixelSize = new D2D_SIZE_U() { width = (uint)size.Width, height = (uint)size.Height }, presentOptions = D2D1_PRESENT_OPTIONS.D2D1_PRESENT_OPTIONS_NONE });
                CreateResources();
                resourcesValid = true;
            }
            else
            {
                var s = size.ToD2D_SIZE_U();
                handleRenderTarget?.Resize(&s);
            }
        }
    }
}
