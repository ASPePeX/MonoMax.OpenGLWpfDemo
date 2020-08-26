using System;
using System.Runtime.InteropServices;

namespace MonoMax.WPFGLControl
{
    internal static class DXInterop
    {
        internal const uint D3D_SDK_VERSION = 32;

        [DllImport("d3d9.dll")]
        internal static extern IntPtr Direct3DCreate9(uint SDKVersion);
    }
}
