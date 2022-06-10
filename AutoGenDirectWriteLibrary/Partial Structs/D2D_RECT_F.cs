// <copyright file="D2D_RECT_F.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        public partial struct D2D_RECT_F
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_RECT_F"/> class.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="top">The top.</param>
            /// <param name="right">The right.</param>
            /// <param name="bottom">The bottom.</param>
            public D2D_RECT_F(float left, float top, float right, float bottom)
            {
                this.left = left;
                this.top = top;
                this.right = right;
                this.bottom = bottom;
            }
        }
    }
}
