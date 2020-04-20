using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;

namespace Common.CrossCuttingConcerns.Logging.Log4Net
{
    [Serializable]
    public class LoggerService
    {
        private ILog _log;

        public LoggerService(ILog log)
        {
            _log = log;
        }

        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsIWarnEnabled => _log.IsWarnEnabled;
        public bool IsErrorEnabled => _log.IsErrorEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;

        public void Info(object message)
        {
            if (IsInfoEnabled) _log.Info(message);
        }
        public void Debug(object message)
        {
            if (IsDebugEnabled) _log.Debug(message);
        }
        public void Warn(object message)
        {
            if (IsIWarnEnabled) _log.Warn(message);
        }
        public void Error(object message)
        {
            if (IsErrorEnabled) _log.Error(message);
        }
        public void Fatal(object message)
        {
            if (IsFatalEnabled) _log.Fatal(message);
        }
    }
}
