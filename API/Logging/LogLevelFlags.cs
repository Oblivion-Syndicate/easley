//////////////////////////////////////////////
/// Filename: LogLevelFlags.cs
/// Date: July 10, 2024
/// Author: Maverick Liberty
//////////////////////////////////////////////
using System;

namespace Easley.API.Logging
{

    [Flags]
    public enum LogLevelFlags
    {

        None = 0,
        Verbose = 1 << 0,
        Debug = 1 << 1,
        Info = 1 << 2,
        Warn = 1 << 3,
        Error = 1 << 4,
        Fatal = 1 << 5,

        InfoErrorFatal = Info | Error | Fatal,
        InfoWarnFatal = Info | Warn | Fatal,
        InfoWarnErrorFatal = Info | Warn | Error | Fatal,

        /// <summary>
        /// The default log levels
        /// </summary>
        Default = InfoWarnErrorFatal,

        All = ~(~0 << 6)
    }

}
