using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Selenium.Base
{
    internal class TestLogger
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static void LogInfo(string message)
        {
            logger.Info(message);
        }

        public static void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public static void LogWarning(string message)
        {
            logger.Warn(message);
        }

        public static void LogError(string message, Exception ex = null)
        {
            if (ex == null)
            {
                logger.Error(message);
            }
            else
            {
                logger.Error(ex, message);
            }
        }
    }
}
