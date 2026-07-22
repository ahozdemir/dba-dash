using System;

namespace DBAHawk
{
    public interface IErrorLogger
    {
        public void LogError(Exception ex, string errorSource, string errorContext);
    }
}