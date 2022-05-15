// <copyright file="DirectWrite.cs" company="Shkyrockett" >
//     Copyright © 2020 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Graphics.DirectWrite;

namespace AutoGenDirectWriteLibrary
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
        public static IDWriteFactory? CreateFactory(DWRITE_FACTORY_TYPE factoryType = DWRITE_FACTORY_TYPE.DWRITE_FACTORY_TYPE_SHARED)
        {
            return PInvoke.DWriteCreateFactory(factoryType, typeof(IDWriteFactory).GUID, out var factory) switch
            {
                HRESULT h when h == PInvoke.S_OK => factory as IDWriteFactory,
                _ => throw new Exception("Unspecified Error")
            };
        }
    }
}
