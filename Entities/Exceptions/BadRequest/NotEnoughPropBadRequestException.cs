namespace Entities.Exceptions.BadRequest
{
    public sealed class NotEnoughPropBadRequestException : BadRequestException
    {
        public NotEnoughPropBadRequestException(string message) : base(message)
        {
        }
    }
}
