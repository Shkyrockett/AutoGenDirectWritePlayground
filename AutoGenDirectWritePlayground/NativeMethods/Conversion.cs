namespace AutoGenDirectWritePlayground
{
    /// <summary>
    /// The conversion.
    /// </summary>
    public static class Conversion
    {
        /// <summary>
        /// Highs the low to int.
        /// </summary>
        /// <param name="high">The high.</param>
        /// <param name="low">The low.</param>
        /// <returns>An uint.</returns>
        public static uint HighLowToInt(ushort high, ushort low) => ((uint)high) << 16 | low;

        /// <summary>
        /// Highs the low to int.
        /// </summary>
        /// <param name="high">The high.</param>
        /// <param name="low">The low.</param>
        /// <returns>An int.</returns>
        public static int HighLowToInt(short high, short low) => (int)HighLowToInt((ushort)high, (ushort)low);

        // Note that we always cast IntPtr to ulong to avoid checked blocks
        /// <summary>
        /// Highs the word.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An ushort.</returns>
        public static ushort HighWord(nint value) => (ushort)(((ulong)value >> 16) & 0xFFFF);

        /// <summary>
        /// Lows the word.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An ushort.</returns>
        public static ushort LowWord(nint value) => (ushort)(ulong)value;

        /// <summary>
        /// Highs the word low word.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>A (ushort HighWord, ushort LowWord) .</returns>
        public static (ushort HighWord, ushort LowWord) HighWordLowWord(nint value) => ((ushort)(((ulong)value >> 16) & 0xFFFF), (ushort)(ulong)value);

    }
}