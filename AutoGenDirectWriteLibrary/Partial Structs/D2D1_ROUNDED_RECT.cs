﻿// <copyright file="D2D1_ROUNDED_RECT.cs" company="Shkyrockett" >
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
        public partial struct D2D1_ROUNDED_RECT
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_ROUNDED_RECT"/> class.
            /// </summary>
            /// <param name="rect">The rect.</param>
            /// <param name="radiusX">The radius x.</param>
            /// <param name="radiusY">The radius y.</param>
            public D2D1_ROUNDED_RECT(D2D_RECT_F rect, float radiusX, float radiusY)
            {
                this.rect = rect;
                this.radiusX = radiusX;
                this.radiusY = radiusY;
            }
        }
    }
}
