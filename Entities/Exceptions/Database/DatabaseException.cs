namespace Entities.Exceptions.Database
{
    public abstract class DatabaseException : Exception
    {
        public DatabaseException(string message) : base(message)
        {

        }
    }
}
