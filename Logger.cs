﻿using System;
using log4net;
using log4net.Core;

namespace SequenceEngine
{
  /// <summary>
  /// Provides a wrapper for log4net.
  /// </summary>
  public static class Logger
  {
    /// <summary>
    /// The logger.
    /// </summary>
    private static ILog logger = new EmptyLogger();

    /// <summary>
    /// Initializes the specified log.
    /// </summary>
    /// <param name="log">The log.</param>
    public static void Initialize(ILog log)
    {
      logger = log;
    }

    /// <summary>
    /// Gets the logger.
    /// </summary>
    public static ILog Log
    {
      get
      {
        return logger;
      }
    }   
  }

  /// <summary>
  /// An empty logger so logging will do nothing if the project doesn't setup logging.
  /// </summary>
  public class EmptyLogger : ILog
  {
    public void Debug(object message, Exception exception)
    {
    }

    public void Debug(object message)
    {
    }

    public void DebugFormat(IFormatProvider provider, string format, params object[] args)
    {
    }

    public void DebugFormat(string format, object arg0, object arg1, object arg2)
    {
    }

    public void DebugFormat(string format, object arg0, object arg1)
    {
    }

    public void DebugFormat(string format, object arg0)
    {
    }

    public void DebugFormat(string format, params object[] args)
    {
    }

    public void Error(object message, Exception exception)
    {
    }

    public void Error(object message)
    {
    }

    public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
    {
    }

    public void ErrorFormat(string format, object arg0, object arg1, object arg2)
    {
    }

    public void ErrorFormat(string format, object arg0, object arg1)
    {
    }

    public void ErrorFormat(string format, object arg0)
    {
    }

    public void ErrorFormat(string format, params object[] args)
    {
    }

    public void Fatal(object message, Exception exception)
    {
    }

    public void Fatal(object message)
    {
    }

    public void FatalFormat(IFormatProvider provider, string format, params object[] args)
    {
    }

    public void FatalFormat(string format, object arg0, object arg1, object arg2)
    {
    }

    public void FatalFormat(string format, object arg0, object arg1)
    {
    }

    public void FatalFormat(string format, object arg0)
    {
    }

    public void FatalFormat(string format, params object[] args)
    {
    }

    public void Info(object message, Exception exception)
    {
    }

    public void Info(object message)
    {
    }

    public void InfoFormat(IFormatProvider provider, string format, params object[] args)
    {
    }

    public void InfoFormat(string format, object arg0, object arg1, object arg2)
    {
    }

    public void InfoFormat(string format, object arg0, object arg1)
    {
    }

    public void InfoFormat(string format, object arg0)
    {
    }

    public void InfoFormat(string format, params object[] args)
    {
    }

    public bool IsDebugEnabled
    {
      get { return false; }
    }

    public bool IsErrorEnabled
    {
      get { return false; }
    }

    public bool IsFatalEnabled
    {
      get { return false; }
    }

    public bool IsInfoEnabled
    {
      get { return false; }
    }

    public bool IsWarnEnabled
    {
      get { return false; }
    }

    public void Warn(object message, Exception exception)
    {
    }

    public void Warn(object message)
    {
    }

    public void WarnFormat(IFormatProvider provider, string format, params object[] args)
    {
    }

    public void WarnFormat(string format, object arg0, object arg1, object arg2)
    {
    }

    public void WarnFormat(string format, object arg0, object arg1)
    {
    }

    public void WarnFormat(string format, object arg0)
    {
    }

    public void WarnFormat(string format, params object[] args)
    {      
    }

    public ILogger Logger
    {
      get { return null; }
    }
  }
}