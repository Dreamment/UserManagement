namespace Entities.Exceptions.Database
{
    public sealed class SavingDatabaseException : DatabaseException
    {
        public SavingDatabaseException() : base("Something went wrong while saving data to database")
        {

        }
    }
}
