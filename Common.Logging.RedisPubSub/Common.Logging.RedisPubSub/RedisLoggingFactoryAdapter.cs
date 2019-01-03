using System;
using System.Collections.Generic;
using System.Text;
using Common.Logging.Configuration;

namespace Common.Logging.Redis
{
    public class RedisLoggingFactoryAdapter : Common.Logging.Simple.AbstractSimpleLoggerFactoryAdapter
    {
        public RedisLoggingFactoryAdapter(NameValueCollection properties) : base(properties)
        {
        }

        public RedisLoggingFactoryAdapter(LogLevel level, bool showDateTime, bool showLogName, bool showLevel, string dateTimeFormat) : base(level, showDateTime, showLogName, showLevel, dateTimeFormat)
        {
        }

        protected override ILog CreateLogger(string name, LogLevel level, bool showLevel, bool showDateTime, bool showLogName,
            string dateTimeFormat)
        {
            throw new NotImplementedException();
        }
    }
}
