// <copyright file="Common.cs" company="Shkyrockett" >
// Copyright © 2020 - 2025 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Windows.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public static class Common
    {
        /// <summary>
        /// Safely the releases a Com object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object to release.</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int SafeRelease<T>(ref T? obj)
            where T : class
        {
            var temp = obj;
            obj = null;
            int refCount = Marshal.Release(Marshal.GetIUnknownForObject(temp!));
            temp = null;
            return refCount;
        }
    }
}