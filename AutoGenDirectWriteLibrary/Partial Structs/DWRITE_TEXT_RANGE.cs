// <copyright file="DWRITE_TEXT_RANGE.cs" company="Shkyrockett" >
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
    namespace Graphics.DirectWrite
    {
        public partial struct DWRITE_TEXT_RANGE
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_TEXT_RANGE"/> class.
            /// </summary>
            /// <param name="startPosition">The start position.</param>
            /// <param name="length">The length.</param>
            public DWRITE_TEXT_RANGE(uint startPosition, uint length)
            {
                this.startPosition = startPosition;
                this.length = length;
            }
        }
    }
}
