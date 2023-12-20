namespace Entities.Exceptions.Database
{
    public sealed class AlreadyExistsDatabaseException : DatabaseException
    {
        public AlreadyExistsDatabaseException(string Type, string id) : base (GetErrorMessage(Type, id))
        {
            
        }

        public AlreadyExistsDatabaseException(string Type) : base (GetErrorMessage(Type))
        {
            
        }
        private static string GetErrorMessage(string Type, string id)
        {
            string type = char.ToUpper(Type[0]) + Type[1..].ToLower();
            return $"{type} with id '{id}' is already using by another user.";
        }
        private static string GetErrorMessage(string Type)
        {
            string type = char.ToUpper(Type[0]) + Type[1..].ToLower();
            return $"{type} is already using by another user.";
        }
    }
}
