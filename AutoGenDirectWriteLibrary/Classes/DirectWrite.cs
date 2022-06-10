// <copyright file="DirectWrite.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using Windows.Win32.Foundation;
using Windows.Win32.Graphics.DirectWrite;

namespace Windows.Win32
{
    /// <summary>
    /// Class for calling DirectWrite API.
    /// </summary>
    public static class DirectWrite
    {
        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory? CreateFactory(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory1? CreateFactory1(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory1).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory1,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory2? CreateFactory2(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory2).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory2,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory3? CreateFactory3(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory3).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory3,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory4? CreateFactory4(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory4).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory4,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory5? CreateFactory5(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory5).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory5,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory6? CreateFactory6(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory6).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory6,
            _ => throw new Exception("Unspecified Error")
        };

        /// <summary>
        /// Creates the factory.
        /// </summary>
        /// <param name="factoryType">Type of the factory.</param>
        /// <returns></returns>
        public static IDWriteFactory7? CreateFactory7(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED) => PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory7).GUID, out var factory) switch
        {
            HRESULT h when h == HRESULT.S_OK => factory as IDWriteFactory7,
            _ => throw new Exception("Unspecified Error")
        };
    }
}
