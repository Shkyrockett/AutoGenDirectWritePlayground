namespace AutoGenDirectWritePlayground
{
    /// <summary>
    /// 
    /// </summary>
    public struct LParam
    {
        /// <summary>
        /// 
        /// </summary>
        public nint Value;

        /// <summary>
        /// 
        /// </summary>
        public ushort LowWord => Conversion.LowWord(Value);

        /// <summary>
        /// 
        /// </summary>
        public ushort HighWord => Conversion.HighWord(Value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public LParam(nint value) => Value = value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="high"></param>
        /// <param name="low"></param>
        public LParam(int high, int low) => Value = Conversion.HighLowToInt(checked((short)high), checked((short)low));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lParam"></param>
        public static implicit operator int(LParam lParam) => (int)lParam.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lParam"></param>
        public static explicit operator uint(LParam lParam) => (uint)lParam.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator LParam(int value) => new(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator LParam(nint value) => new(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lParam"></param>
        public static implicit operator nint(LParam lParam) => lParam.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator LParam((int high, int low) value) => new(value.high, value.low);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lParam"></param>
        public static unsafe implicit operator void*(LParam lParam) => (void*)lParam.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static unsafe implicit operator LParam(void* value) => new((nint)value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lParam"></param>
        public static explicit operator IntPtr(LParam lParam) => new(lParam.Value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator LParam(IntPtr value) => new(value);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value.ToString();
    }
}