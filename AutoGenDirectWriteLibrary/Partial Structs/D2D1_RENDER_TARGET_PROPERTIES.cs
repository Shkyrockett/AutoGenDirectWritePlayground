// <copyright file="D2D1_RENDER_TARGET_PROPERTIES.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using Windows.Win32.Graphics.Direct2D.Common;

namespace Windows.Win32
{
    namespace Graphics.Direct2D
    {
        public partial struct D2D1_RENDER_TARGET_PROPERTIES
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RENDER_TARGET_PROPERTIES"/> class.
            /// </summary>
            /// <param name="type">The type.</param>
            /// <param name="pixelFormat">The pixel format.</param>
            /// <param name="dpiX">The dpi x.</param>
            /// <param name="dpiY">The dpi y.</param>
            /// <param name="usage">The usage.</param>
            /// <param name="minLevel">The min level.</param>
            public D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE type, D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY, D2D1_RENDER_TARGET_USAGE usage, D2D1_FEATURE_LEVEL minLevel)
            {
                this.type = type;
                this.pixelFormat = pixelFormat;
                this.dpiX = dpiX;
                this.dpiY = dpiY;
                this.usage = usage;
                this.minLevel = minLevel;
            }
        }
    }
}
