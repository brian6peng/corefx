// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class Crypto
    {
        [DllImport(Libraries.CryptoNative)]
        internal static extern SafeX509StoreCtxHandle X509StoreCtxCreate();

        [DllImport(Libraries.CryptoNative)]
        internal static extern void X509StoreCtxDestroy(IntPtr v);

        [DllImport(Libraries.CryptoNative)]
        internal static extern SafeX509StackHandle X509StoreCtxGetChain(SafeX509StoreCtxHandle ctx);

        [DllImport(Libraries.CryptoNative, EntryPoint = "X509StoreCtxGetSharedUntrusted")]
        private static extern SafeSharedX509StackHandle X509StoreCtxGetSharedUntrusted_private(SafeX509StoreCtxHandle ctx);

        [DllImport(Libraries.CryptoNative)]
        internal static extern IntPtr X509StoreCtxGetTargetCert(SafeX509StoreCtxHandle ctx);

        internal static SafeSharedX509StackHandle X509StoreCtxGetSharedUntrusted(SafeX509StoreCtxHandle ctx)
        {
            return SafeInteriorHandle.OpenInteriorHandle(
                x => X509StoreCtxGetSharedUntrusted_private(x),
                ctx);
        }
    }
}

namespace Microsoft.Win32.SafeHandles
{
    internal sealed class SafeX509StoreCtxHandle : SafeHandle
    {
        private SafeX509StoreCtxHandle() :
            base(IntPtr.Zero, ownsHandle: true)
        {
        }

        internal SafeX509StoreCtxHandle(IntPtr handle, bool ownsHandle) :
            base(handle, ownsHandle)
        {
        }

        protected override bool ReleaseHandle()
        {
            Interop.Crypto.X509StoreCtxDestroy(handle);
            SetHandle(IntPtr.Zero);
            return true;
        }

        public override bool IsInvalid
        {
            get { return handle == IntPtr.Zero; }
        }
    }
}
