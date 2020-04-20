using System.Reflection;
using log4net;

namespace Common.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class FileLogger:LoggerService
    {
        // yukarıdaki gibi konfigurasyondan alınmalı...
        // public FileLogger(ILog log) : base(log)

        public FileLogger() : base(LogManager.GetLogger( "FileLogger"))
        {
        }
    }
}
