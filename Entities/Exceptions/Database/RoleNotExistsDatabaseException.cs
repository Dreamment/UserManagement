namespace Entities.Exceptions.Database
{
    public sealed class RoleNotExistsDatabaseException : DatabaseException
    {
        public RoleNotExistsDatabaseException(string Role) : base($"Role '{Role}' does not exists.")
        {

        }
    }
}
