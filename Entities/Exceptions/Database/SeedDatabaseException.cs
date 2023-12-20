namespace Entities.Exceptions.Database
{
    public sealed class SeedDatabaseException : DatabaseException
    {
        public SeedDatabaseException(string message) : base(message) 
        {

        }
    }
}
