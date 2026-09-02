using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D
    {
        partial struct D2D1_BITMAP_PROPERTIES1_unmanaged
        {
            public static explicit operator D2D1_BITMAP_PROPERTIES1_unmanaged(D2D1_BITMAP_PROPERTIES1 value) => Unsafe.As<D2D1_BITMAP_PROPERTIES1, D2D1_BITMAP_PROPERTIES1_unmanaged>(ref value);

            public static unsafe explicit operator D2D1_BITMAP_PROPERTIES1_unmanaged(D2D1_BITMAP_PROPERTIES1* value) => Unsafe.AsRef<D2D1_BITMAP_PROPERTIES1_unmanaged>(value);
        }
    }
}
