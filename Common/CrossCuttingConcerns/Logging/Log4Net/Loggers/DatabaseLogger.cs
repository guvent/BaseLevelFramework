using System.Reflection;
using log4net;

namespace Common.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class DatabaseLogger:LoggerService
    {
        public DatabaseLogger() : base(LogManager.GetLogger( "DatabaseLogger"))
        {
            
        }
    }
}
