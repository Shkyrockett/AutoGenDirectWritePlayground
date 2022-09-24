// <copyright file="D2D1_GRADIENT_STOP.cs" company="Shkyrockett" >
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
        /// <summary>
        /// The d2 d1_ g r a d i e n t_ s t o p.
        /// </summary>
		public partial struct D2D1_GRADIENT_STOP
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_GRADIENT_STOP"/> class.
            /// </summary>
            /// <param name="position">The position.</param>
            /// <param name="color">The color.</param>
            public D2D1_GRADIENT_STOP(float position, Color color)
            {
                this.position = position;
                this.color = color;
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_GRADIENT_STOP"/> class.
            /// </summary>
            /// <param name="position">The position.</param>
            /// <param name="color">The color.</param>
            public D2D1_GRADIENT_STOP(float position, D2D1_COLOR_F color)
            {
                this.position = position;
                this.color = color;
            }
        }
    }
}
