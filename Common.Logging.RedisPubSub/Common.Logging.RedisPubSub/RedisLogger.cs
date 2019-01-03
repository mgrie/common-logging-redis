using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Logging.RedisPubSub
{
    class RedisLogger : Common.Logging.Simple.AbstractSimpleLogger
    {
        public RedisLogger(string logName, LogLevel logLevel, bool showlevel, bool showDateTime, bool showLogName, string dateTimeFormat) : base(logName, logLevel, showlevel, showDateTime, showLogName, dateTimeFormat)
        {
        }

        protected override void WriteInternal(LogLevel level, object message, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
