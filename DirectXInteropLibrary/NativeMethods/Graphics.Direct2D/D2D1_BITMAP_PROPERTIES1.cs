using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D
    {
        partial struct D2D1_BITMAP_PROPERTIES1
        {
            public static implicit operator D2D1_BITMAP_PROPERTIES1(D2D1_BITMAP_PROPERTIES1_unmanaged value) => Unsafe.As<D2D1_BITMAP_PROPERTIES1_unmanaged, D2D1_BITMAP_PROPERTIES1>(ref value);

            public static unsafe implicit operator D2D1_BITMAP_PROPERTIES1(D2D1_BITMAP_PROPERTIES1_unmanaged* value) => Unsafe.AsRef<D2D1_BITMAP_PROPERTIES1>(value);
        }
    }
}
