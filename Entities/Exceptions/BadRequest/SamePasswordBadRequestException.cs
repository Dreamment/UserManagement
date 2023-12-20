namespace Entities.Exceptions.BadRequest
{
    public sealed class SamePasswordBadRequestException : BadRequestException
    {
        public SamePasswordBadRequestException() : base("Old password and new password can not be same")
        {
            
        }
    }
}
