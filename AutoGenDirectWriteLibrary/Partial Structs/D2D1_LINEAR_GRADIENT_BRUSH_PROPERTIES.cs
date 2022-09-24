// <copyright file="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES.cs" company="Shkyrockett" >
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
        public partial struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES"/> class.
            /// </summary>
            /// <param name="startPoint">The start point.</param>
            /// <param name="endPoint">The end point.</param>
            public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES(D2D_POINT_2F startPoint, D2D_POINT_2F endPoint)
            {
                this.startPoint = startPoint;
                this.endPoint = endPoint;
            }
        }
    }
}
