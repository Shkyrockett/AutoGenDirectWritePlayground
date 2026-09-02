using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.Direct2D;

namespace Windows.Win32
{
    public static partial class PInvoke
    {
        /// <inheritdoc cref="D2D1CreateFactory(D2D1_FACTORY_TYPE, Guid*, D2D1_FACTORY_OPTIONS, out object)"/>
        [SupportedOSPlatform("windows6.1")]
        public static HRESULT D2D1CreateFactory<T>(D2D1_FACTORY_TYPE factoryType, [Optional] D2D1_FACTORY_OPTIONS? pFactoryOptions, out T factory)
            where T : class
        {
            Guid __riid = typeof(T).GUID;
            HRESULT __result = D2D1CreateFactory(factoryType, __riid, pFactoryOptions, out object __ppv);
            factory = (T)__ppv;
            return __result;
        }
    }
}
