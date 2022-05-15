using AutoGenDirectWriteLibrary;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;
using Windows.Win32.Graphics.Direct2D.Common;
using Windows.Win32.Graphics.DirectWrite;

namespace AutoGenDirectWritePlayground
{
    /// <summary>
    /// 
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
        private ID2D1HwndRenderTarget? renderTarget;
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

            if (!resourcesValid)
            {
                renderTarget = (Direct2dFactory?.CreateHwndRenderTarget(default, new D2D1_HWND_RENDER_TARGET_PROPERTIES() { hwnd = (HWND)Handle, pixelSize = new D2D_SIZE_U() { width = (uint)ClientRectangle.Size.Width, height = (uint)ClientRectangle.Size.Height }, presentOptions = D2D1_PRESENT_OPTIONS.D2D1_PRESENT_OPTIONS_NONE }));
                CreateResources();
                resourcesValid = true;
            }
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
        protected ID2D1RenderTarget? RenderTarget => renderTarget;
        #endregion

        #region Overrides
        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">The Windows <see cref="T:System.Windows.Forms.Message" /> to process.</param>
        protected unsafe override void WndProc(ref Message m)
        {
            switch ((MessageType)m.Msg)
            {
                case MessageType.Size:
                    {
                        var sizeMessage = new Messagess.Size((WParam)m.WParam, (LParam)m.LParam);
                        var size = sizeMessage.NewSize;
                        CreateResourcesInternal(Handle, in size);
                        OnSize(Handle, in size);
                        break;
                    }
                case MessageType.DisplayChange:
                    Invalidate();
                    break;
                case MessageType.Paint:
                    CreateResourcesInternal(Handle);
                    renderTarget?.BeginDraw();
                    OnPaint(Handle);
                    var result = renderTarget?.EndDraw();
                    Validate();

                    if (result == PInvoke.D2DERR_RECREATE_TARGET)
                    {
                        resourcesValid = false;
                    }
                    else
                    {
                        //result.ThrowIfFailed();
                    }
                    break;
            }

            base.WndProc(ref m);
        }
        #endregion

        /// <summary>
        /// Called when [paint].
        /// </summary>
        /// <param name="window">The window.</param>
        private void OnPaint(IntPtr window)
        {
            _ = window;
            //var targetSize = RenderTarget.GetSize();

            RenderTarget?.SetTransform();
            RenderTarget?.Clear(Color.CornflowerBlue);

            RenderTarget?.DrawTextLayout(default, textLayout!, blackBrush!, D2D1_DRAW_TEXT_OPTIONS.D2D1_DRAW_TEXT_OPTIONS_ENABLE_COLOR_FONT);
        }

        /// <summary>
        /// Called when [size].
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="size"></param>
        private void OnSize(IntPtr window, in Size size)
        {
            _ = window;
            textLayout?.SetMaxSize(size);
        }

        /// <summary>
        /// Creates the resources.
        /// </summary>
        private unsafe void CreateResources()
        {
            var black = Color.Black.ToD2D1_COLOR_F();
            RenderTarget?.CreateSolidColorBrush(&black, null, out blackBrush);
            var text = "Hello World 🌎 From ... DirectWrite!";
            textLayout = DirectWriteFactory?.CreateTextLayout(text, textFormat, RenderTarget?.GetSize() ?? default);

            var textTypographyRange = new DWRITE_TEXT_RANGE() { startPosition = 0u, length = (uint)text.Length };
            typography = DirectWriteFactory?.CreateTypography();
            typography?.AddFontFeature(new DWRITE_FONT_FEATURE() { nameTag = DWRITE_FONT_FEATURE_TAG.DWRITE_FONT_FEATURE_TAG_STYLISTIC_SET_7, parameter = 1 });
            textLayout?.SetTypography(typography, textTypographyRange);

            // (24, 12) is the range around "DirectWrite!"
            var textDirectWriteRange = new DWRITE_TEXT_RANGE() { startPosition = 24u, length = 12u };
            textLayout?.SetFontSize(100, textDirectWriteRange);
            textLayout?.SetUnderline(true, textDirectWriteRange);
            textLayout?.SetFontWeight(DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_BOLD, textDirectWriteRange);
        }

        /// <summary>
        /// Creates the resources internal.
        /// </summary>
        /// <param name="window">The window.</param>
        private unsafe void CreateResourcesInternal(IntPtr window)
        {
            if (!resourcesValid)
            {
                renderTarget = Direct2dFactory?.CreateHwndRenderTarget(default, new D2D1_HWND_RENDER_TARGET_PROPERTIES() { hwnd = (HWND)window, pixelSize = new D2D_SIZE_U() { width = (uint)ClientRectangle.Size.Width, height = (uint)ClientRectangle.Size.Height }, presentOptions = D2D1_PRESENT_OPTIONS.D2D1_PRESENT_OPTIONS_NONE });
                CreateResources();
                resourcesValid = true;
            }
        }

        /// <summary>
        /// Creates the resources internal.
        /// </summary>
        /// <param name="window">The window.</param>
        /// <param name="size">The size.</param>
        private unsafe void CreateResourcesInternal(IntPtr window, in Size size)
        {
            if (!resourcesValid)
            {
                renderTarget = Direct2dFactory?.CreateHwndRenderTarget(default, new D2D1_HWND_RENDER_TARGET_PROPERTIES() { hwnd = (HWND)window, pixelSize = new D2D_SIZE_U() { width = (uint)size.Width, height = (uint)size.Height }, presentOptions = D2D1_PRESENT_OPTIONS.D2D1_PRESENT_OPTIONS_NONE });
                CreateResources();
                resourcesValid = true;
            }
            else
            {
                var s = size.ToD2D_SIZE_U();
                renderTarget?.Resize(&s);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // ToDo: Figure out how to use DC rendering of DirectWrite.

            //IDWriteBitmapRenderTarget test;
            //IDWriteBitmapRenderTarget1 test2;
            //ID2D1DCRenderTarget t;

            base.OnPaint(e);
        }
    }
}
