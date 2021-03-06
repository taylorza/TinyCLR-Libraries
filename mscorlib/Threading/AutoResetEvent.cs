namespace System.Threading {
    using System.Runtime.CompilerServices;
    public sealed class AutoResetEvent : WaitHandle {

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern public AutoResetEvent(bool initialState);

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern public bool Reset();
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern public bool Set();
    }
}


