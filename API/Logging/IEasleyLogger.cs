///////////////////////////////////////////////////////
/// Filename: IEasleyLogger.cs
/// Date: July 20, 2025
/// Author: Maverick Liberty
///////////////////////////////////////////////////////

using System;

namespace Easley.API.Logging
{

    public interface IEasleyLogger
    {

        string Format { get => "[{category}-{level}]: {message}"; }

        LogLevelFlags Level { get; }

        bool Msg(IEasleyLoggable loggable, LogLevelFlags level,
            string message,
            Exception exception = null);

        bool Msg(IEasleyLoggable loggable, LogLevelFlags level,
            TemplatedMessage message,
            Exception exception = null);

        bool Warn(IEasleyLoggable loggable, string message,
            Exception exception = null);

        bool Warn(IEasleyLoggable loggable, TemplatedMessage message,
            Exception exception = null);

        bool Fatal(IEasleyLoggable loggable, string message,
            Exception exception = null);

        bool Fatal(IEasleyLoggable loggable, TemplatedMessage message,
            Exception exception = null);

        bool Error(IEasleyLoggable loggable, string message,
            Exception exception = null);

        bool Error(IEasleyLoggable loggable, TemplatedMessage message,
            Exception exception = null);

        bool Info(IEasleyLoggable loggable, string message,
            Exception exception = null);

        bool Info(IEasleyLoggable loggable, TemplatedMessage message,
            Exception exception = null);

        bool Verbose(IEasleyLoggable loggable, string message,
            Exception exception = null);

        bool Verbose(IEasleyLoggable loggable, TemplatedMessage message,
            Exception exception = null);

        bool Debug(IEasleyLoggable loggable, string message,
            Exception exception = null);

        bool Debug(IEasleyLoggable loggable, TemplatedMessage message,
            Exception exception = null);

    }

}