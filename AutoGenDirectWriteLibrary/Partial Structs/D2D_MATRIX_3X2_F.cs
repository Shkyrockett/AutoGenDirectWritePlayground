// <copyright file="D2D_MATRIX_3X2_F.cs" company="Shkyrockett" >
//     Copyright © 2020 - 2022 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
//     Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        public partial struct D2D_MATRIX_3X2_F
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="value"></param>
            public static implicit operator D2D_MATRIX_3X2_F(Matrix3x2 value) => Unsafe.As<Matrix3x2, D2D_MATRIX_3X2_F>(ref value);
        }
    }
}