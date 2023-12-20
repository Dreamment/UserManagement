namespace Entities.Exceptions.Database
{
    public class UserDeactiveDatabaseException : DatabaseException
    {
        public UserDeactiveDatabaseException(string userName) : base($"User with '{userName}' is deactive. Please contact with support.")
        {
        }
    }
}
