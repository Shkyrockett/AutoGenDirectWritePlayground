# Auto-gen Direct Write Playground

This is an experiment investigating using CsWin32 to draw to a Windows Forms form using Direct Write through a GDI DC.

![Hello World 🌎 from… DirectWrite …using only C#! Screen-shot](screenshot.png)

The following interfaces have had to be overridden from what CsWin32 generates because they don't work as generated:

- ID2D1BitmapRenderTarget
- ID2D1DCRenderTarget
- ID2D1DeviceContext
- ID2D1DeviceContext1
- ID2D1DeviceContext2
- ID2D1DeviceContext3
- ID2D1DeviceContext4
- ID2D1DeviceContext5
- ID2D1DeviceContext6
- ID2D1HwndRenderTarget
- ID2D1RenderTarget

Specifically the EndDraw method is supposed to return an HRESULT to show if the device is still valid, but isn't returning one. GetSize and GetPixelSize both crash if they don't return an HRESULT.  
