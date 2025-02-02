﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class User32
    {
        [DllImport(Libraries.User32, CharSet = CharSet.Unicode)]
        public static extern ID MessageBoxW(IntPtr hWnd, string lpText, string lpCaption, MB uType);

        public static ID MessageBoxW(HandleRef hWnd, string lpText, string lpCaption, MB uType)
        {
            ID result = MessageBoxW(hWnd.Handle, lpText, lpCaption, uType);
            GC.KeepAlive(hWnd.Wrapper);
            return result;
        }
    }
}
