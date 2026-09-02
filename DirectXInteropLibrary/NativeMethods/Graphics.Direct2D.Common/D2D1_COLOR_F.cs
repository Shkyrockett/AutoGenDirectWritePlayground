// <copyright file="D2D1_COLOR_F.cs" company="Shkyrockett" >
// Copyright © 2020 - 2026 Shkyrockett. All rights reserved.
// </copyright>
// <author id="shkyrockett">Shkyrockett</author>
// <license>
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </license>
// <summary></summary>
// <remarks></remarks>

using System.Diagnostics;
using System.Drawing;
using System.Numerics.Colors;
using System.Runtime.CompilerServices;

namespace Windows.Win32
{
    namespace Graphics.Direct2D.Common
    {
        [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
        partial struct D2D1_COLOR_F
            : IEquatable<D2D1_COLOR_F>
        {
            /// <summary>
            /// Gets the alice blue.
            /// </summary>
            /// <value>
            /// The alice blue.
            /// </value>
            public static D2D1_COLOR_F AliceBlue => new(0xF0F8FF);

            /// <summary>
            /// Gets the antique white.
            /// </summary>
            /// <value>
            /// The antique white.
            /// </value>
            public static D2D1_COLOR_F AntiqueWhite => new(0xFAEBD7);

            /// <summary>
            /// Gets the aqua.
            /// </summary>
            /// <value>
            /// The aqua.
            /// </value>
            public static D2D1_COLOR_F Aqua => new(0x00FFFF);

            /// <summary>
            /// Gets the aquamarine.
            /// </summary>
            /// <value>
            /// The aquamarine.
            /// </value>
            public static D2D1_COLOR_F Aquamarine => new(0x7FFFD4);

            /// <summary>
            /// Gets the azure.
            /// </summary>
            /// <value>
            /// The azure.
            /// </value>
            public static D2D1_COLOR_F Azure => new(0xF0FFFF);

            /// <summary>
            /// Gets the beige.
            /// </summary>
            /// <value>
            /// The beige.
            /// </value>
            public static D2D1_COLOR_F Beige => new(0xF5F5DC);

            /// <summary>
            /// Gets the bisque.
            /// </summary>
            /// <value>
            /// The bisque.
            /// </value>
            public static D2D1_COLOR_F Bisque => new(0xFFE4C4);

            /// <summary>
            /// Gets the black.
            /// </summary>
            /// <value>
            /// The black.
            /// </value>
            public static D2D1_COLOR_F Black => new(0x000000);
            /// <summary>
            /// Gets the blanched almond.
            /// </summary>
            /// <value>
            /// The blanched almond.
            /// </value>
            public static D2D1_COLOR_F BlanchedAlmond => new(0xFFEBCD);

            /// <summary>
            /// Gets the blue.
            /// </summary>
            /// <value>
            /// The blue.
            /// </value>
            public static D2D1_COLOR_F Blue => new(0x0000FF);

            /// <summary>
            /// Gets the blue violet.
            /// </summary>
            /// <value>
            /// The blue violet.
            /// </value>
            public static D2D1_COLOR_F BlueViolet => new(0x8A2BE2);

            /// <summary>
            /// Gets the brown.
            /// </summary>
            /// <value>
            /// The brown.
            /// </value>
            public static D2D1_COLOR_F Brown => new(0xA52A2A);

            /// <summary>
            /// Gets the burly wood.
            /// </summary>
            /// <value>
            /// The burly wood.
            /// </value>
            public static D2D1_COLOR_F BurlyWood => new(0xDEB887);

            /// <summary>
            /// Gets the cadet blue.
            /// </summary>
            /// <value>
            /// The cadet blue.
            /// </value>
            public static D2D1_COLOR_F CadetBlue => new(0x5F9EA0);

            /// <summary>
            /// Gets the chartreuse.
            /// </summary>
            /// <value>
            /// The chartreuse.
            /// </value>
            public static D2D1_COLOR_F Chartreuse => new(0x7FFF00);

            /// <summary>
            /// Gets the chocolate.
            /// </summary>
            /// <value>
            /// The chocolate.
            /// </value>
            public static D2D1_COLOR_F Chocolate => new(0xD2691E);

            /// <summary>
            /// Gets the coral.
            /// </summary>
            /// <value>
            /// The coral.
            /// </value>
            public static D2D1_COLOR_F Coral => new(0xFF7F50);

            /// <summary>
            /// Gets the cornflower blue.
            /// </summary>
            /// <value>
            /// The cornflower blue.
            /// </value>
            public static D2D1_COLOR_F CornflowerBlue => new(0x6495ED);

            /// <summary>
            /// Gets the cornsilk.
            /// </summary>
            /// <value>
            /// The cornsilk.
            /// </value>
            public static D2D1_COLOR_F Cornsilk => new(0xFFF8DC);

            /// <summary>
            /// Gets the crimson.
            /// </summary>
            /// <value>
            /// The crimson.
            /// </value>
            public static D2D1_COLOR_F Crimson => new(0xDC143C);

            /// <summary>
            /// Gets the cyan.
            /// </summary>
            /// <value>
            /// The cyan.
            /// </value>
            public static D2D1_COLOR_F Cyan => new(0x00FFFF);

            /// <summary>
            /// Gets the dark blue.
            /// </summary>
            /// <value>
            /// The dark blue.
            /// </value>
            public static D2D1_COLOR_F DarkBlue => new(0x00008B);

            /// <summary>
            /// Gets the dark cyan.
            /// </summary>
            /// <value>
            /// The dark cyan.
            /// </value>
            public static D2D1_COLOR_F DarkCyan => new(0x008B8B);

            /// <summary>
            /// Gets the dark goldenrod.
            /// </summary>
            /// <value>
            /// The dark goldenrod.
            /// </value>
            public static D2D1_COLOR_F DarkGoldenrod => new(0xB8860B);

            /// <summary>
            /// Gets the dark gray.
            /// </summary>
            /// <value>
            /// The dark gray.
            /// </value>
            public static D2D1_COLOR_F DarkGray => new(0xA9A9A9);

            /// <summary>
            /// Gets the dark green.
            /// </summary>
            /// <value>
            /// The dark green.
            /// </value>
            public static D2D1_COLOR_F DarkGreen => new(0x006400);

            /// <summary>
            /// Gets the dark khaki.
            /// </summary>
            /// <value>
            /// The dark khaki.
            /// </value>
            public static D2D1_COLOR_F DarkKhaki => new(0xBDB76B);

            /// <summary>
            /// Gets the dark magenta.
            /// </summary>
            /// <value>
            /// The dark magenta.
            /// </value>
            public static D2D1_COLOR_F DarkMagenta => new(0x8B008B);

            /// <summary>
            /// Gets the dark olive green.
            /// </summary>
            /// <value>
            /// The dark olive green.
            /// </value>
            public static D2D1_COLOR_F DarkOliveGreen => new(0x556B2F);

            /// <summary>
            /// Gets the dark orange.
            /// </summary>
            /// <value>
            /// The dark orange.
            /// </value>
            public static D2D1_COLOR_F DarkOrange => new(0xFF8C00);

            /// <summary>
            /// Gets the dark orchid.
            /// </summary>
            /// <value>
            /// The dark orchid.
            /// </value>
            public static D2D1_COLOR_F DarkOrchid => new(0x9932CC);

            /// <summary>
            /// Gets the dark red.
            /// </summary>
            /// <value>
            /// The dark red.
            /// </value>
            public static D2D1_COLOR_F DarkRed => new(0x8B0000);
			
            /// <summary>
            /// Gets the dark salmon.
            /// </summary>
            /// <value>
            /// The dark salmon.
            /// </value>
            public static D2D1_COLOR_F DarkSalmon => new(0xE9967A);

            /// <summary>
            /// Gets the dark sea green.
            /// </summary>
            /// <value>
            /// The dark sea green.
            /// </value>
            public static D2D1_COLOR_F DarkSeaGreen => new(0x8FBC8F);

            /// <summary>
            /// Gets the dark slate blue.
            /// </summary>
            /// <value>
            /// The dark slate blue.
            /// </value>
            public static D2D1_COLOR_F DarkSlateBlue => new(0x483D8B);

            /// <summary>
            /// Gets the dark slate gray.
            /// </summary>
            /// <value>
            /// The dark slate gray.
            /// </value>
            public static D2D1_COLOR_F DarkSlateGray => new(0x2F4F4F);

            /// <summary>
            /// Gets the dark turquoise.
            /// </summary>
            /// <value>
            /// The dark turquoise.
            /// </value>
            public static D2D1_COLOR_F DarkTurquoise => new(0x00CED1);

            /// <summary>
            /// Gets the dark violet.
            /// </summary>
            /// <value>
            /// The dark violet.
            /// </value>
            public static D2D1_COLOR_F DarkViolet => new(0x9400D3);

            /// <summary>
            /// Gets the deep pink.
            /// </summary>
            /// <value>
            /// The deep pink.
            /// </value>
            public static D2D1_COLOR_F DeepPink => new(0xFF1493);

            /// <summary>
            /// Gets the deep sky blue.
            /// </summary>
            /// <value>
            /// The deep sky blue.
            /// </value>
            public static D2D1_COLOR_F DeepSkyBlue => new(0x00BFFF);

            /// <summary>
            /// Gets the dim gray.
            /// </summary>
            /// <value>
            /// The dim gray.
            /// </value>
            public static D2D1_COLOR_F DimGray => new(0x696969);

            /// <summary>
            /// Gets the dodger blue.
            /// </summary>
            /// <value>
            /// The dodger blue.
            /// </value>
            public static D2D1_COLOR_F DodgerBlue => new(0x1E90FF);

            /// <summary>
            /// Gets the firebrick.
            /// </summary>
            /// <value>
            /// The firebrick.
            /// </value>
            public static D2D1_COLOR_F Firebrick => new(0xB22222);

            /// <summary>
            /// Gets the floral white.
            /// </summary>
            /// <value>
            /// The floral white.
            /// </value>
            public static D2D1_COLOR_F FloralWhite => new(0xFFFAF0);

            /// <summary>
            /// Gets the forest green.
            /// </summary>
            /// <value>
            /// The forest green.
            /// </value>
            public static D2D1_COLOR_F ForestGreen => new(0x228B22);

            /// <summary>
            /// Gets the fuchsia.
            /// </summary>
            /// <value>
            /// The fuchsia.
            /// </value>
            public static D2D1_COLOR_F Fuchsia => new(0xFF00FF);

            /// <summary>
            /// Gets the gainsboro.
            /// </summary>
            /// <value>
            /// The gainsboro.
            /// </value>
            public static D2D1_COLOR_F Gainsboro => new(0xDCDCDC);

            /// <summary>
            /// Gets the ghost white.
            /// </summary>
            /// <value>
            /// The ghost white.
            /// </value>
            public static D2D1_COLOR_F GhostWhite => new(0xF8F8FF);

            /// <summary>
            /// Gets the gold.
            /// </summary>
            /// <value>
            /// The gold.
            /// </value>
            public static D2D1_COLOR_F Gold => new(0xFFD700);

            /// <summary>
            /// Gets the goldenrod.
            /// </summary>
            /// <value>
            /// The goldenrod.
            /// </value>
            public static D2D1_COLOR_F Goldenrod => new(0xDAA520);

            /// <summary>
            /// Gets the gray.
            /// </summary>
            /// <value>
            /// The gray.
            /// </value>
            public static D2D1_COLOR_F Gray => new(0x808080);

            /// <summary>
            /// Gets the green.
            /// </summary>
            /// <value>
            /// The green.
            /// </value>
            public static D2D1_COLOR_F Green => new(0x008000);

            /// <summary>
            /// Gets the green yellow.
            /// </summary>
            /// <value>
            /// The green yellow.
            /// </value>
            public static D2D1_COLOR_F GreenYellow => new(0xADFF2F);

            /// <summary>
            /// Gets the honeydew.
            /// </summary>
            /// <value>
            /// The honeydew.
            /// </value>
            public static D2D1_COLOR_F Honeydew => new(0xF0FFF0);

            /// <summary>
            /// Gets the hot pink.
            /// </summary>
            /// <value>
            /// The hot pink.
            /// </value>
            public static D2D1_COLOR_F HotPink => new(0xFF69B4);

            /// <summary>
            /// Gets the indian red.
            /// </summary>
            /// <value>
            /// The indian red.
            /// </value>
            public static D2D1_COLOR_F IndianRed => new(0xCD5C5C);

            /// <summary>
            /// Gets the indigo.
            /// </summary>
            /// <value>
            /// The indigo.
            /// </value>
            public static D2D1_COLOR_F Indigo => new(0x4B0082);

            /// <summary>
            /// Gets the ivory.
            /// </summary>
            /// <value>
            /// The ivory.
            /// </value>
            public static D2D1_COLOR_F Ivory => new(0xFFFFF0);

            /// <summary>
            /// Gets the khaki.
            /// </summary>
            /// <value>
            /// The khaki.
            /// </value>
            public static D2D1_COLOR_F Khaki => new(0xF0E68C);

            /// <summary>
            /// Gets the lavender.
            /// </summary>
            /// <value>
            /// The lavender.
            /// </value>
            public static D2D1_COLOR_F Lavender => new(0xE6E6FA);

            /// <summary>
            /// Gets the lavender blush.
            /// </summary>
            /// <value>
            /// The lavender blush.
            /// </value>
            public static D2D1_COLOR_F LavenderBlush => new(0xFFF0F5);

            /// <summary>
            /// Gets the lawn green.
            /// </summary>
            /// <value>
            /// The lawn green.
            /// </value>
            public static D2D1_COLOR_F LawnGreen => new(0x7CFC00);

            /// <summary>
            /// Gets the lemon chiffon.
            /// </summary>
            /// <value>
            /// The lemon chiffon.
            /// </value>
            public static D2D1_COLOR_F LemonChiffon => new(0xFFFACD);

            /// <summary>
            /// Gets the light blue.
            /// </summary>
            /// <value>
            /// The light blue.
            /// </value>
            public static D2D1_COLOR_F LightBlue => new(0xADD8E6);

            /// <summary>
            /// Gets the light coral.
            /// </summary>
            /// <value>
            /// The light coral.
            /// </value>
            public static D2D1_COLOR_F LightCoral => new(0xF08080);

            /// <summary>
            /// Gets the light cyan.
            /// </summary>
            /// <value>
            /// The light cyan.
            /// </value>
            public static D2D1_COLOR_F LightCyan => new(0xE0FFFF);

            /// <summary>
            /// Gets the light goldenrod yellow.
            /// </summary>
            /// <value>
            /// The light goldenrod yellow.
            /// </value>
            public static D2D1_COLOR_F LightGoldenrodYellow => new(0xFAFAD2);

            /// <summary>
            /// Gets the light green.
            /// </summary>
            /// <value>
            /// The light green.
            /// </value>
            public static D2D1_COLOR_F LightGreen => new(0x90EE90);

            /// <summary>
            /// Gets the light gray.
            /// </summary>
            /// <value>
            /// The light gray.
            /// </value>
            public static D2D1_COLOR_F LightGray => new(0xD3D3D3);

            /// <summary>
            /// Gets the light pink.
            /// </summary>
            /// <value>
            /// The light pink.
            /// </value>
            public static D2D1_COLOR_F LightPink => new(0xFFB6C1);

            /// <summary>
            /// Gets the light salmon.
            /// </summary>
            /// <value>
            /// The light salmon.
            /// </value>
            public static D2D1_COLOR_F LightSalmon => new(0xFFA07A);

            /// <summary>
            /// Gets the light sea green.
            /// </summary>
            /// <value>
            /// The light sea green.
            /// </value>
            public static D2D1_COLOR_F LightSeaGreen => new(0x20B2AA);

            /// <summary>
            /// Gets the light sky blue.
            /// </summary>
            /// <value>
            /// The light sky blue.
            /// </value>
            public static D2D1_COLOR_F LightSkyBlue => new(0x87CEFA);

            /// <summary>
            /// Gets the light slate gray.
            /// </summary>
            /// <value>
            /// The light slate gray.
            /// </value>
            public static D2D1_COLOR_F LightSlateGray => new(0x778899);

            /// <summary>
            /// Gets the light steel blue.
            /// </summary>
            /// <value>
            /// The light steel blue.
            /// </value>
            public static D2D1_COLOR_F LightSteelBlue => new(0xB0C4DE);

            /// <summary>
            /// Gets the light yellow.
            /// </summary>
            /// <value>
            /// The light yellow.
            /// </value>
            public static D2D1_COLOR_F LightYellow => new(0xFFFFE0);

            /// <summary>
            /// Gets the lime.
            /// </summary>
            /// <value>
            /// The lime.
            /// </value>
            public static D2D1_COLOR_F Lime => new(0x00FF00);

            /// <summary>
            /// Gets the lime green.
            /// </summary>
            /// <value>
            /// The lime green.
            /// </value>
            public static D2D1_COLOR_F LimeGreen => new(0x32CD32);

            /// <summary>
            /// Gets the linen.
            /// </summary>
            /// <value>
            /// The linen.
            /// </value>
            public static D2D1_COLOR_F Linen => new(0xFAF0E6);

            /// <summary>
            /// Gets the magenta.
            /// </summary>
            /// <value>
            /// The magenta.
            /// </value>
            public static D2D1_COLOR_F Magenta => new(0xFF00FF);

            /// <summary>
            /// Gets the maroon.
            /// </summary>
            /// <value>
            /// The maroon.
            /// </value>
            public static D2D1_COLOR_F Maroon => new(0x800000);

            /// <summary>
            /// Gets the medium aquamarine.
            /// </summary>
            /// <value>
            /// The medium aquamarine.
            /// </value>
            public static D2D1_COLOR_F MediumAquamarine => new(0x66CDAA);

            /// <summary>
            /// Gets the medium blue.
            /// </summary>
            /// <value>
            /// The medium blue.
            /// </value>
            public static D2D1_COLOR_F MediumBlue => new(0x0000CD);

            /// <summary>
            /// Gets the medium orchid.
            /// </summary>
            /// <value>
            /// The medium orchid.
            /// </value>
            public static D2D1_COLOR_F MediumOrchid => new(0xBA55D3);

            /// <summary>
            /// Gets the medium purple.
            /// </summary>
            /// <value>
            /// The medium purple.
            /// </value>
            public static D2D1_COLOR_F MediumPurple => new(0x9370DB);

            /// <summary>
            /// Gets the medium sea green.
            /// </summary>
            /// <value>
            /// The medium sea green.
            /// </value>
            public static D2D1_COLOR_F MediumSeaGreen => new(0x3CB371);

            /// <summary>
            /// Gets the medium slate blue.
            /// </summary>
            /// <value>
            /// The medium slate blue.
            /// </value>
            public static D2D1_COLOR_F MediumSlateBlue => new(0x7B68EE);

            /// <summary>
            /// Gets the medium spring green.
            /// </summary>
            /// <value>
            /// The medium spring green.
            /// </value>
            public static D2D1_COLOR_F MediumSpringGreen => new(0x00FA9A);

            /// <summary>
            /// Gets the medium turquoise.
            /// </summary>
            /// <value>
            /// The medium turquoise.
            /// </value>
            public static D2D1_COLOR_F MediumTurquoise => new(0x48D1CC);

            /// <summary>
            /// Gets the medium violet red.
            /// </summary>
            /// <value>
            /// The medium violet red.
            /// </value>
            public static D2D1_COLOR_F MediumVioletRed => new(0xC71585);

            /// <summary>
            /// Gets the midnight blue.
            /// </summary>
            /// <value>
            /// The midnight blue.
            /// </value>
            public static D2D1_COLOR_F MidnightBlue => new(0x191970);

            /// <summary>
            /// Gets the mint cream.
            /// </summary>
            /// <value>
            /// The mint cream.
            /// </value>
            public static D2D1_COLOR_F MintCream => new(0xF5FFFA);

            /// <summary>
            /// Gets the misty rose.
            /// </summary>
            /// <value>
            /// The misty rose.
            /// </value>
            public static D2D1_COLOR_F MistyRose => new(0xFFE4E1);

            /// <summary>
            /// Gets the moccasin.
            /// </summary>
            /// <value>
            /// The moccasin.
            /// </value>
            public static D2D1_COLOR_F Moccasin => new(0xFFE4B5);

            /// <summary>
            /// Gets the navajo white.
            /// </summary>
            /// <value>
            /// The navajo white.
            /// </value>
            public static D2D1_COLOR_F NavajoWhite => new(0xFFDEAD);

            /// <summary>
            /// Gets the navy.
            /// </summary>
            /// <value>
            /// The navy.
            /// </value>
            public static D2D1_COLOR_F Navy => new(0x000080);

            /// <summary>
            /// Gets the old lace.
            /// </summary>
            /// <value>
            /// The old lace.
            /// </value>
            public static D2D1_COLOR_F OldLace => new(0xFDF5E6);

            /// <summary>
            /// Gets the olive.
            /// </summary>
            /// <value>
            /// The olive.
            /// </value>
            public static D2D1_COLOR_F Olive => new(0x808000);

            /// <summary>
            /// Gets the olive drab.
            /// </summary>
            /// <value>
            /// The olive drab.
            /// </value>
            public static D2D1_COLOR_F OliveDrab => new(0x6B8E23);

            /// <summary>
            /// Gets the orange.
            /// </summary>
            /// <value>
            /// The orange.
            /// </value>
            public static D2D1_COLOR_F Orange => new(0xFFA500);

            /// <summary>
            /// Gets the orange red.
            /// </summary>
            /// <value>
            /// The orange red.
            /// </value>
            public static D2D1_COLOR_F OrangeRed => new(0xFF4500);

            /// <summary>
            /// Gets the orchid.
            /// </summary>
            /// <value>
            /// The orchid.
            /// </value>
            public static D2D1_COLOR_F Orchid => new(0xDA70D6);

            /// <summary>
            /// Gets the pale goldenrod.
            /// </summary>
            /// <value>
            /// The pale goldenrod.
            /// </value>
            public static D2D1_COLOR_F PaleGoldenrod => new(0xEEE8AA);

            /// <summary>
            /// Gets the pale green.
            /// </summary>
            /// <value>
            /// The pale green.
            /// </value>
            public static D2D1_COLOR_F PaleGreen => new(0x98FB98);

            /// <summary>
            /// Gets the pale turquoise.
            /// </summary>
            /// <value>
            /// The pale turquoise.
            /// </value>
            public static D2D1_COLOR_F PaleTurquoise => new(0xAFEEEE);

            /// <summary>
            /// Gets the pale violet red.
            /// </summary>
            /// <value>
            /// The pale violet red.
            /// </value>
            public static D2D1_COLOR_F PaleVioletRed => new(0xDB7093);

            /// <summary>
            /// Gets the papaya whip.
            /// </summary>
            /// <value>
            /// The papaya whip.
            /// </value>
            public static D2D1_COLOR_F PapayaWhip => new(0xFFEFD5);

            /// <summary>
            /// Gets the peach puff.
            /// </summary>
            /// <value>
            /// The peach puff.
            /// </value>
            public static D2D1_COLOR_F PeachPuff => new(0xFFDAB9);

            /// <summary>
            /// Gets the peru.
            /// </summary>
            /// <value>
            /// The peru.
            /// </value>
            public static D2D1_COLOR_F Peru => new(0xCD853F);

            /// <summary>
            /// Gets the pink.
            /// </summary>
            /// <value>
            /// The pink.
            /// </value>
            public static D2D1_COLOR_F Pink => new(0xFFC0CB);

            /// <summary>
            /// Gets the plum.
            /// </summary>
            /// <value>
            /// The plum.
            /// </value>
            public static D2D1_COLOR_F Plum => new(0xDDA0DD);

            /// <summary>
            /// Gets the powder blue.
            /// </summary>
            /// <value>
            /// The powder blue.
            /// </value>
            public static D2D1_COLOR_F PowderBlue => new(0xB0E0E6);

            /// <summary>
            /// Gets the purple.
            /// </summary>
            /// <value>
            /// The purple.
            /// </value>
            public static D2D1_COLOR_F Purple => new(0x800080);

            /// <summary>
            /// Gets the red.
            /// </summary>
            /// <value>
            /// The red.
            /// </value>
            public static D2D1_COLOR_F Red => new(0xFF0000);

            /// <summary>
            /// Gets the rosy brown.
            /// </summary>
            /// <value>
            /// The rosy brown.
            /// </value>
            public static D2D1_COLOR_F RosyBrown => new(0xBC8F8F);

            /// <summary>
            /// Gets the royal blue.
            /// </summary>
            /// <value>
            /// The royal blue.
            /// </value>
            public static D2D1_COLOR_F RoyalBlue => new(0x4169E1);

            /// <summary>
            /// Gets the saddle brown.
            /// </summary>
            /// <value>
            /// The saddle brown.
            /// </value>
            public static D2D1_COLOR_F SaddleBrown => new(0x8B4513);

            /// <summary>
            /// Gets the salmon.
            /// </summary>
            /// <value>
            /// The salmon.
            /// </value>
            public static D2D1_COLOR_F Salmon => new(0xFA8072);

            /// <summary>
            /// Gets the sandy brown.
            /// </summary>
            /// <value>
            /// The sandy brown.
            /// </value>
            public static D2D1_COLOR_F SandyBrown => new(0xF4A460);

            /// <summary>
            /// Gets the sea green.
            /// </summary>
            /// <value>
            /// The sea green.
            /// </value>
            public static D2D1_COLOR_F SeaGreen => new(0x2E8B57);

            /// <summary>
            /// Gets the sea shell.
            /// </summary>
            /// <value>
            /// The sea shell.
            /// </value>
            public static D2D1_COLOR_F SeaShell => new(0xFFF5EE);

            /// <summary>
            /// Gets the sienna.
            /// </summary>
            /// <value>
            /// The sienna.
            /// </value>
            public static D2D1_COLOR_F Sienna => new(0xA0522D);

            /// <summary>
            /// Gets the silver.
            /// </summary>
            /// <value>
            /// The silver.
            /// </value>
            public static D2D1_COLOR_F Silver => new(0xC0C0C0);

            /// <summary>
            /// Gets the sky blue.
            /// </summary>
            /// <value>
            /// The sky blue.
            /// </value>
            public static D2D1_COLOR_F SkyBlue => new(0x87CEEB);

            /// <summary>
            /// Gets the slate blue.
            /// </summary>
            /// <value>
            /// The slate blue.
            /// </value>
            public static D2D1_COLOR_F SlateBlue => new(0x6A5ACD);

            /// <summary>
            /// Gets the slate gray.
            /// </summary>
            /// <value>
            /// The slate gray.
            /// </value>
            public static D2D1_COLOR_F SlateGray => new(0x708090);

            /// <summary>
            /// Gets the snow.
            /// </summary>
            /// <value>
            /// The snow.
            /// </value>
            public static D2D1_COLOR_F Snow => new(0xFFFAFA);

            /// <summary>
            /// Gets the spring green.
            /// </summary>
            /// <value>
            /// The spring green.
            /// </value>
            public static D2D1_COLOR_F SpringGreen => new(0x00FF7F);

            /// <summary>
            /// Gets the steel blue.
            /// </summary>
            /// <value>
            /// The steel blue.
            /// </value>
            public static D2D1_COLOR_F SteelBlue => new(0x4682B4);

            /// <summary>
            /// Gets the tan.
            /// </summary>
            /// <value>
            /// The tan.
            /// </value>
            public static D2D1_COLOR_F Tan => new(0xD2B48C);

            /// <summary>
            /// Gets the teal.
            /// </summary>
            /// <value>
            /// The teal.
            /// </value>
            public static D2D1_COLOR_F Teal => new(0x008080);

            /// <summary>
            /// Gets the thistle.
            /// </summary>
            /// <value>
            /// The thistle.
            /// </value>
            public static D2D1_COLOR_F Thistle => new(0xD8BFD8);

            /// <summary>
            /// Gets the tomato.
            /// </summary>
            /// <value>
            /// The tomato.
            /// </value>
            public static D2D1_COLOR_F Tomato => new(0xFF6347);

            /// <summary>
            /// Gets the turquoise.
            /// </summary>
            /// <value>
            /// The turquoise.
            /// </value>
            public static D2D1_COLOR_F Turquoise => new(0x40E0D0);

            /// <summary>
            /// Gets the violet.
            /// </summary>
            /// <value>
            /// The violet.
            /// </value>
            public static D2D1_COLOR_F Violet => new(0xEE82EE);

            /// <summary>
            /// Gets the wheat.
            /// </summary>
            /// <value>
            /// The wheat.
            /// </value>
            public static D2D1_COLOR_F Wheat => new(0xF5DEB3);

            /// <summary>
            /// Gets the white.
            /// </summary>
            /// <value>
            /// The white.
            /// </value>
            public static D2D1_COLOR_F White => new(0xFFFFFF);

            /// <summary>
            /// Gets the white smoke.
            /// </summary>
            /// <value>
            /// The white smoke.
            /// </value>
            public static D2D1_COLOR_F WhiteSmoke => new(0xF5F5F5);

            /// <summary>
            /// Gets the yellow.
            /// </summary>
            /// <value>
            /// The yellow.
            /// </value>
            public static D2D1_COLOR_F Yellow => new(0xFFFF00);

            /// <summary>
            /// Gets the yellow green.
            /// </summary>
            /// <value>
            /// The yellow green.
            /// </value>
            public static D2D1_COLOR_F YellowGreen => new(0x9ACD32);

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F"/> struct.
            /// </summary>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_COLOR_F() : this(default, default, default, default) { }

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F" /> class.
            /// </summary>
            /// <param name="bgr">The bgra.</param>
            /// <param name="alpha">The alpha.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_COLOR_F(uint bgr, float alpha) => (r, g, b, a) = (((bgr >> 16) & 0xFF) / 255f, ((bgr >> 8) & 0xFF) / 255f, ((bgr >> 0) & 0xFF) / 255f, alpha);

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F" /> class.
            /// </summary>
            /// <param name="bgra">The bgra.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_COLOR_F(uint bgra) => (r, g, b, a) = (((bgra >> 16) & 0xFF) / 255f, ((bgra >> 8) & 0xFF) / 255f, (bgra & 0xFF) / 255f, ((bgra >> 24) & 0xFF) / 255f);

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F" /> class.
            /// </summary>
            /// <param name="r">The r.</param>
            /// <param name="g">The g.</param>
            /// <param name="b">The b.</param>
            /// <param name="a">The a.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_COLOR_F(float r, float g, float b) => (this.r, this.g, this.b, a) = (r, g, b, 1);

            /// <summary>
            /// Initializes a new instance of the <see cref="D2D1_COLOR_F" /> class.
            /// </summary>
            /// <param name="r">The r.</param>
            /// <param name="g">The g.</param>
            /// <param name="b">The b.</param>
            /// <param name="a">The a.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public D2D1_COLOR_F(float r, float g, float b, float a) => (this.r, this.g, this.b, this.a) = (r, g, b, a);

            /// <summary>
            /// Deconstructs the specified color.
            /// </summary>
            /// <param name="r">The r.</param>
            /// <param name="g">The g.</param>
            /// <param name="b">The b.</param>
            /// <param name="a">a.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly void Deconstruct(out float r, out float g, out float b, out float a) => (r, g, b, a) = (this.r, this.g, this.b, this.a);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D1_COLOR_F(Argb<float> color) => new(color.R, color.G, color.B, color.A);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D1_COLOR_F(Argb<byte> color) => new(color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D1_COLOR_F(Rgba<float> color) => Unsafe.As<Rgba<float>, D2D1_COLOR_F>(ref color);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D1_COLOR_F(Rgba<byte> color) => new(color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator D2D1_COLOR_F(Color color) => new(color.R / 255f, color.G / 255f, color.B / 255f, color.A / 255f);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator Argb<float>(D2D1_COLOR_F color) => new(color.a, color.r, color.g, color.b);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator Argb<byte>(D2D1_COLOR_F color) => new((byte)(color.a * 255), (byte)(color.r * 255), (byte)(color.g * 255), (byte)(color.b * 255));

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static implicit operator Rgba<float>(D2D1_COLOR_F color) => Unsafe.As<D2D1_COLOR_F, Rgba<float>>(ref color);

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator Rgba<byte>(D2D1_COLOR_F color) => new((byte)(color.r * 255), (byte)(color.g * 255), (byte)(color.b * 255), (byte)(color.a * 255));

            /// <summary>
            /// Performs an implicit conversion from <see cref="Color"/> to <see cref="D2D1_COLOR_F"/>.
            /// </summary>
            /// <param name="color">The color.</param>
            /// <returns>
            /// The result of the conversion.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static explicit operator Color(D2D1_COLOR_F color) => Color.FromArgb((int)(color.r * 255), (int)(color.g * 255), (int)(color.b * 255), (int)(color.a * 255));

            /// <summary>
            /// Implements the operator ==.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator ==(D2D1_COLOR_F left, D2D1_COLOR_F right) => left.Equals(right);

            /// <summary>
            /// Implements the operator !=.
            /// </summary>
            /// <param name="left">The left.</param>
            /// <param name="right">The right.</param>
            /// <returns>
            /// The result of the operator.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static bool operator !=(D2D1_COLOR_F left, D2D1_COLOR_F right) => !(left == right);

            /// <summary>
            /// Indicates whether this instance and a specified object are equal.
            /// </summary>
            /// <param name="obj">The object to compare with the current instance.</param>
            /// <returns>
            ///   <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly bool Equals(object? obj) => obj is D2D1_COLOR_F f && Equals(f);

            /// <summary>
            /// Indicates whether the current object is equal to another object of the same type.
            /// </summary>
            /// <param name="other">An object to compare with this object.</param>
            /// <returns>
            ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public readonly bool Equals(D2D1_COLOR_F other) => r == other.r && g == other.g && b == other.b && a == other.a;

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>
            /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly int GetHashCode() => HashCode.Combine(r, g, b, a);

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// The fully qualified type name.
            /// </returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public override readonly string? ToString() => $"{nameof(D2D1_COLOR_F)}({r}, {g}, {b}, {a})";

            /// <summary>
            /// Gets the debugger display.
            /// </summary>
            /// <returns></returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private readonly string? GetDebuggerDisplay() => ToString();
        }
    }
}
