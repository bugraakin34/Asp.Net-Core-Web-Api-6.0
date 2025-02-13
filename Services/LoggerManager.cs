using NLog;
using Services.Contracts;

namespace Services
{
    public class LoggerManager : ILoggerService
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void logDebug(string message) => logger.Debug(message);

        public void logError(string message) => logger.Error(message);

        public void logInfo(string message) => logger.Info(message);

        public void logWarning(string message) => logger.Warn(message);
    }
}
