namespace Entities.Exceptions.BadRequest
{
    public sealed class PasswordWrongBadRequestException : BadRequestException
    {
        public PasswordWrongBadRequestException() : base("Password is wrong")
        {
            
        }
    }
}
