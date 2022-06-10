// <copyright file="D2D1_PIXEL_FORMAT.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using Windows.Win32.Graphics.Dxgi.Common;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        public partial struct D2D1_PIXEL_FORMAT
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_PIXEL_FORMAT"/> class.
            /// </summary>
            /// <param name="format">The format.</param>
            /// <param name="alphaMode">The alpha mode.</param>
            public D2D1_PIXEL_FORMAT(DXGI_FORMAT format, D2D1_ALPHA_MODE alphaMode)
            {
                this.format = format;
                this.alphaMode = alphaMode;
            }
        }
    }
}
