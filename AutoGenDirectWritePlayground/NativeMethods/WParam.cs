namespace AutoGenDirectWritePlayground
{
    /// <summary>
    /// 
    /// </summary>
    public struct WParam
    {
        /// <summary>
        /// 
        /// </summary>
        public nuint Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public WParam(nuint value) => Value = value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator WParam(UIntPtr value) => new(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator nuint(WParam value) => value.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator uint(WParam value) => (uint)value.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator WParam(uint value) => new(value);

        // We make these explicit as we want to encourage keeping signed/unsigned alignment
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static unsafe explicit operator WParam(nint value) => new((nuint)value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static unsafe explicit operator nint(WParam value) => new IntPtr((nint)value.Value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator int(WParam value) => (int)(uint)value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator WParam(int value) => new((nuint)value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator char(WParam value) => (char)(uint)value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator WParam(char value) => new(value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static unsafe implicit operator void*(WParam value) => (void*)value.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static unsafe implicit operator WParam(void* value) => new((nuint)value);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator VirtualKey(WParam value) => (VirtualKey)value.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator WParam(VirtualKey value) => (uint)value;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Value.ToString();
    }
}