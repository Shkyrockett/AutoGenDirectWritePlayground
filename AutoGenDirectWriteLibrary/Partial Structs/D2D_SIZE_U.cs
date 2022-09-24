// <copyright file="D2D_SIZE_U.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Diagnostics;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        public partial struct D2D_SIZE_U
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="D2D_SIZE_U"/> class.
            /// </summary>
            /// <param name="width">The width.</param>
            /// <param name="height">The height.</param>
            public D2D_SIZE_U(uint width, uint height)
            {
                this.width = width;
                this.height = height;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="size"></param>
            public static implicit operator D2D_SIZE_U(Size size) => new((uint)size.Width, (uint)size.Height);

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns>A string? .</returns>
            private string? GetDebuggerDisplay() => ToString();

            /// <inheritdoc/>
            public override string? ToString() => $"{width}, {height}";
        }
    }
}
