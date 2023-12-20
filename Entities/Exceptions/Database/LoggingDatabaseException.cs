namespace Entities.Exceptions.Database
{
    public sealed class LoggingDatabaseException : DatabaseException
    {
        public LoggingDatabaseException() : base("Something went wrong while logging")
        {
        }
    }
}
