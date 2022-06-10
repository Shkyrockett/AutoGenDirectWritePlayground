// <copyright file="DWRITE_FONT_FEATURE.cs" company="Shkyrockett" >
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
        public partial struct DWRITE_FONT_FEATURE
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DWRITE_FONT_FEATURE"/> class.
            /// </summary>
            /// <param name="nameTag">The name tag.</param>
            /// <param name="parameter">The parameter.</param>
            public DWRITE_FONT_FEATURE(DWRITE_FONT_FEATURE_TAG nameTag, uint parameter)
            {
                this.nameTag = nameTag;
                this.parameter = parameter;
            }
        }
    }
}
