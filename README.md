# Auto-gen Direct Write Playground

This is an experiment investigating using CsWin32 to draw to a Windows Forms form using Direct Write through a GDI DC.

![Hello World 🌎 from… DirectWrite …using only C#! Screen-shot](screenshot.png)

The following interfaces have had to be overridden from what CsWin32 generates because a couple of methods don't work as generated:

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

Specifically the GetSize and GetPixelSize methods both crash if they return their respective structs rather than an HRESULT. See [CsWin32 Issue 167](https://github.com/microsoft/CsWin32/issues/167) on incorrect generation.  
