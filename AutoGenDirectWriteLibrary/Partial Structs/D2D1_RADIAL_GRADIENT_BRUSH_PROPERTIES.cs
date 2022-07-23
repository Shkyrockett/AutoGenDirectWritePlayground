// <copyright file="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES.cs" company="Shkyrockett" >
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
        public partial struct D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES"/> class.
            /// </summary>
            /// <param name="center">The center.</param>
            /// <param name="gradientOriginOffset">The gradient origin offset.</param>
            /// <param name="radiusX">The radius x.</param>
            /// <param name="radiusY">The radius y.</param>
            public D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES(PointF center, PointF gradientOriginOffset, float radiusX, float radiusY)
            {
                this.center = center.ToD2D_POINT_2F();
                this.gradientOriginOffset = gradientOriginOffset.ToD2D_POINT_2F();
                this.radiusX = radiusX;
                this.radiusY = radiusY;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES"/> class.
            /// </summary>
            /// <param name="center">The center.</param>
            /// <param name="gradientOriginOffset">The gradient origin offset.</param>
            /// <param name="radiusX">The radius x.</param>
            /// <param name="radiusY">The radius y.</param>
            public D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES(D2D_POINT_2F center, D2D_POINT_2F gradientOriginOffset, float radiusX, float radiusY)
            {
                this.center = center;
                this.gradientOriginOffset = gradientOriginOffset;
                this.radiusX = radiusX;
                this.radiusY = radiusY;
            }
        }
    }
}