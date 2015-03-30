// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

internal partial class Interop
{
    internal partial class mincore
    {
        internal partial class Errors
        {
            internal const int ERROR_SUCCESS = 0x0;
            internal const int ERROR_INVALID_FUNCTION = 0x1;
            internal const int ERROR_FILE_NOT_FOUND = 0x2;
            internal const int ERROR_PATH_NOT_FOUND = 0x3;
            internal const int ERROR_ACCESS_DENIED = 0x5;
            internal const int ERROR_INVALID_HANDLE = 0x6;
            internal const int ERROR_NOT_ENOUGH_MEMORY = 0x8;
            internal const int ERROR_INVALID_DATA = 0xD;
            internal const int ERROR_INVALID_DRIVE = 0xF;
            internal const int ERROR_NO_MORE_FILES = 0x12;
            internal const int ERROR_NOT_READY = 0x15;
            internal const int ERROR_BAD_LENGTH = 0x18;
            internal const int ERROR_SHARING_VIOLATION = 0x20;
            internal const int ERROR_LOCK_VIOLATION = 0x21;
            internal const int ERROR_HANDLE_EOF = 0x26;
            internal const int ERROR_FILE_EXISTS = 0x50;
            internal const int ERROR_INVALID_PARAMETER = 0x57;
            internal const int ERROR_BROKEN_PIPE = 0x6D;
            internal const int ERROR_INSUFFICIENT_BUFFER = 0x7A;
            internal const int ERROR_INVALID_NAME = 0x7B;
            internal const int ERROR_NEGATIVE_SEEK = 0x83;
            internal const int ERROR_DIR_NOT_EMPTY = 0x91;
            internal const int ERROR_BAD_PATHNAME = 0xA1;
            internal const int ERROR_LOCK_FAILED = 167; // 0xA7
            internal const int ERROR_BUSY = 170; //0xAA
            internal const int ERROR_ALREADY_EXISTS = 0xB7;
            internal const int ERROR_BAD_EXE_FORMAT = 193; // 0xC1
            internal const int ERROR_ENVVAR_NOT_FOUND = 0xCB;
            internal const int ERROR_FILENAME_EXCED_RANGE = 0xCE;
            internal const int ERROR_EXE_MACHINE_TYPE_MISMATCH = 216; //0xD8
            internal const int ERROR_PIPE_BUSY = 0xE7;
            internal const int ERROR_NO_DATA = 0xE8;
            internal const int ERROR_PIPE_NOT_CONNECTED = 0xE9;
            internal const int ERROR_MORE_DATA = 0xEA;
            internal const int ERROR_NO_MORE_ITEMS = 0x103;
            internal const int ERROR_PARTIAL_COPY = 299; //0x12B
            internal const int ERROR_ARITHMETIC_OVERFLOW = 0x216;
            internal const int ERROR_PIPE_CONNECTED = 0x217;
            internal const int ERROR_PIPE_LISTENING = 0x218;
            internal const int ERROR_OPERATION_ABORTED = 0x3E3;
            internal const int ERROR_IO_PENDING = 0x3E5;
            internal const int ERROR_DLL_INIT_FAILED = 0x45A;
            internal const int ERROR_NOT_FOUND = 0x490;
            internal const int ERROR_BAD_IMPERSONATION_LEVEL = 0x542;
            internal const int ERROR_RESOURCE_LANG_NOT_FOUND = 0x717;
            internal const int EFail = unchecked((int)0x80004005);
        }
    }
}