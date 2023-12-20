namespace Entities.Exceptions.Database
{
    public class UserNameAlreadyRegisteredDatabaseException : DatabaseException
    {
        public UserNameAlreadyRegisteredDatabaseException(string UserName) : base($"User name '{UserName}' is already registered.")
        {

        }
    }
}
