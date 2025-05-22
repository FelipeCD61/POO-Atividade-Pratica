using System;

namespace DuckSimulatorImproved.Services
{
    public static class LoggerService
    {
        public static Action<string> LogAction { get; set; }

        public static void Log(string message)
        {
            LogAction?.Invoke(message);
        }
    }
}