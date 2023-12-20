namespace Entities.Exceptions.NotFound
{
    public sealed class EntityNotFoundException : NotFoundException
    {
        public EntityNotFoundException(string EntityType, Guid? id) : base(GetErrorMessageId(EntityType, id))
        {

        }
        public EntityNotFoundException(string? userName) : base(GetErrorMessageName(userName))
        {

        }

        private static string GetErrorMessageId(string EntityType, Guid? id)
        {
            string entityType = char.ToUpper(EntityType[0]) + EntityType[1..].ToLower();
            return $"{entityType} with id '{id} not found'";
        }

        private static string GetErrorMessageName(string? userName)
        {
            return $"User with username '{userName}' not found";
        }
    }
}
