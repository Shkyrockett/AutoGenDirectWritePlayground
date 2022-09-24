// <copyright file="D2D_POINT_2F.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
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

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator D2D_POINT_2F(PointF value) => Unsafe.As<PointF, D2D_POINT_2F>(ref value);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator D2D_POINT_2F(Vector2 value) => Unsafe.As<Vector2, D2D_POINT_2F>(ref value);

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns>A string? .</returns>
            private string? GetDebuggerDisplay() => ToString();

            /// <inheritdoc/>
            public override string? ToString() => $"{x}, {y}";
        }
    }
}
