// <copyright file="D2D1_FACTORY_OPTIONS.cs" company="Shkyrockett" >
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
    namespace Graphics.Direct2D
    {
        public partial struct D2D1_FACTORY_OPTIONS
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_FACTORY_OPTIONS"/> class.
            /// </summary>
            public D2D1_FACTORY_OPTIONS()
                : this(D2D1_DEBUG_LEVEL.D2D1_DEBUG_LEVEL_NONE)
            { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_FACTORY_OPTIONS"/> class.
            /// </summary>
            /// <param name="debugLevel">The debug level.</param>
            public D2D1_FACTORY_OPTIONS(D2D1_DEBUG_LEVEL debugLevel) => this.debugLevel = debugLevel;
        }
    }
}
