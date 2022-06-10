// <copyright file="D2D_POINT_2F.cs" company="Shkyrockett" >
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
        public partial struct D2D_POINT_2F
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_POINT_2F"/> class.
            /// </summary>
            /// <param name="x">The x.</param>
            /// <param name="y">The y.</param>
            public D2D_POINT_2F(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
