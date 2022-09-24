// <copyright file="D2D1_COLOR_F.cs" company="Shkyrockett" >
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
        /// <summary>
        /// The d2 d1_ c o l o r_ f.
        /// </summary>
        public partial struct D2D1_COLOR_F
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F"/> class.
            /// </summary>
            /// <param name="r">The r.</param>
            /// <param name="g">The g.</param>
            /// <param name="b">The b.</param>
            /// <param name="a">The a.</param>
            public D2D1_COLOR_F(float r, float g, float b, float a)
            {
                this.r = r;
                this.g = g;
                this.b = b;
                this.a = a;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="color"></param>
            public static implicit operator D2D1_COLOR_F(Color color) => new(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }
    }
}