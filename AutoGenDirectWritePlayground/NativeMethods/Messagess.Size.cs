namespace AutoGenDirectWritePlayground
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class Messagess
    {
        /// <summary>
        /// 
        /// </summary>
        public readonly ref struct Size
        {
            /// <summary>
            /// 
            /// </summary>
            public System.Drawing.Size NewSize { get; }

            /// <summary>
            /// 
            /// </summary>
            public SizeType SizeType { get; }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="wParam"></param>
            /// <param name="lParam"></param>
            public Size(WParam wParam, LParam lParam)
            {
                NewSize = new System.Drawing.Size(lParam.LowWord, lParam.HighWord);
                SizeType = (SizeType)(int)wParam;
            }
        }
    }
}
