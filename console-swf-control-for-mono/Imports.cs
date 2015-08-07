// Copyright (c) 2015 Dave Kerr, MIT license

using System;
using System.Runtime.InteropServices;

namespace ConsoleControlAPI
{
    /// <summary>
    /// The type of signal to be generated.
    /// </summary>
    internal enum CTRL_EVENT : uint
    {
        /// <summary>
        /// Generates a CTRL+C signal. This signal cannot be generated for process groups. If dwProcessGroupId is nonzero, this function will succeed, but the CTRL+C signal will not be received by processes within the specified process group.
        /// </summary>
        CTRL_C_EVENT = 0,

        /// <summary>
        /// Generates a CTRL+BREAK signal.
        /// </summary>
        CTRL_BREAK_EVENT = 1
    }
}