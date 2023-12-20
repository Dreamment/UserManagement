namespace Entities.Exceptions.BadRequest
{
    public class TooMuchPropBadRequestException : BadRequestException
    {
        public TooMuchPropBadRequestException(string message) : base(message)
        {
        }
    }
}
