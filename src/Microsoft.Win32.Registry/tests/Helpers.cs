﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Microsoft.Win32.RegistryTests
{
    internal static class Helpers
    {
        [DllImport(Interop.Libraries.Registry_L2, CharSet = CharSet.Unicode, EntryPoint = "RegSetValueW", SetLastError = true)]
        private static extern int RegSetValue(SafeRegistryHandle handle, string value, int regType, string sb, int sizeIgnored);

        internal static bool SetDefaultValue(this RegistryKey key, string value)
        {
            const int REG_SZ = 1;
            return RegSetValue(key.Handle, null, REG_SZ, value, 0) == 0;
        }

        [DllImport(Interop.Libraries.Registry_L1, CharSet = CharSet.Unicode, EntryPoint = "RegQueryValueExW", SetLastError = true)]
        private static extern int RegQueryValueEx(SafeRegistryHandle handle, string valueName, int[] reserved, IntPtr regType, [Out] byte[] value, ref int size);

        internal static bool IsDefaultValueSet(this RegistryKey key)
        {
            const int ERROR_FILE_NOT_FOUND = 2;
            byte[] b = new byte[4];
            int size = 4;
            return RegQueryValueEx(key.Handle, null, null, IntPtr.Zero, b, ref size) != ERROR_FILE_NOT_FOUND;
        }

        [DllImport(Interop.Libraries.ProcessEnvironment, CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern bool SetEnvironmentVariable(string lpName, string lpValue);
    }
}
